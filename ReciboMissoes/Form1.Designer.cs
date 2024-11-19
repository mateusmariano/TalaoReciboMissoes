namespace ReciboMissoes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            valorMissoestxt = new TextBox();
            valorOfertaTxt = new TextBox();
            nomeMembroTxt = new TextBox();
            congTxt = new TextBox();
            emissorTxt = new TextBox();
            dataGrid1 = new DataGridView();
            gerarReciboButton = new Button();
            atualizarListaDataGrid = new Button();
            excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid1).BeginInit();
            SuspendLayout();
            // 
            // valorMissoestxt
            // 
            resources.ApplyResources(valorMissoestxt, "valorMissoestxt");
            valorMissoestxt.BackColor = SystemColors.ControlLight;
            valorMissoestxt.ForeColor = Color.Navy;
            valorMissoestxt.Name = "valorMissoestxt";
            valorMissoestxt.TextChanged += valorMissoestxt_TextChanged;
            // 
            // valorOfertaTxt
            // 
            resources.ApplyResources(valorOfertaTxt, "valorOfertaTxt");
            valorOfertaTxt.BackColor = SystemColors.ControlLight;
            valorOfertaTxt.ForeColor = Color.Navy;
            valorOfertaTxt.Name = "valorOfertaTxt";
            valorOfertaTxt.TextChanged += valorOfertaTxt_TextChanged;
            // 
            // nomeMembroTxt
            // 
            resources.ApplyResources(nomeMembroTxt, "nomeMembroTxt");
            nomeMembroTxt.BackColor = SystemColors.ControlLight;
            nomeMembroTxt.ForeColor = Color.Navy;
            nomeMembroTxt.Name = "nomeMembroTxt";
            // 
            // congTxt
            // 
            resources.ApplyResources(congTxt, "congTxt");
            congTxt.BackColor = SystemColors.ControlLight;
            congTxt.ForeColor = Color.Navy;
            congTxt.Name = "congTxt";
            // 
            // emissorTxt
            // 
            resources.ApplyResources(emissorTxt, "emissorTxt");
            emissorTxt.BackColor = SystemColors.ControlLight;
            emissorTxt.ForeColor = Color.Navy;
            emissorTxt.Name = "emissorTxt";
            // 
            // dataGrid1
            // 
            dataGrid1.BackgroundColor = Color.LightSkyBlue;
            dataGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGrid1, "dataGrid1");
            dataGrid1.Name = "dataGrid1";
            dataGrid1.CellClick += dataGrid1_CellClick;
            dataGrid1.CellDoubleClick += dataGrid1_CellDoubleClick;
            // 
            // gerarReciboButton
            // 
            resources.ApplyResources(gerarReciboButton, "gerarReciboButton");
            gerarReciboButton.BackColor = Color.SteelBlue;
            gerarReciboButton.ForeColor = Color.Black;
            gerarReciboButton.Name = "gerarReciboButton";
            gerarReciboButton.UseVisualStyleBackColor = false;
            gerarReciboButton.Click += gerarReciboButton_Click;
            // 
            // atualizarListaDataGrid
            // 
            atualizarListaDataGrid.BackColor = Color.SteelBlue;
            resources.ApplyResources(atualizarListaDataGrid, "atualizarListaDataGrid");
            atualizarListaDataGrid.ForeColor = Color.Black;
            atualizarListaDataGrid.Name = "atualizarListaDataGrid";
            atualizarListaDataGrid.UseVisualStyleBackColor = false;
            atualizarListaDataGrid.Click += atualizarListaDataGrid_Click;
            // 
            // excluir
            // 
            excluir.BackColor = Color.SteelBlue;
            resources.ApplyResources(excluir, "excluir");
            excluir.ForeColor = Color.Black;
            excluir.Name = "excluir";
            excluir.UseVisualStyleBackColor = false;
            excluir.Click += excluir_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            Controls.Add(excluir);
            Controls.Add(atualizarListaDataGrid);
            Controls.Add(gerarReciboButton);
            Controls.Add(dataGrid1);
            Controls.Add(emissorTxt);
            Controls.Add(congTxt);
            Controls.Add(nomeMembroTxt);
            Controls.Add(valorOfertaTxt);
            Controls.Add(valorMissoestxt);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox valorMissoestxt;
        private TextBox valorOfertaTxt;
        private TextBox nomeMembroTxt;
        private TextBox congTxt;
        private TextBox emissorTxt;
        private DataGridView dataGrid1;
        private Button gerarReciboButton;
        private Button atualizarListaDataGrid;
        private Button excluir;
    }
}
