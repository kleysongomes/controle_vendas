namespace ControleVendas
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
            this.lbxProdutos = new System.Windows.Forms.ListBox();
            this.btnEnviarItem = new System.Windows.Forms.Button();
            this.txtQuantidade2 = new System.Windows.Forms.TextBox();
            this.lblSubTotal1 = new System.Windows.Forms.Label();
            this.lblQtdEstoque = new System.Windows.Forms.Label();
            this.txtQtdEstoque = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblCabeçalho2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxProdutos.Font = new System.Drawing.Font("Miriam Mono CLM", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.ItemHeight = 14;
            this.lbxProdutos.Location = new System.Drawing.Point(8, 140);
            this.lbxProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(496, 270);
            this.lbxProdutos.TabIndex = 0;
            this.lbxProdutos.SelectedIndexChanged += new System.EventHandler(this.LbxProdutos_SelectedIndexChanged);
            // 
            // btnEnviarItem
            // 
            this.btnEnviarItem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEnviarItem.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnEnviarItem.ForeColor = System.Drawing.Color.White;
            this.btnEnviarItem.Location = new System.Drawing.Point(531, 357);
            this.btnEnviarItem.Name = "btnEnviarItem";
            this.btnEnviarItem.Size = new System.Drawing.Size(151, 33);
            this.btnEnviarItem.TabIndex = 1;
            this.btnEnviarItem.Text = "ADICIONAR ITEM";
            this.btnEnviarItem.UseVisualStyleBackColor = false;
            this.btnEnviarItem.Click += new System.EventHandler(this.BtnEnviarItem_Click);
            // 
            // txtQuantidade2
            // 
            this.txtQuantidade2.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtQuantidade2.Location = new System.Drawing.Point(617, 331);
            this.txtQuantidade2.MaxLength = 50;
            this.txtQuantidade2.Name = "txtQuantidade2";
            this.txtQuantidade2.Size = new System.Drawing.Size(62, 23);
            this.txtQuantidade2.TabIndex = 2;
            // 
            // lblSubTotal1
            // 
            this.lblSubTotal1.AutoSize = true;
            this.lblSubTotal1.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSubTotal1.Location = new System.Drawing.Point(532, 334);
            this.lblSubTotal1.Name = "lblSubTotal1";
            this.lblSubTotal1.Size = new System.Drawing.Size(71, 14);
            this.lblSubTotal1.TabIndex = 26;
            this.lblSubTotal1.Text = "UNIDADES";
            // 
            // lblQtdEstoque
            // 
            this.lblQtdEstoque.AutoSize = true;
            this.lblQtdEstoque.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblQtdEstoque.Location = new System.Drawing.Point(523, 143);
            this.lblQtdEstoque.Name = "lblQtdEstoque";
            this.lblQtdEstoque.Size = new System.Drawing.Size(95, 14);
            this.lblQtdEstoque.TabIndex = 28;
            this.lblQtdEstoque.Text = "QTD ESTOQUE";
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtQtdEstoque.Location = new System.Drawing.Point(625, 140);
            this.txtQtdEstoque.MaxLength = 50;
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Size = new System.Drawing.Size(62, 23);
            this.txtQtdEstoque.TabIndex = 27;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblValor2.Location = new System.Drawing.Point(524, 180);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(87, 14);
            this.lblValor2.TabIndex = 30;
            this.lblValor2.Text = "VALOR (R$)";
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtValor2.Location = new System.Drawing.Point(625, 177);
            this.txtValor2.MaxLength = 50;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(62, 23);
            this.txtValor2.TabIndex = 29;
            // 
            // lblCabeçalho2
            // 
            this.lblCabeçalho2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCabeçalho2.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCabeçalho2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCabeçalho2.Location = new System.Drawing.Point(12, 9);
            this.lblCabeçalho2.Name = "lblCabeçalho2";
            this.lblCabeçalho2.Size = new System.Drawing.Size(252, 121);
            this.lblCabeçalho2.TabIndex = 31;
            this.lblCabeçalho2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(287, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 81);
            this.label1.TabIndex = 33;
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.Silver;
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador.ForeColor = System.Drawing.Color.Transparent;
            this.lblSeparador.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSeparador.Location = new System.Drawing.Point(8, 130);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(680, 2);
            this.lblSeparador.TabIndex = 32;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.lblCabeçalho2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblQtdEstoque);
            this.Controls.Add(this.txtQtdEstoque);
            this.Controls.Add(this.lblSubTotal1);
            this.Controls.Add(this.txtQuantidade2);
            this.Controls.Add(this.btnEnviarItem);
            this.Controls.Add(this.lbxProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "SisCON - Controle de Vendas - Beta.Teste";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbxProdutos;
        private System.Windows.Forms.Button btnEnviarItem;
        private System.Windows.Forms.TextBox txtQuantidade2;
        private System.Windows.Forms.Label lblSubTotal1;
        private System.Windows.Forms.Label lblQtdEstoque;
        private System.Windows.Forms.TextBox txtQtdEstoque;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblCabeçalho2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeparador;
    }
}