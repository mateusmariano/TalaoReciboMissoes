using System.Diagnostics;
using System.ServiceModel.Channels;

namespace ReciboMissoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declaracao das classes globais
        List<ClasseRecibo> classes = new List<ClasseRecibo>();
        ClasseRecibo classeRecibo = new ClasseRecibo();
        DataGridViewCellEventArgs selectedCell;

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarListaGlobal(); //logo ao carregar traz a lista de recibosEmitidos
        }
        private void AtualizarListaGlobal() => classes = ClasseRecibo.JsonDessirializarLista();

        private void gerarReciboButton_Click(object sender, EventArgs e)
        {
            CriarClasseRecibo(classeRecibo, classes);
            ChamarReciboReport(classeRecibo);
            RegistrarReciboLista(classeRecibo, classes, true);
            AtualizarListaGlobal();
            atualizarListaDataGrid_Click(null, e);
        }

        private void CriarClasseRecibo(ClasseRecibo cslasseRecibo, List<ClasseRecibo> classes)
        {
            classeRecibo.NumeroRecibo = GetLastIndex(classes);
            classeRecibo.MissoesValor = double.Parse(valorMissoestxt.Text);
            classeRecibo.OfertaValor = double.Parse(valorOfertaTxt.Text);
            classeRecibo.Membro = nomeMembroTxt.Text;
            classeRecibo.Congregacao = congTxt.Text;
            classeRecibo.Emissor = emissorTxt.Text;
            classeRecibo.Total = classeRecibo.CalcTotal();
            classeRecibo.Data = DateTime.Now;
        }
        private int GetLastIndex(List<ClasseRecibo> classes)
        {
            return classes.Count > classes[classes.Count - 1].NumeroRecibo ?
                                               classes.Count + 1 :
                                               classes[classes.Count - 1].NumeroRecibo + 1;
        }
        private static void ChamarReciboReport(ClasseRecibo classeRecibo)
        {
            ReciboViewer rv = new ReciboViewer(classeRecibo);
            rv.Show();
        }
        private static void RegistrarReciboLista(ClasseRecibo classeRecibo, List<ClasseRecibo> classes, bool addClass)
        {
            if (addClass)
                classes.Add(classeRecibo);

            classeRecibo.SalvarListaJson(classes);
        }

        private void atualizarListaDataGrid_Click(object sender, EventArgs e)
        {
            classes = ClasseRecibo.JsonDessirializarLista();
            dataGrid1.DataSource = classes;
        }
        private void dataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {}
        private void dataGrid1_CellClick(object sender, DataGridViewCellEventArgs e) => selectedCell = e;
        private void DeletarReciboJson(DataGridViewCellEventArgs e)
        {
            int idParaDeletar = (int)dataGrid1.Rows[e.RowIndex].Cells["NumeroRecibo"].Value;

            for (int i = 0; i < classes.Count; i++)
            {
                if (classes[i].NumeroRecibo == idParaDeletar)
                {
                    classes.Remove(classes[i]);
                    break;
                }
            }
            ClearDataGrid();

            if (classes.Count == 0)
            {
                JsonController.ClearJsonFile(ClasseRecibo.path);
            }
            else
            {
                RegistrarReciboLista(classeRecibo, classes, false);
            }
            AtualizarListaGlobal();
            atualizarListaDataGrid_Click(null, e);
        }

        private void ClearDataGrid()
        {
            dataGrid1.DataSource = null;
            dataGrid1.Rows.Clear();
        }

        private void valorMissoestxt_TextChanged(object sender, EventArgs e) =>
                                                CheckNumber(valorMissoestxt);

        private void valorOfertaTxt_TextChanged(object sender, EventArgs e) =>
                                                CheckNumber(valorOfertaTxt);
        private void CheckNumber(TextBox t)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(t.Text, "[^0-9]"))
            {
                MessageBox.Show("Insira apenas números");
                t.Text = t.Text.Remove(t.Text.Length - 1);
            }
        }
        private void excluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja excluir registro?", "Excluir", MessageBoxButtons.YesNo);
            if (selectedCell != null)
            {
                switch (dr)
                {
                    case DialogResult.Yes:
                        DeletarReciboJson(selectedCell);
                        break;
                }
            } else
            {
                MessageBox.Show("Selecione um registro para excluir");
            }
        }

    }
}
