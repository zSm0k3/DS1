namespace Medidas
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
            splitContainer1 = new SplitContainer();
            txtMedidaCnvtda = new TextBox();
            txtMedida = new TextBox();
            cboPara = new ComboBox();
            cboDe = new ComboBox();
            lblPara = new Label();
            lblMedidaConvertida = new Label();
            lblDe = new Label();
            lblMedida = new Label();
            lblTitulo = new Label();
            btnSair = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Silver;
            splitContainer1.Panel1.Controls.Add(txtMedidaCnvtda);
            splitContainer1.Panel1.Controls.Add(txtMedida);
            splitContainer1.Panel1.Controls.Add(cboPara);
            splitContainer1.Panel1.Controls.Add(cboDe);
            splitContainer1.Panel1.Controls.Add(lblPara);
            splitContainer1.Panel1.Controls.Add(lblMedidaConvertida);
            splitContainer1.Panel1.Controls.Add(lblDe);
            splitContainer1.Panel1.Controls.Add(lblMedida);
            splitContainer1.Panel1.Controls.Add(lblTitulo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(64, 64, 64);
            splitContainer1.Panel2.Controls.Add(btnSair);
            splitContainer1.Panel2.Controls.Add(btnEditar);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 358;
            splitContainer1.TabIndex = 0;
            // 
            // txtMedidaCnvtda
            // 
            txtMedidaCnvtda.Font = new Font("Segoe UI", 10F);
            txtMedidaCnvtda.Location = new Point(517, 252);
            txtMedidaCnvtda.Name = "txtMedidaCnvtda";
            txtMedidaCnvtda.Size = new Size(150, 34);
            txtMedidaCnvtda.TabIndex = 8;
            // 
            // txtMedida
            // 
            txtMedida.Font = new Font("Segoe UI", 10F);
            txtMedida.Location = new Point(277, 154);
            txtMedida.Name = "txtMedida";
            txtMedida.Size = new Size(141, 34);
            txtMedida.TabIndex = 7;
            // 
            // cboPara
            // 
            cboPara.Font = new Font("Segoe UI", 10F);
            cboPara.FormattingEnabled = true;
            cboPara.Items.AddRange(new object[] { "cm", "m", "Km" });
            cboPara.Location = new Point(173, 252);
            cboPara.Name = "cboPara";
            cboPara.Size = new Size(106, 36);
            cboPara.TabIndex = 6;
            cboPara.SelectedIndexChanged += cboPara_SelectedIndexChanged;
            // 
            // cboDe
            // 
            cboDe.Font = new Font("Segoe UI", 10F);
            cboDe.FormattingEnabled = true;
            cboDe.Items.AddRange(new object[] { "cm", "m", "Km" });
            cboDe.Location = new Point(517, 155);
            cboDe.Name = "cboDe";
            cboDe.Size = new Size(106, 36);
            cboDe.TabIndex = 5;
            // 
            // lblPara
            // 
            lblPara.AutoSize = true;
            lblPara.Font = new Font("Segoe UI", 13F);
            lblPara.Location = new Point(97, 252);
            lblPara.Name = "lblPara";
            lblPara.Size = new Size(70, 36);
            lblPara.TabIndex = 4;
            lblPara.Text = "Para:";
            // 
            // lblMedidaConvertida
            // 
            lblMedidaConvertida.AutoSize = true;
            lblMedidaConvertida.Font = new Font("Segoe UI", 13F);
            lblMedidaConvertida.Location = new Point(302, 252);
            lblMedidaConvertida.Name = "lblMedidaConvertida";
            lblMedidaConvertida.Size = new Size(209, 36);
            lblMedidaConvertida.TabIndex = 3;
            lblMedidaConvertida.Text = "Medida Convtda:";
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Font = new Font("Segoe UI", 13F);
            lblDe.Location = new Point(458, 152);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(53, 36);
            lblDe.TabIndex = 2;
            lblDe.Text = "De:";
            // 
            // lblMedida
            // 
            lblMedida.AutoSize = true;
            lblMedida.Font = new Font("Segoe UI", 13F);
            lblMedida.Location = new Point(164, 152);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new Size(107, 36);
            lblMedida.TabIndex = 1;
            lblMedida.Text = "Medida:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 19F);
            lblTitulo.Location = new Point(173, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(448, 51);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = ":. Conversor de Medidas .:";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.BackgroundImage = Properties.Resources.Delete;
            btnSair.BackgroundImageLayout = ImageLayout.Zoom;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSair.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Location = new Point(64, 19);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(62, 48);
            btnSair.TabIndex = 2;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BackgroundImage = Properties.Resources.Edit_page;
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(132, 19);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 48);
            btnEditar.TabIndex = 0;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":. Conversor de Medidas .:";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblMedida;
        private Label lblTitulo;
        private Label lblPara;
        private Label lblMedidaConvertida;
        private Label lblDe;
        private TextBox txtMedidaCnvtda;
        private TextBox txtMedida;
        private ComboBox cboPara;
        private ComboBox cboDe;
        private Button btnEditar;
        private Button btnSair;
    }
}
