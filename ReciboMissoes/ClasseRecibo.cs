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
        internal int IdRecibo {  get; set; } //terá que ser sempre o length da lista de recibos + 1
        public double MissoesValor { get; set; }
        public double OfertaValor { get; set; }
        public double Total {  get; set; }
        public string Membro {  get; set; }
        public string Congregacao { get; set; }
        public DateTime Data {  get; set; }
        public string Emissor {  get; set; }

        public string JsonSerializar(ClasseRecibo classeRecibo) => JsonConvert.SerializeObject(classeRecibo);
        public static ClasseRecibo JsonDesSerializar(string json) => JsonConvert.DeserializeObject<ClasseRecibo>(json);

    }
}
