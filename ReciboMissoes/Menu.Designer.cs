namespace ReciboMissoes
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            CadernoButton = new Button();
            RecibosButton = new Button();
            SuspendLayout();
            // 
            // CadernoButton
            // 
            CadernoButton.BackColor = Color.SteelBlue;
            CadernoButton.Font = new Font("Arial", 20F);
            CadernoButton.Location = new Point(206, 192);
            CadernoButton.Name = "CadernoButton";
            CadernoButton.Size = new Size(370, 97);
            CadernoButton.TabIndex = 0;
            CadernoButton.Text = "Caderno de Registros";
            CadernoButton.UseVisualStyleBackColor = false;
            CadernoButton.Click += CadernoButton_Click;
            // 
            // RecibosButton
            // 
            RecibosButton.BackColor = Color.SteelBlue;
            RecibosButton.Font = new Font("Arial", 20F);
            RecibosButton.Location = new Point(206, 338);
            RecibosButton.Name = "RecibosButton";
            RecibosButton.Size = new Size(370, 97);
            RecibosButton.TabIndex = 1;
            RecibosButton.Text = "Gerar Recibos";
            RecibosButton.UseVisualStyleBackColor = false;
            RecibosButton.Click += RecibosButton_Click;
            // 
            // Menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(732, 773);
            Controls.Add(RecibosButton);
            Controls.Add(CadernoButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button CadernoButton;
        private Button RecibosButton;
    }
}