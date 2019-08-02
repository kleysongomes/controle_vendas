namespace ControleVendas
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblCupom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCupom
            // 
            this.lblCupom.Location = new System.Drawing.Point(0, 0);
            this.lblCupom.Name = "lblCupom";
            this.lblCupom.Size = new System.Drawing.Size(387, 525);
            this.lblCupom.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(384, 521);
            this.Controls.Add(this.lblCupom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "SisCON - Controle de Vendas - Beta.Teste";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblCupom;
    }
}