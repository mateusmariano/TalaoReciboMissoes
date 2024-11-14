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

            ReciboViewer rv = new ReciboViewer(double.Parse(valorMissoestxt.Text),
                                                double.Parse(valorOfertaTxt.Text),
                                                nomeMembroTxt.Text,
                                                congTxt.Text,
                                                CalcTotal());
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
