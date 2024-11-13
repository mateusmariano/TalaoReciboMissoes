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

            ReciboViewer rv = new ReciboViewer( double.Parse(valorMissoestxt.Text),
                                                double.Parse(valorOfertaTxt.Text), 
                                                nomeMembroTxt.Text,
                                                congTxt.Text,
                                                CalcTotal());
            rv.Show();
        }
        private double CalcTotal() => double.Parse(valorMissoestxt.Text) + double.Parse(valorOfertaTxt.Text);
    }
}
