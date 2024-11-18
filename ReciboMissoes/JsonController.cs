using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReciboMissoes
{
    public class JsonController
    {
        public void JsonSerializarLista<T>(string path, List<T> objects)
        {
            var strJson = JsonConvert.SerializeObject(objects, Formatting.Indented);
            try
            {
                using (StreamWriter sw = new StreamWriter(@path))
                {
                    sw.WriteLine(strJson);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao Salvou Lista" + ex.Message);
            }
        }
        public static string AbrirArquivoClasses(string path)
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
            catch (Exception ex)
            {
                return "Falha: " + ex.Message;
            }
        }
        public static void ClearJsonFile(string path)
        {
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
