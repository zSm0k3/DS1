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
            splitContainer1.Margin = new Padding(2);
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
            splitContainer1.Size = new Size(561, 270);
            splitContainer1.SplitterDistance = 110;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // picturePagto
            // 
            picturePagto.Location = new Point(13, 110);
            picturePagto.Margin = new Padding(2);
            picturePagto.Name = "picturePagto";
            picturePagto.Size = new Size(80, 62);
            picturePagto.SizeMode = PictureBoxSizeMode.Zoom;
            picturePagto.TabIndex = 4;
            picturePagto.TabStop = false;
            // 
            // pictureCarrinho
            // 
            pictureCarrinho.Image = Properties.Resources.carrinho;
            pictureCarrinho.Location = new Point(9, 13);
            pictureCarrinho.Margin = new Padding(2);
            pictureCarrinho.Name = "pictureCarrinho";
            pictureCarrinho.Size = new Size(80, 62);
            pictureCarrinho.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCarrinho.TabIndex = 3;
            pictureCarrinho.TabStop = false;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 12F);
            txtPreco.Location = new Point(210, 85);
            txtPreco.Margin = new Padding(2);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(129, 29);
            txtPreco.TabIndex = 5;
            // 
            // txtQtde
            // 
            txtQtde.Font = new Font("Segoe UI", 12F);
            txtQtde.Location = new Point(210, 47);
            txtQtde.Margin = new Padding(2);
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(129, 29);
            txtQtde.TabIndex = 4;
            // 
            // cboPagto
            // 
            cboPagto.Font = new Font("Segoe UI", 12F);
            cboPagto.FormattingEnabled = true;
            cboPagto.Items.AddRange(new object[] { "Selecione", "Crédito(2x)", "Débito", "Dinheiro", "Pix" });
            cboPagto.Location = new Point(210, 119);
            cboPagto.Margin = new Padding(2);
            cboPagto.Name = "cboPagto";
            cboPagto.Size = new Size(129, 29);
            cboPagto.TabIndex = 3;
            cboPagto.SelectedIndexChanged += cboPagto_SelectedIndexChanged;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 12F);
            lblPreco.Location = new Point(127, 86);
            lblPreco.Margin = new Padding(2, 0, 2, 0);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(52, 21);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço:";
            // 
            // lblPagto
            // 
            lblPagto.AutoSize = true;
            lblPagto.Font = new Font("Segoe UI", 12F);
            lblPagto.Location = new Point(89, 121);
            lblPagto.Margin = new Padding(2, 0, 2, 0);
            lblPagto.Name = "lblPagto";
            lblPagto.Size = new Size(86, 21);
            lblPagto.TabIndex = 1;
            lblPagto.Text = "Tipo Pagto:";
            // 
            // lblQtde
            // 
            lblQtde.AutoSize = true;
            lblQtde.Font = new Font("Segoe UI", 12F);
            lblQtde.Location = new Point(89, 49);
            lblQtde.Margin = new Padding(2, 0, 2, 0);
            lblQtde.Name = "lblQtde";
            lblQtde.Size = new Size(94, 21);
            lblQtde.TabIndex = 0;
            lblQtde.Text = "Quantidade:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(-5, 230);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 40);
            panel1.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.BackgroundImage = Properties.Resources.editar;
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditar.Location = new Point(61, 10);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(25, 23);
            btnEditar.TabIndex = 7;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(295, 11);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 21);
            lblTotal.TabIndex = 5;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Brown;
            btnFechar.BackgroundImage = Properties.Resources.fechar;
            btnFechar.BackgroundImageLayout = ImageLayout.Zoom;
            btnFechar.Location = new Point(26, 10);
            btnFechar.Margin = new Padding(2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(25, 23);
            btnFechar.TabIndex = 6;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 270);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
