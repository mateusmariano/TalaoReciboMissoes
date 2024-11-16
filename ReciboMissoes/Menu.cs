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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void CadernoButton_Click(object sender, EventArgs e)
        {
            CadernoRegistros form = new CadernoRegistros();
            form.Show();
        }

        private void RecibosButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}

//TODO
// ver quando gera recibo sem valores escritos e da erro
//continuar fazendo cadernos
//
//
//
//
