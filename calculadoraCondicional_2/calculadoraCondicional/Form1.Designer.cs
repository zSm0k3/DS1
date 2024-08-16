namespace calculadoraCondicional
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
            lblValor1 = new Label();
            lblValor2 = new Label();
            lblOperacao = new Label();
            lblTotal = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtTotal = new TextBox();
            cboOperacao = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Font = new Font("Segoe UI", 12F);
            lblValor1.Location = new Point(34, 28);
            lblValor1.Margin = new Padding(2, 0, 2, 0);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(62, 21);
            lblValor1.TabIndex = 0;
            lblValor1.Text = "Valor 1:";
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Font = new Font("Segoe UI", 12F);
            lblValor2.Location = new Point(34, 68);
            lblValor2.Margin = new Padding(2, 0, 2, 0);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(62, 21);
            lblValor2.TabIndex = 1;
            lblValor2.Text = "Valor 2:";
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Font = new Font("Segoe UI", 12F);
            lblOperacao.Location = new Point(13, 112);
            lblOperacao.Margin = new Padding(2, 0, 2, 0);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(80, 21);
            lblOperacao.TabIndex = 2;
            lblOperacao.Text = "Operação:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(36, 157);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 21);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(119, 29);
            txtValor1.Margin = new Padding(2);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(127, 23);
            txtValor1.TabIndex = 4;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(119, 70);
            txtValor2.Margin = new Padding(2);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(127, 23);
            txtValor2.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(119, 157);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(127, 23);
            txtTotal.TabIndex = 6;
            // 
            // cboOperacao
            // 
            cboOperacao.FormattingEnabled = true;
            cboOperacao.Items.AddRange(new object[] { "Selecione", "Adição", "Subtração", "Multiplicação", "Divisão" });
            cboOperacao.Location = new Point(119, 113);
            cboOperacao.Margin = new Padding(2);
            cboOperacao.Name = "cboOperacao";
            cboOperacao.Size = new Size(127, 23);
            cboOperacao.TabIndex = 7;
            cboOperacao.SelectedIndexChanged += cboOperacao_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 7F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(288, 159);
            button1.Name = "button1";
            button1.Size = new Size(44, 46);
            button1.TabIndex = 8;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(335, 206);
            Controls.Add(button1);
            Controls.Add(cboOperacao);
            Controls.Add(txtTotal);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(lblTotal);
            Controls.Add(lblOperacao);
            Controls.Add(lblValor2);
            Controls.Add(lblValor1);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Revisão Estrutura Condicional";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor1;
        private Label lblValor2;
        private Label lblOperacao;
        private Label lblTotal;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtTotal;
        private ComboBox cboOperacao;
        private Button button1;
    }
}
