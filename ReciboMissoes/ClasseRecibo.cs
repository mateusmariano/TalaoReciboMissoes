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

         public static string path = "../../../../PdfTeste/recibodb.json";
         // public static string path = "recibodb.json";


        JsonController jsonController = new JsonController();

        public double CalcTotal() => MissoesValor + OfertaValor;
        public void SalvarListaJson(List<ClasseRecibo> classes) => 
                    jsonController.JsonSerializarLista(path, classes);
        public static List<ClasseRecibo> JsonDessirializarLista ()
        {
            var strJson = JsonController.AbrirArquivoClasses(path);

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
                return listaRecibos;
            }
        }
    }
}
