namespace ReciboMissoes
{
    partial class CadernoRegistros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadernoRegistros));
            dataGridView1 = new DataGridView();
            descricaoTxt = new TextBox();
            compTxt = new TextBox();
            entTxt = new TextBox();
            saidaTxt = new TextBox();
            SalvarCaderno = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(15, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView1.Size = new Size(1321, 437);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // descricaoTxt
            // 
            descricaoTxt.Anchor = AnchorStyles.None;
            descricaoTxt.BackColor = SystemColors.Window;
            descricaoTxt.Font = new Font("Segoe UI", 15F);
            descricaoTxt.ForeColor = Color.Navy;
            descricaoTxt.Location = new Point(11, 154);
            descricaoTxt.Margin = new Padding(2, 3, 2, 3);
            descricaoTxt.Name = "descricaoTxt";
            descricaoTxt.Size = new Size(330, 41);
            descricaoTxt.TabIndex = 1;
            // 
            // compTxt
            // 
            compTxt.Anchor = AnchorStyles.None;
            compTxt.BackColor = SystemColors.Window;
            compTxt.Font = new Font("Segoe UI", 15F);
            compTxt.ForeColor = Color.Navy;
            compTxt.Location = new Point(355, 154);
            compTxt.Margin = new Padding(2, 3, 2, 3);
            compTxt.Name = "compTxt";
            compTxt.Size = new Size(421, 41);
            compTxt.TabIndex = 1;
            // 
            // entTxt
            // 
            entTxt.Anchor = AnchorStyles.None;
            entTxt.BackColor = SystemColors.Window;
            entTxt.Font = new Font("Segoe UI", 15F);
            entTxt.ForeColor = Color.Navy;
            entTxt.Location = new Point(798, 154);
            entTxt.Margin = new Padding(2, 3, 2, 3);
            entTxt.Name = "entTxt";
            entTxt.Size = new Size(320, 41);
            entTxt.TabIndex = 1;
            // 
            // saidaTxt
            // 
            saidaTxt.Anchor = AnchorStyles.None;
            saidaTxt.BackColor = SystemColors.Window;
            saidaTxt.Font = new Font("Segoe UI", 15F);
            saidaTxt.ForeColor = Color.Navy;
            saidaTxt.Location = new Point(1133, 154);
            saidaTxt.Margin = new Padding(2, 3, 2, 3);
            saidaTxt.Name = "saidaTxt";
            saidaTxt.Size = new Size(204, 41);
            saidaTxt.TabIndex = 1;
            // 
            // SalvarCaderno
            // 
            SalvarCaderno.BackColor = Color.SteelBlue;
            SalvarCaderno.Font = new Font("Arial", 20F);
            SalvarCaderno.Location = new Point(414, 210);
            SalvarCaderno.Name = "SalvarCaderno";
            SalvarCaderno.Size = new Size(307, 56);
            SalvarCaderno.TabIndex = 2;
            SalvarCaderno.Text = "Salvar no caderno";
            SalvarCaderno.UseVisualStyleBackColor = false;
            SalvarCaderno.Click += SalvarCaderno_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Arial", 20F);
            button1.Location = new Point(811, 210);
            button1.Name = "button1";
            button1.Size = new Size(307, 56);
            button1.TabIndex = 3;
            button1.Text = "Excluir Registro";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CadernoRegistros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1348, 721);
            Controls.Add(button1);
            Controls.Add(SalvarCaderno);
            Controls.Add(saidaTxt);
            Controls.Add(entTxt);
            Controls.Add(compTxt);
            Controls.Add(descricaoTxt);
            Controls.Add(dataGridView1);
            Name = "CadernoRegistros";
            Text = "CadernoRegistros";
            Load += CadernoRegistros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox descricaoTxt;
        private TextBox compTxt;
        private TextBox entTxt;
        private TextBox saidaTxt;
        private Button SalvarCaderno;
        private Button button1;
    }
}