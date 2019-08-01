namespace ControleVendas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCabeçalho = new System.Windows.Forms.Label();
            this.txtIDVendedor = new System.Windows.Forms.TextBox();
            this.lblIDVendedor = new System.Windows.Forms.Label();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtNumeroVenda = new System.Windows.Forms.TextBox();
            this.lblNumeroVenda = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxCompra = new System.Windows.Forms.ListBox();
            this.btnAdcionarProduto = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.lblFormadePagto = new System.Windows.Forms.Label();
            this.cbxFormadePagto = new System.Windows.Forms.ComboBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.txtFrete1 = new System.Windows.Forms.TextBox();
            this.lblFrete1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGerarVenda = new System.Windows.Forms.Button();
            this.btnCalcularFrete = new System.Windows.Forms.Button();
            this.lblSubTotal1 = new System.Windows.Forms.Label();
            this.txtSubTotal1 = new System.Windows.Forms.TextBox();
            this.lbxValor1 = new System.Windows.Forms.ListBox();
            this.lbxQuantidade1 = new System.Windows.Forms.ListBox();
            this.lblQuantidade1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCabeçalho
            // 
            this.lblCabeçalho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCabeçalho.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCabeçalho.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCabeçalho.Location = new System.Drawing.Point(12, 12);
            this.lblCabeçalho.Name = "lblCabeçalho";
            this.lblCabeçalho.Size = new System.Drawing.Size(252, 82);
            this.lblCabeçalho.TabIndex = 0;
            this.lblCabeçalho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIDVendedor
            // 
            this.txtIDVendedor.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtIDVendedor.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtIDVendedor.Location = new System.Drawing.Point(371, 21);
            this.txtIDVendedor.MaxLength = 3;
            this.txtIDVendedor.Name = "txtIDVendedor";
            this.txtIDVendedor.Size = new System.Drawing.Size(50, 23);
            this.txtIDVendedor.TabIndex = 2;
            this.txtIDVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIDVendedor
            // 
            this.lblIDVendedor.AutoSize = true;
            this.lblIDVendedor.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblIDVendedor.Location = new System.Drawing.Point(270, 24);
            this.lblIDVendedor.Name = "lblIDVendedor";
            this.lblIDVendedor.Size = new System.Drawing.Size(95, 14);
            this.lblIDVendedor.TabIndex = 3;
            this.lblIDVendedor.Text = "ID VENDEDOR";
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNomeVendedor.Location = new System.Drawing.Point(434, 24);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(39, 14);
            this.lblNomeVendedor.TabIndex = 4;
            this.lblNomeVendedor.Text = "NOME";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNomeVendedor.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNomeVendedor.Location = new System.Drawing.Point(488, 21);
            this.txtNomeVendedor.MaxLength = 50;
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNomeVendedor.Size = new System.Drawing.Size(300, 23);
            this.txtNomeVendedor.TabIndex = 5;
            this.txtNomeVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumeroVenda
            // 
            this.txtNumeroVenda.Enabled = false;
            this.txtNumeroVenda.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumeroVenda.Location = new System.Drawing.Point(434, 55);
            this.txtNumeroVenda.Name = "txtNumeroVenda";
            this.txtNumeroVenda.Size = new System.Drawing.Size(354, 23);
            this.txtNumeroVenda.TabIndex = 6;
            this.txtNumeroVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumeroVenda
            // 
            this.lblNumeroVenda.AutoSize = true;
            this.lblNumeroVenda.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumeroVenda.Location = new System.Drawing.Point(270, 59);
            this.lblNumeroVenda.Name = "lblNumeroVenda";
            this.lblNumeroVenda.Size = new System.Drawing.Size(127, 14);
            this.lblNumeroVenda.TabIndex = 7;
            this.lblNumeroVenda.Text = "NÚMERO DA VENDA";
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.Silver;
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador.ForeColor = System.Drawing.Color.Transparent;
            this.lblSeparador.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSeparador.Location = new System.Drawing.Point(18, 115);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(764, 2);
            this.lblSeparador.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(265, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 81);
            this.label1.TabIndex = 9;
            // 
            // lbxCompra
            // 
            this.lbxCompra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxCompra.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbxCompra.FormattingEnabled = true;
            this.lbxCompra.ItemHeight = 14;
            this.lbxCompra.Location = new System.Drawing.Point(12, 145);
            this.lbxCompra.Name = "lbxCompra";
            this.lbxCompra.Size = new System.Drawing.Size(455, 256);
            this.lbxCompra.TabIndex = 10;
            // 
            // btnAdcionarProduto
            // 
            this.btnAdcionarProduto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdcionarProduto.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdcionarProduto.ForeColor = System.Drawing.Color.White;
            this.btnAdcionarProduto.Location = new System.Drawing.Point(12, 407);
            this.btnAdcionarProduto.Name = "btnAdcionarProduto";
            this.btnAdcionarProduto.Size = new System.Drawing.Size(170, 31);
            this.btnAdcionarProduto.TabIndex = 11;
            this.btnAdcionarProduto.Text = "ADICIONAR PRODUTO";
            this.btnAdcionarProduto.UseVisualStyleBackColor = false;
            this.btnAdcionarProduto.Click += new System.EventHandler(this.BtnAdcionarProduto_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoverProduto.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRemoverProduto.ForeColor = System.Drawing.Color.White;
            this.btnRemoverProduto.Location = new System.Drawing.Point(227, 407);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(170, 31);
            this.btnRemoverProduto.TabIndex = 12;
            this.btnRemoverProduto.Text = "REMOVER PRODUTO";
            this.btnRemoverProduto.UseVisualStyleBackColor = false;
            this.btnRemoverProduto.Click += new System.EventHandler(this.BtnRemoverProduto_Click);
            // 
            // lblFormadePagto
            // 
            this.lblFormadePagto.AutoSize = true;
            this.lblFormadePagto.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFormadePagto.Location = new System.Drawing.Point(638, 206);
            this.lblFormadePagto.Name = "lblFormadePagto";
            this.lblFormadePagto.Size = new System.Drawing.Size(151, 14);
            this.lblFormadePagto.TabIndex = 13;
            this.lblFormadePagto.Text = "FORMA DE PAGAMENTO";
            // 
            // cbxFormadePagto
            // 
            this.cbxFormadePagto.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbxFormadePagto.ForeColor = System.Drawing.Color.Green;
            this.cbxFormadePagto.FormattingEnabled = true;
            this.cbxFormadePagto.Items.AddRange(new object[] {
            "DINHEIRO",
            "CARTAO",
            "BOLETO"});
            this.cbxFormadePagto.Location = new System.Drawing.Point(641, 229);
            this.cbxFormadePagto.Name = "cbxFormadePagto";
            this.cbxFormadePagto.Size = new System.Drawing.Size(147, 22);
            this.cbxFormadePagto.TabIndex = 14;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblValor1.Location = new System.Drawing.Point(547, 124);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(87, 14);
            this.lblValor1.TabIndex = 16;
            this.lblValor1.Text = "VALOR (R$)";
            // 
            // txtFrete1
            // 
            this.txtFrete1.Enabled = false;
            this.txtFrete1.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFrete1.ForeColor = System.Drawing.Color.DarkRed;
            this.txtFrete1.Location = new System.Drawing.Point(641, 318);
            this.txtFrete1.MaxLength = 50;
            this.txtFrete1.Name = "txtFrete1";
            this.txtFrete1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFrete1.Size = new System.Drawing.Size(147, 23);
            this.txtFrete1.TabIndex = 18;
            this.txtFrete1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFrete1
            // 
            this.lblFrete1.AutoSize = true;
            this.lblFrete1.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFrete1.Location = new System.Drawing.Point(668, 301);
            this.lblFrete1.Name = "lblFrete1";
            this.lblFrete1.Size = new System.Drawing.Size(95, 14);
            this.lblFrete1.TabIndex = 19;
            this.lblFrete1.Text = "FRETE (10%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(663, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "TOTAL A PAGAR";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox2.Location = new System.Drawing.Point(641, 361);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(147, 23);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGerarVenda
            // 
            this.btnGerarVenda.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGerarVenda.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnGerarVenda.ForeColor = System.Drawing.Color.White;
            this.btnGerarVenda.Location = new System.Drawing.Point(641, 407);
            this.btnGerarVenda.Name = "btnGerarVenda";
            this.btnGerarVenda.Size = new System.Drawing.Size(153, 31);
            this.btnGerarVenda.TabIndex = 22;
            this.btnGerarVenda.Text = "GERAR VENDA";
            this.btnGerarVenda.UseVisualStyleBackColor = false;
            this.btnGerarVenda.Click += new System.EventHandler(this.BtnGerarVenda_Click);
            // 
            // btnCalcularFrete
            // 
            this.btnCalcularFrete.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCalcularFrete.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCalcularFrete.ForeColor = System.Drawing.Color.White;
            this.btnCalcularFrete.Location = new System.Drawing.Point(437, 407);
            this.btnCalcularFrete.Name = "btnCalcularFrete";
            this.btnCalcularFrete.Size = new System.Drawing.Size(170, 31);
            this.btnCalcularFrete.TabIndex = 23;
            this.btnCalcularFrete.Text = "CALCULAR FRETE";
            this.btnCalcularFrete.UseVisualStyleBackColor = false;
            this.btnCalcularFrete.Click += new System.EventHandler(this.BtnCalcularFrete_Click);
            // 
            // lblSubTotal1
            // 
            this.lblSubTotal1.AutoSize = true;
            this.lblSubTotal1.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSubTotal1.Location = new System.Drawing.Point(675, 258);
            this.lblSubTotal1.Name = "lblSubTotal1";
            this.lblSubTotal1.Size = new System.Drawing.Size(71, 14);
            this.lblSubTotal1.TabIndex = 25;
            this.lblSubTotal1.Text = "SUBTOTAL";
            // 
            // txtSubTotal1
            // 
            this.txtSubTotal1.Enabled = false;
            this.txtSubTotal1.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSubTotal1.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSubTotal1.Location = new System.Drawing.Point(641, 275);
            this.txtSubTotal1.MaxLength = 50;
            this.txtSubTotal1.Name = "txtSubTotal1";
            this.txtSubTotal1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSubTotal1.Size = new System.Drawing.Size(147, 23);
            this.txtSubTotal1.TabIndex = 24;
            this.txtSubTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbxValor1
            // 
            this.lbxValor1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxValor1.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbxValor1.FormattingEnabled = true;
            this.lbxValor1.ItemHeight = 14;
            this.lbxValor1.Location = new System.Drawing.Point(556, 145);
            this.lbxValor1.Name = "lbxValor1";
            this.lbxValor1.Size = new System.Drawing.Size(66, 256);
            this.lbxValor1.TabIndex = 26;
            // 
            // lbxQuantidade1
            // 
            this.lbxQuantidade1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxQuantidade1.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbxQuantidade1.FormattingEnabled = true;
            this.lbxQuantidade1.ItemHeight = 14;
            this.lbxQuantidade1.Location = new System.Drawing.Point(494, 145);
            this.lbxQuantidade1.Name = "lbxQuantidade1";
            this.lbxQuantidade1.Size = new System.Drawing.Size(36, 256);
            this.lbxQuantidade1.TabIndex = 27;
            // 
            // lblQuantidade1
            // 
            this.lblQuantidade1.AutoSize = true;
            this.lblQuantidade1.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblQuantidade1.Location = new System.Drawing.Point(497, 124);
            this.lblQuantidade1.Name = "lblQuantidade1";
            this.lblQuantidade1.Size = new System.Drawing.Size(31, 14);
            this.lblQuantidade1.TabIndex = 28;
            this.lblQuantidade1.Text = "QTD";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuantidade1);
            this.Controls.Add(this.lbxQuantidade1);
            this.Controls.Add(this.lbxValor1);
            this.Controls.Add(this.lblSubTotal1);
            this.Controls.Add(this.txtSubTotal1);
            this.Controls.Add(this.btnCalcularFrete);
            this.Controls.Add(this.btnGerarVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblFrete1);
            this.Controls.Add(this.txtFrete1);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.cbxFormadePagto);
            this.Controls.Add(this.lblFormadePagto);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.btnAdcionarProduto);
            this.Controls.Add(this.lbxCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.lblNumeroVenda);
            this.Controls.Add(this.txtNumeroVenda);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.lblNomeVendedor);
            this.Controls.Add(this.lblIDVendedor);
            this.Controls.Add(this.txtIDVendedor);
            this.Controls.Add(this.lblCabeçalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vendas";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIDVendedor;
        private System.Windows.Forms.Label lblIDVendedor;
        private System.Windows.Forms.Label lblNomeVendedor;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.TextBox txtNumeroVenda;
        private System.Windows.Forms.Label lblNumeroVenda;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdcionarProduto;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Label lblFormadePagto;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblFrete1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerarVenda;
        private System.Windows.Forms.Button btnCalcularFrete;
        private System.Windows.Forms.Label lblSubTotal1;
        public System.Windows.Forms.ListBox lbxCompra;
        public System.Windows.Forms.ListBox lbxValor1;
        public System.Windows.Forms.Label lblCabeçalho;
        public System.Windows.Forms.ListBox lbxQuantidade1;
        private System.Windows.Forms.Label lblQuantidade1;
        public System.Windows.Forms.ComboBox cbxFormadePagto;
        public System.Windows.Forms.TextBox txtFrete1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox txtSubTotal1;
    }
}

