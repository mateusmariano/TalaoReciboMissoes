using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReciboMissoes
{
    public partial class CadernoRegistros : Form
    {
        public CadernoRegistros()
        {
            InitializeComponent();
        }


        //declaracao das classes globais
        List<CadernoRegistro> registros = new List<CadernoRegistro>();
        CadernoRegistro classeRegistro = new CadernoRegistro();
        private DataGridViewCellEventArgs selectedCell;

        private void CadernoRegistros_Load(object sender, EventArgs e)
        {
            AtualizarListaGlobal();
            atualizarListaDataGrid_Click(null, e);
        }
        private void AtualizarListaGlobal() => registros = CadernoRegistro.JsonDessirializarLista();

        private void SalvarCaderno_Click(object sender, EventArgs e)
        {
            CriarClasseRecibo(classeRegistro, registros);
            RegistrarCadernoLista(classeRegistro, registros, true);
            atualizarListaDataGrid_Click(null, e);
        }

        private void CriarClasseRecibo(CadernoRegistro classeRegistro, List<CadernoRegistro> registros)
        {
            classeRegistro.NumeroRegistro = GetLastIndex(registros);
            classeRegistro.Descricao = descricaoTxt.Text;
            classeRegistro.Competencia = compTxt.Text;
            classeRegistro.Entrada = entTxt.Text;
            classeRegistro.Saida = saidaTxt.Text;
        }
        private int GetLastIndex(List<CadernoRegistro> registros)
        {
            return registros.Count > registros[registros.Count-1].NumeroRegistro ? 
                                               registros.Count + 1 :
                                               registros[registros.Count-1].NumeroRegistro + 1;
        }

        private void RegistrarCadernoLista(CadernoRegistro classeRegistro, List<CadernoRegistro> registros, bool addClass)
        {
            if (addClass)
                registros.Add(classeRegistro);

            classeRegistro.SalvarListaJson(registros);
        }
        private void atualizarListaDataGrid_Click(object sender, EventArgs e)
        {
            registros = CadernoRegistro.JsonDessirializarLista();
            dataGridView1.DataSource = registros;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) => selectedCell = e;

        private void button1_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir");
            }
        }

        private void DeletarReciboJson(DataGridViewCellEventArgs selectedCell)
        {
            int idParaDeletar = (int)dataGridView1.Rows[selectedCell.RowIndex].Cells["NumeroRegistro"].Value;

            for (int i = 0; i < registros.Count; i++)
            {
                if (registros[i].NumeroRegistro == idParaDeletar)
                {
                    registros.Remove(registros[i]);
                    break;
                }
            }
            ClearDataGrid();

            if (registros.Count == 0)
            {
                JsonController.ClearJsonFile(ClasseRecibo.path);
            }
            else
            {
                RegistrarCadernoLista(classeRegistro, registros, false);
            }
            AtualizarListaGlobal();
            atualizarListaDataGrid_Click(null, selectedCell);
        }
        private void ClearDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }
    }
}
