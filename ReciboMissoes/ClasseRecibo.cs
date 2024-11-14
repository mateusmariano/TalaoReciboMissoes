using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReciboMissoes
{
    public class ClasseRecibo
    {
        public int NumeroRecibo {  get; set; }
        public double MissoesValor { get; set; }
        public double OfertaValor { get; set; }
        public double Total {  get; set; }
        public string Membro {  get; set; }
        public string Congregacao { get; set; }
        public DateTime Data {  get; set; }
        public string Emissor {  get; set; }

        // public static string path = "../../../../PdfTeste/recibodb.json";
         public static string path = "recibodb.json";
        public double CalcTotal() => MissoesValor + OfertaValor;
        public void JsonSerializarLista(List<ClasseRecibo> classes)
        {
            var strJson = JsonConvert.SerializeObject(classes, Formatting.Indented);
            try
            {
                using (StreamWriter sw = new StreamWriter(@path))
                {
                    sw.WriteLine(strJson);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Nao Salvou Lista" + ex.Message);
            }
        }
        public static List<ClasseRecibo> JsonDessirializarLista ()
        {
            var strJson = AbrirArquivoClasses();
            if (!String.IsNullOrEmpty(strJson))
            {
                if (strJson.Substring(0, 5) != "Falha")
                {
                    return JsonConvert.DeserializeObject<List<ClasseRecibo>>(strJson);
                } else
                {
                    return new List<ClasseRecibo>();
                }
            } else
            {
                var listaRecibos = new List<ClasseRecibo>();
               // MessageBox.Show("ListaVazia");
                return listaRecibos;
            }
        }

        public bool SalvarArquivoClasses(string strJson)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@path))
                {
                    sw.WriteLine(strJson);
                }
                MessageBox.Show("ARquivo Salvo");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu Erro " + ex.Message);
                return false;
            }

        }
        private static string AbrirArquivoClasses()
        {
            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(@path))
                {
                    strJson = sr.ReadToEnd();
                    //MessageBox.Show((String.IsNullOrEmpty(strJson)).ToString());
                }
                return strJson;
            }
            catch (Exception ex) { 
                return "Falha: " + ex.Message;
            }       
        }

        public static void ClearJsonFile() {
            try
            {
                using (StreamWriter sw = new StreamWriter(@path))
                {
                    sw.Write("");
                }
                MessageBox.Show("A lista de recibos foi esvaziada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível esvaziar a lista de recibos" + ex.Message);
            }
        }
    }
}
