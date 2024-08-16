namespace CalcVendas
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
            picturePagto = new PictureBox();
            pictureCarrinho = new PictureBox();
            txtPreco = new TextBox();
            txtQtde = new TextBox();
            cboPagto = new ComboBox();
            lblPreco = new Label();
            lblPagto = new Label();
            lblQtde = new Label();
            panel1 = new Panel();
            btnEditar = new Button();
            lblTotal = new Label();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePagto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCarrinho).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.CausesValidation = false;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LightGray;
            splitContainer1.Panel1.Controls.Add(picturePagto);
            splitContainer1.Panel1.Controls.Add(pictureCarrinho);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtPreco);
            splitContainer1.Panel2.Controls.Add(txtQtde);
            splitContainer1.Panel2.Controls.Add(cboPagto);
            splitContainer1.Panel2.Controls.Add(lblPreco);
            splitContainer1.Panel2.Controls.Add(lblPagto);
            splitContainer1.Panel2.Controls.Add(lblQtde);
            splitContainer1.Size = new Size(801, 450);
            splitContainer1.SplitterDistance = 158;
            splitContainer1.TabIndex = 0;
            // 
            // picturePagto
            // 
            picturePagto.Location = new Point(19, 184);
            picturePagto.Name = "picturePagto";
            picturePagto.Size = new Size(115, 104);
            picturePagto.SizeMode = PictureBoxSizeMode.Zoom;
            picturePagto.TabIndex = 4;
            picturePagto.TabStop = false;
            // 
            // pictureCarrinho
            // 
            pictureCarrinho.Image = Properties.Resources.carrinho;
            pictureCarrinho.Location = new Point(19, 21);
            pictureCarrinho.Name = "pictureCarrinho";
            pictureCarrinho.Size = new Size(115, 104);
            pictureCarrinho.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCarrinho.TabIndex = 3;
            pictureCarrinho.TabStop = false;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 12F);
            txtPreco.Location = new Point(300, 141);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(182, 39);
            txtPreco.TabIndex = 5;
            // 
            // txtQtde
            // 
            txtQtde.Font = new Font("Segoe UI", 12F);
            txtQtde.Location = new Point(300, 78);
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(182, 39);
            txtQtde.TabIndex = 4;
            // 
            // cboPagto
            // 
            cboPagto.Font = new Font("Segoe UI", 12F);
            cboPagto.FormattingEnabled = true;
            cboPagto.Items.AddRange(new object[] { "Selecione", "Crédito(2x)", "Débito", "Dinheiro", "Pix" });
            cboPagto.Location = new Point(300, 199);
            cboPagto.Name = "cboPagto";
            cboPagto.Size = new Size(182, 40);
            cboPagto.TabIndex = 3;
            cboPagto.SelectedIndexChanged += cboPagto_SelectedIndexChanged;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 12F);
            lblPreco.Location = new Point(182, 144);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(78, 32);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço:";
            // 
            // lblPagto
            // 
            lblPagto.AutoSize = true;
            lblPagto.Font = new Font("Segoe UI", 12F);
            lblPagto.Location = new Point(127, 202);
            lblPagto.Name = "lblPagto";
            lblPagto.Size = new Size(133, 32);
            lblPagto.TabIndex = 1;
            lblPagto.Text = "Tipo Pagto:";
            // 
            // lblQtde
            // 
            lblQtde.AutoSize = true;
            lblQtde.Font = new Font("Segoe UI", 12F);
            lblQtde.Location = new Point(127, 81);
            lblQtde.Name = "lblQtde";
            lblQtde.Size = new Size(144, 32);
            lblQtde.TabIndex = 0;
            lblQtde.Text = "Quantidade:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(-7, 384);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 67);
            panel1.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.BackgroundImage = Properties.Resources.editar;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(94, 18);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(32, 32);
            btnEditar.TabIndex = 7;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(430, 18);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 32);
            lblTotal.TabIndex = 5;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Brown;
            btnFechar.BackgroundImage = Properties.Resources.fechar;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(37, 18);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(31, 32);
            btnFechar.TabIndex = 6;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":. Vendas .:";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturePagto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCarrinho).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private PictureBox pictureCarrinho;
        private Label lblPreco;
        private Label lblPagto;
        private Label lblQtde;
        private ComboBox cboPagto;
        private TextBox txtPreco;
        private TextBox txtQtde;
        private PictureBox picturePagto;
        private Label lblTotal;
        private Button btnEditar;
        private Button btnFechar;
    }
}
