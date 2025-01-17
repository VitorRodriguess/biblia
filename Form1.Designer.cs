namespace biblia
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
            lstBoxLivros = new ListBox();
            lstBoxCapitulos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbBoxInicial = new ComboBox();
            cmbBoxFinal = new ComboBox();
            label4 = new Label();
            btnListarVersiculos = new Button();
            label5 = new Label();
            txtVersiculos = new TextBox();
            SuspendLayout();
            // 
            // lstBoxLivros
            // 
            lstBoxLivros.FormattingEnabled = true;
            lstBoxLivros.ItemHeight = 15;
            lstBoxLivros.Location = new Point(16, 12);
            lstBoxLivros.Name = "lstBoxLivros";
            lstBoxLivros.Size = new Size(366, 244);
            lstBoxLivros.TabIndex = 0;
            lstBoxLivros.SelectedIndexChanged += lstBoxLivros_SelectedIndexChanged;
            // 
            // lstBoxCapitulos
            // 
            lstBoxCapitulos.FormattingEnabled = true;
            lstBoxCapitulos.ItemHeight = 15;
            lstBoxCapitulos.Location = new Point(401, 12);
            lstBoxCapitulos.Name = "lstBoxCapitulos";
            lstBoxCapitulos.Size = new Size(370, 244);
            lstBoxCapitulos.TabIndex = 1;
            lstBoxCapitulos.SelectedIndexChanged += lstBoxCapitulos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 259);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Livros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 259);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Capítulos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 501);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Versículos";
            // 
            // cmbBoxInicial
            // 
            cmbBoxInicial.FormattingEnabled = true;
            cmbBoxInicial.Location = new Point(777, 339);
            cmbBoxInicial.Name = "cmbBoxInicial";
            cmbBoxInicial.Size = new Size(187, 23);
            cmbBoxInicial.TabIndex = 6;
            // 
            // cmbBoxFinal
            // 
            cmbBoxFinal.FormattingEnabled = true;
            cmbBoxFinal.Location = new Point(777, 383);
            cmbBoxFinal.Name = "cmbBoxFinal";
            cmbBoxFinal.Size = new Size(187, 23);
            cmbBoxFinal.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(857, 365);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 8;
            label4.Text = "Ao";
            // 
            // btnListarVersiculos
            // 
            btnListarVersiculos.Location = new Point(777, 426);
            btnListarVersiculos.Name = "btnListarVersiculos";
            btnListarVersiculos.Size = new Size(187, 33);
            btnListarVersiculos.TabIndex = 9;
            btnListarVersiculos.Text = "Listar";
            btnListarVersiculos.UseVisualStyleBackColor = true;
            btnListarVersiculos.Click += btnListarVersiculos_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(777, 311);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 10;
            label5.Text = "De...";
            // 
            // txtVersiculos
            // 
            txtVersiculos.Location = new Point(16, 311);
            txtVersiculos.Multiline = true;
            txtVersiculos.Name = "txtVersiculos";
            txtVersiculos.ReadOnly = true;
            txtVersiculos.ScrollBars = ScrollBars.Vertical;
            txtVersiculos.Size = new Size(755, 187);
            txtVersiculos.TabIndex = 11;
            txtVersiculos.TextChanged += txtVersiculos_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1106, 749);
            Controls.Add(txtVersiculos);
            Controls.Add(label5);
            Controls.Add(btnListarVersiculos);
            Controls.Add(label4);
            Controls.Add(cmbBoxFinal);
            Controls.Add(cmbBoxInicial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstBoxCapitulos);
            Controls.Add(lstBoxLivros);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.GhostWhite;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBoxLivros;
        private ListBox lstBoxCapitulos;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbBoxInicial;
        private ComboBox cmbBoxFinal;
        private Label label4;
        private Button btnListarVersiculos;
        private Label label5;
        private TextBox txtVersiculos;
    }
}
