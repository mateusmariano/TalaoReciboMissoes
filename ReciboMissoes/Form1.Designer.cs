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
            button1 = new Button();
            valorOfertaTxt = new TextBox();
            nomeMembroTxt = new TextBox();
            congTxt = new TextBox();
            emissorTxt = new TextBox();
            SuspendLayout();
            // 
            // valorMissoestxt
            // 
            valorMissoestxt.BackColor = SystemColors.ControlLight;
            valorMissoestxt.Font = new Font("Segoe UI", 22F);
            valorMissoestxt.ForeColor = Color.Navy;
            valorMissoestxt.Location = new Point(313, 231);
            valorMissoestxt.Name = "valorMissoestxt";
            valorMissoestxt.Size = new Size(425, 56);
            valorMissoestxt.TabIndex = 0;
            valorMissoestxt.TextChanged += valorMissoestxt_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Arial", 20F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(254, 711);
            button1.Name = "button1";
            button1.Size = new Size(248, 56);
            button1.TabIndex = 2;
            button1.Text = "GERAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // valorOfertaTxt
            // 
            valorOfertaTxt.BackColor = SystemColors.ControlLight;
            valorOfertaTxt.Font = new Font("Segoe UI", 22F);
            valorOfertaTxt.ForeColor = Color.Navy;
            valorOfertaTxt.Location = new Point(313, 322);
            valorOfertaTxt.Name = "valorOfertaTxt";
            valorOfertaTxt.Size = new Size(425, 56);
            valorOfertaTxt.TabIndex = 3;
            valorOfertaTxt.TextChanged += valorOfertaTxt_TextChanged;
            // 
            // nomeMembroTxt
            // 
            nomeMembroTxt.BackColor = SystemColors.ControlLight;
            nomeMembroTxt.Font = new Font("Segoe UI", 17F);
            nomeMembroTxt.ForeColor = Color.Navy;
            nomeMembroTxt.Location = new Point(219, 408);
            nomeMembroTxt.Name = "nomeMembroTxt";
            nomeMembroTxt.Size = new Size(519, 45);
            nomeMembroTxt.TabIndex = 5;
            // 
            // congTxt
            // 
            congTxt.BackColor = SystemColors.ControlLight;
            congTxt.Font = new Font("Segoe UI", 17F);
            congTxt.ForeColor = Color.Navy;
            congTxt.Location = new Point(288, 492);
            congTxt.Name = "congTxt";
            congTxt.Size = new Size(450, 45);
            congTxt.TabIndex = 7;
            // 
            // emissorTxt
            // 
            emissorTxt.BackColor = SystemColors.ControlLight;
            emissorTxt.Font = new Font("Segoe UI", 17F);
            emissorTxt.ForeColor = Color.Navy;
            emissorTxt.Location = new Point(187, 611);
            emissorTxt.Name = "emissorTxt";
            emissorTxt.Size = new Size(551, 45);
            emissorTxt.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(750, 779);
            Controls.Add(emissorTxt);
            Controls.Add(congTxt);
            Controls.Add(nomeMembroTxt);
            Controls.Add(valorOfertaTxt);
            Controls.Add(button1);
            Controls.Add(valorMissoestxt);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox valorMissoestxt;
        private Button button1;
        private TextBox valorOfertaTxt;
        private TextBox nomeMembroTxt;
        private TextBox congTxt;
        private TextBox emissorTxt;
    }
}
