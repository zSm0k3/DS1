namespace AvaliacaoPOO
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
            label1 = new Label();
            txtSigla = new TextBox();
            label2 = new Label();
            txtPeriodo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCadastro = new Button();
            cboNivel = new ComboBox();
            btnConsultar = new Button();
            cboNomeCurso = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(56, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // txtSigla
            // 
            txtSigla.BorderStyle = BorderStyle.FixedSingle;
            txtSigla.Font = new Font("Segoe UI", 12F);
            txtSigla.Location = new Point(128, 72);
            txtSigla.Margin = new Padding(2);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(120, 29);
            txtSigla.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(64, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 2;
            label2.Text = "Sigla:";
            // 
            // txtPeriodo
            // 
            txtPeriodo.BorderStyle = BorderStyle.FixedSingle;
            txtPeriodo.Font = new Font("Segoe UI", 12F);
            txtPeriodo.Location = new Point(126, 163);
            txtPeriodo.Margin = new Padding(2);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(141, 29);
            txtPeriodo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(40, 167);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 4;
            label3.Text = "Período:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(55, 121);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 6;
            label4.Text = "Nível:";
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCadastro.Location = new Point(42, 232);
            btnCadastro.Margin = new Padding(2);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(141, 41);
            btnCadastro.TabIndex = 8;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // cboNivel
            // 
            cboNivel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboNivel.FormattingEnabled = true;
            cboNivel.Items.AddRange(new object[] { "Básico", "Médio", "Superior" });
            cboNivel.Location = new Point(127, 122);
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(121, 29);
            cboNivel.TabIndex = 10;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnConsultar.Location = new Point(242, 232);
            btnConsultar.Margin = new Padding(2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(141, 41);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cboNomeCurso
            // 
            cboNomeCurso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboNomeCurso.FormattingEnabled = true;
            cboNomeCurso.Items.AddRange(new object[] { "Administração", "Desenvolv. Sistemas", "Enfermagem", "Ensino Médio", "Informática", "Mecânica", "Recursos Humanos" });
            cboNomeCurso.Location = new Point(127, 28);
            cboNomeCurso.Name = "cboNomeCurso";
            cboNomeCurso.Size = new Size(151, 29);
            cboNomeCurso.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 295);
            Controls.Add(cboNomeCurso);
            Controls.Add(btnConsultar);
            Controls.Add(cboNivel);
            Controls.Add(btnCadastro);
            Controls.Add(label4);
            Controls.Add(txtPeriodo);
            Controls.Add(label3);
            Controls.Add(txtSigla);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "---- DADOS CURSO ----";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastro;
        private ComboBox cboNivel;
        private Button btnConsultar;
        private ComboBox cboNomeCurso;
    }
}
