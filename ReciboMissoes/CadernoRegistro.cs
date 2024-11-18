using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReciboMissoes
{
    public class CadernoRegistro
    {
        public int NumeroRegistro { get; set; }
        public string Descricao { get; set; }
        public string Competencia { get; set; }
        public string Entrada { get; set; }
        public string Saida { get; set; }

        public static string path = "../../../../PdfTeste/caderno.json";
        // public static string path = "caderno.json";

        JsonController jsonController = new JsonController();
        public void SalvarListaJson(List<CadernoRegistro> registros) =>
                    jsonController.JsonSerializarLista(path, registros);
        public static List<CadernoRegistro> JsonDessirializarLista()
        {
            var strJson = JsonController.AbrirArquivoClasses(path);

            if (!String.IsNullOrEmpty(strJson))
            {
                if (strJson.Substring(0, 5) != "Falha")
                {
                    return JsonConvert.DeserializeObject<List<CadernoRegistro>>(strJson);
                }
                else
                {
                    return new List<CadernoRegistro>();
                }
            }
            else
            {
                var listaRegistros = new List<CadernoRegistro>();
                return listaRegistros;
            }
        }
    }
}
