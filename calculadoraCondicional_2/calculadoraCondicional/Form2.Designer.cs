namespace calculadoraCondicional
{
    partial class Form2
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
            labelSalario = new Label();
            labelCargo = new Label();
            labelNovoSalario = new Label();
            textBoxSalario = new TextBox();
            textBoxNovoSalario = new TextBox();
            comboBoxCargo = new ComboBox();
            buttonNovo = new Button();
            buttonSair = new Button();
            SuspendLayout();
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Font = new Font("Segoe UI", 13F);
            labelSalario.Location = new Point(68, 73);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(97, 36);
            labelSalario.TabIndex = 0;
            labelSalario.Text = "Salário:";
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Font = new Font("Segoe UI", 13F);
            labelCargo.Location = new Point(68, 120);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(89, 36);
            labelCargo.TabIndex = 1;
            labelCargo.Text = "Cargo:";
            // 
            // labelNovoSalario
            // 
            labelNovoSalario.AutoSize = true;
            labelNovoSalario.Font = new Font("Segoe UI", 13F);
            labelNovoSalario.Location = new Point(68, 166);
            labelNovoSalario.Name = "labelNovoSalario";
            labelNovoSalario.Size = new Size(159, 36);
            labelNovoSalario.TabIndex = 2;
            labelNovoSalario.Text = "Novo Salário";
            // 
            // textBoxSalario
            // 
            textBoxSalario.Font = new Font("Segoe UI", 12F);
            textBoxSalario.Location = new Point(265, 73);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(182, 39);
            textBoxSalario.TabIndex = 3;
            // 
            // textBoxNovoSalario
            // 
            textBoxNovoSalario.Font = new Font("Segoe UI", 12F);
            textBoxNovoSalario.Location = new Point(265, 166);
            textBoxNovoSalario.Name = "textBoxNovoSalario";
            textBoxNovoSalario.Size = new Size(182, 39);
            textBoxNovoSalario.TabIndex = 4;
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.Font = new Font("Segoe UI", 12F);
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Items.AddRange(new object[] { "Selecione", "Estagiário", "Dev. Júnior", "Dev. Pleno", "Analista Qualidade" });
            comboBoxCargo.Location = new Point(265, 120);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(182, 40);
            comboBoxCargo.TabIndex = 5;
            comboBoxCargo.SelectedIndexChanged += comboBoxCargo_SelectedIndexChanged;
            // 
            // buttonNovo
            // 
            buttonNovo.BackColor = SystemColors.ActiveCaption;
            buttonNovo.FlatStyle = FlatStyle.Popup;
            buttonNovo.Font = new Font("Segoe UI", 14F);
            buttonNovo.Location = new Point(102, 259);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(134, 45);
            buttonNovo.TabIndex = 6;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = false;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = SystemColors.ActiveCaption;
            buttonSair.FlatStyle = FlatStyle.Popup;
            buttonSair.Font = new Font("Segoe UI", 14F);
            buttonSair.ForeColor = SystemColors.ActiveCaptionText;
            buttonSair.Location = new Point(265, 259);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(134, 45);
            buttonSair.TabIndex = 7;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(526, 368);
            Controls.Add(buttonSair);
            Controls.Add(buttonNovo);
            Controls.Add(comboBoxCargo);
            Controls.Add(textBoxNovoSalario);
            Controls.Add(textBoxSalario);
            Controls.Add(labelNovoSalario);
            Controls.Add(labelCargo);
            Controls.Add(labelSalario);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSalario;
        private Label labelCargo;
        private Label labelNovoSalario;
        private TextBox textBoxSalario;
        private TextBox textBoxNovoSalario;
        private ComboBox comboBoxCargo;
        private Button buttonNovo;
        private Button buttonSair;
    }
}