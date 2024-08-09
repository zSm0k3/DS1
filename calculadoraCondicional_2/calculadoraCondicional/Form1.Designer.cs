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
            lblValor1 = new Label();
            lblValor2 = new Label();
            lblOperacao = new Label();
            lblTotal = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtTotal = new TextBox();
            cboOperacao = new ComboBox();
            SuspendLayout();
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Font = new Font("Segoe UI", 12F);
            lblValor1.Location = new Point(48, 46);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(92, 32);
            lblValor1.TabIndex = 0;
            lblValor1.Text = "Valor 1:";
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Font = new Font("Segoe UI", 12F);
            lblValor2.Location = new Point(48, 114);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(92, 32);
            lblValor2.TabIndex = 1;
            lblValor2.Text = "Valor 2:";
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Font = new Font("Segoe UI", 12F);
            lblOperacao.Location = new Point(19, 186);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(121, 32);
            lblOperacao.TabIndex = 2;
            lblOperacao.Text = "Operação:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(52, 261);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 32);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(170, 49);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(180, 31);
            txtValor1.TabIndex = 4;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(170, 117);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(180, 31);
            txtValor2.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(170, 261);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(180, 31);
            txtTotal.TabIndex = 6;
            // 
            // cboOperacao
            // 
            cboOperacao.FormattingEnabled = true;
            cboOperacao.Items.AddRange(new object[] { "Selecione", "Adição", "Subtração", "Multiplicação", "Divisão" });
            cboOperacao.Location = new Point(170, 189);
            cboOperacao.Name = "cboOperacao";
            cboOperacao.Size = new Size(180, 33);
            cboOperacao.TabIndex = 7;
            cboOperacao.SelectedIndexChanged += cboOperacao_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(478, 344);
            Controls.Add(cboOperacao);
            Controls.Add(txtTotal);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(lblTotal);
            Controls.Add(lblOperacao);
            Controls.Add(lblValor2);
            Controls.Add(lblValor1);
            Name = "Form1";
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
    }
}
