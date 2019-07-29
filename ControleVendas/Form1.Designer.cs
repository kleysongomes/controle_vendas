namespace ControleVendas
{
    partial class frmInicial
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
            this.SuspendLayout();
            // 
            // lblCabeçalho
            // 
            this.lblCabeçalho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCabeçalho.Font = new System.Drawing.Font("Miriam Mono CLM", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCabeçalho.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCabeçalho.Location = new System.Drawing.Point(12, 12);
            this.lblCabeçalho.Name = "lblCabeçalho";
            this.lblCabeçalho.Size = new System.Drawing.Size(252, 82);
            this.lblCabeçalho.TabIndex = 0;
            this.lblCabeçalho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIDVendedor
            // 
            this.txtIDVendedor.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtIDVendedor.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtIDVendedor.Location = new System.Drawing.Point(389, 18);
            this.txtIDVendedor.Name = "txtIDVendedor";
            this.txtIDVendedor.Size = new System.Drawing.Size(50, 27);
            this.txtIDVendedor.TabIndex = 2;
            this.txtIDVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIDVendedor
            // 
            this.lblIDVendedor.AutoSize = true;
            this.lblIDVendedor.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblIDVendedor.Location = new System.Drawing.Point(270, 24);
            this.lblIDVendedor.Name = "lblIDVendedor";
            this.lblIDVendedor.Size = new System.Drawing.Size(118, 18);
            this.lblIDVendedor.TabIndex = 3;
            this.lblIDVendedor.Text = "ID VENDEDOR";
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNomeVendedor.Location = new System.Drawing.Point(443, 24);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(48, 18);
            this.lblNomeVendedor.TabIndex = 4;
            this.lblNomeVendedor.Text = "NOME";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNomeVendedor.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNomeVendedor.Location = new System.Drawing.Point(504, 21);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNomeVendedor.Size = new System.Drawing.Size(284, 27);
            this.txtNomeVendedor.TabIndex = 5;
            this.txtNomeVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumeroVenda
            // 
            this.txtNumeroVenda.Enabled = false;
            this.txtNumeroVenda.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumeroVenda.Location = new System.Drawing.Point(434, 55);
            this.txtNumeroVenda.Name = "txtNumeroVenda";
            this.txtNumeroVenda.Size = new System.Drawing.Size(354, 27);
            this.txtNumeroVenda.TabIndex = 6;
            this.txtNumeroVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumeroVenda
            // 
            this.lblNumeroVenda.AutoSize = true;
            this.lblNumeroVenda.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumeroVenda.Location = new System.Drawing.Point(270, 59);
            this.lblNumeroVenda.Name = "lblNumeroVenda";
            this.lblNumeroVenda.Size = new System.Drawing.Size(158, 18);
            this.lblNumeroVenda.TabIndex = 7;
            this.lblNumeroVenda.Text = "NÚMERO DA VENDA";
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.Silver;
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador.ForeColor = System.Drawing.Color.Transparent;
            this.lblSeparador.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSeparador.Location = new System.Drawing.Point(18, 101);
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
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 81);
            this.label1.TabIndex = 9;
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vendas | Versão 0.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCabeçalho;
        private System.Windows.Forms.TextBox txtIDVendedor;
        private System.Windows.Forms.Label lblIDVendedor;
        private System.Windows.Forms.Label lblNomeVendedor;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.TextBox txtNumeroVenda;
        private System.Windows.Forms.Label lblNumeroVenda;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label label1;
    }
}

