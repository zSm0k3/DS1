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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            labelSalario = new Label();
            labelCargo = new Label();
            labelNovoSalario = new Label();
            textBoxSalario = new TextBox();
            textBoxNovoSalario = new TextBox();
            comboBoxCargo = new ComboBox();
            buttonNovo = new Button();
            buttonSair = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Font = new Font("Segoe UI", 14F);
            labelSalario.Location = new Point(48, 48);
            labelSalario.Margin = new Padding(2, 0, 2, 0);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(74, 25);
            labelSalario.TabIndex = 0;
            labelSalario.Text = "Salário:";
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Font = new Font("Segoe UI", 14F);
            labelCargo.Location = new Point(48, 104);
            labelCargo.Margin = new Padding(2, 0, 2, 0);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(67, 25);
            labelCargo.TabIndex = 1;
            labelCargo.Text = "Cargo:";
            // 
            // labelNovoSalario
            // 
            labelNovoSalario.AutoSize = true;
            labelNovoSalario.Font = new Font("Segoe UI", 14F);
            labelNovoSalario.Location = new Point(48, 161);
            labelNovoSalario.Margin = new Padding(2, 0, 2, 0);
            labelNovoSalario.Name = "labelNovoSalario";
            labelNovoSalario.Size = new Size(120, 25);
            labelNovoSalario.TabIndex = 2;
            labelNovoSalario.Text = "Novo Salário";
            // 
            // textBoxSalario
            // 
            textBoxSalario.Font = new Font("Segoe UI", 12F);
            textBoxSalario.Location = new Point(199, 44);
            textBoxSalario.Margin = new Padding(2);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(154, 29);
            textBoxSalario.TabIndex = 3;
            // 
            // textBoxNovoSalario
            // 
            textBoxNovoSalario.Font = new Font("Segoe UI", 12F);
            textBoxNovoSalario.Location = new Point(199, 157);
            textBoxNovoSalario.Margin = new Padding(2);
            textBoxNovoSalario.Name = "textBoxNovoSalario";
            textBoxNovoSalario.Size = new Size(154, 29);
            textBoxNovoSalario.TabIndex = 4;
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.Font = new Font("Segoe UI", 12F);
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Items.AddRange(new object[] { "Selecione", "Estagiário", "Dev. Júnior", "Dev. Pleno", "Analista Qualidade" });
            comboBoxCargo.Location = new Point(199, 100);
            comboBoxCargo.Margin = new Padding(2);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(154, 29);
            comboBoxCargo.TabIndex = 5;
            comboBoxCargo.SelectedIndexChanged += comboBoxCargo_SelectedIndexChanged;
            // 
            // buttonNovo
            // 
            buttonNovo.BackColor = SystemColors.ActiveCaption;
            buttonNovo.FlatStyle = FlatStyle.Popup;
            buttonNovo.Font = new Font("Segoe UI", 14F);
            buttonNovo.Location = new Point(71, 216);
            buttonNovo.Margin = new Padding(2);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(111, 39);
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
            buttonSair.Location = new Point(214, 216);
            buttonSair.Margin = new Padding(2);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(111, 39);
            buttonSair.TabIndex = 7;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 7F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(379, 262);
            button2.Name = "button2";
            button2.Size = new Size(44, 46);
            button2.TabIndex = 9;
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(425, 310);
            Controls.Add(button2);
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
            Margin = new Padding(2);
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
        private Button button2;
    }
}