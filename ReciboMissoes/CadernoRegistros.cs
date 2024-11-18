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
            classeRegistro.NumeroRegistro = registros.Count + 1;
            classeRegistro.Descricao = descricaoTxt.Text;
            classeRegistro.Competencia = compTxt.Text;
            classeRegistro.Entrada = entTxt.Text;
            classeRegistro.Saida = saidaTxt.Text;
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
    }
}
