namespace ReciboMissoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var classeRecibo = new ClasseRecibo();
            CriarClasseRecibo(classeRecibo);
            ChamarReciboReport(classeRecibo);

            try
            {
                using(StreamWriter sw = new StreamWriter(@"../../../../PdfTeste/recibodb.json"))
                {
                    sw.WriteLine(classeRecibo.JsonSerializar(classeRecibo));
                }
                MessageBox.Show("ARquivo Salvo");
            }
            catch (Exception ex) {
                MessageBox.Show("Deu Erro " + ex.Message);
            }

        }

        private void CriarClasseRecibo(ClasseRecibo classeRecibo)
        {
            classeRecibo.MissoesValor = double.Parse(valorMissoestxt.Text);
            classeRecibo.OfertaValor = double.Parse(valorOfertaTxt.Text);
            classeRecibo.Membro = nomeMembroTxt.Text;
            classeRecibo.Congregacao = congTxt.Text;
            classeRecibo.Emissor = emissorTxt.Text;
            classeRecibo.Total = CalcTotal();
            classeRecibo.Data = DateTime.Now;
        }
        private static void ChamarReciboReport(ClasseRecibo classeRecibo)
        {
            ReciboViewer rv = new ReciboViewer(classeRecibo);
            rv.Show();
        }


        private double CalcTotal() => double.Parse(valorMissoestxt.Text) + 
                                      double.Parse(valorOfertaTxt.Text);

        private void valorMissoestxt_TextChanged(object sender, EventArgs e) => 
                                                CheckNumber(valorMissoestxt);

        private void valorOfertaTxt_TextChanged(object sender, EventArgs e) => 
                                                CheckNumber(valorOfertaTxt);
        private void CheckNumber (TextBox t)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(t.Text, "[^0-9]"))
            {
                MessageBox.Show("Insira apenas números");
                t.Text = t.Text.Remove(t.Text.Length - 1);
            }
        }
    }
}
