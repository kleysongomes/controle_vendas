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
            this.lbxProdutos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxProdutos.Font = new System.Drawing.Font("Miriam Mono CLM", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.ItemHeight = 22;
            this.lbxProdutos.Items.AddRange(new object[] {
            "COMPUTADOR MIRANDA CELERON J3060/4GB/HD500GB/LINUX ",
            "COMPUTADOR V520S I3-7100/4GB/500GB/SEM SISTEMA ",
            "HD 1TB PORTATIL USB 3.0 EXPANSION STEA1000400 ",
            "HD 4TB PORTATIL USB 3.0 EXPANSION STEA4000400 ",
            "SSD 240GB SATA3 SA400S37 ",
            "SSD 240GB M.2 SATA WD GREEN WDS240G2G0B ",
            "PEN DRIVE 8GB USB 2.0 MINI PRETO PD770 ",
            "PEN DRIVE 32GB USB 2.0 TWIST 2 PD589 ",
            "PEN DRIVE 64GB USB 2.0 CRUZER BLADE ",
            "SOFTWARE WINDOWS 10 HOME 64BITS (OEM) ",
            "SOFTWARE WINDOWS 10 PRO 64BITS (OEM) ",
            "SOFTWARE WINDOWS SERVER 2016 ESSENTIALS 64BITS - G35-01040 ",
            "BASE P/ NOTEBOOK C/COOLER AC166 ",
            "HUB 4PT USB 2.0 AC042 ",
            "LEITOR CARTÃO MEMORIA USB 9207 ",
            "MOUSE PAD CORES VARIADAS AC066 ",
            "CASE P/ HD 3,5\" EXTERNO SATA USB C/VENT.PTO GA119 ",
            "CASE P/ HD 2,5\" EXTERNO SATA USB AZUL GA117 ",
            "BASE P/ NOTEBOOK C/ VENTILADOR LED ",
            "MULTIPLICADOR HDMI 4 PORTAS 9286 ",
            "DOCKING STATION PARA HD 2,5\'\'/3,5\" SATA GA125 ",
            "MOUSE PAD CRIATIVO YOUR FATHER ",
            "MOUSE PAD APOIO P/PULSO GEL PTO 6013428 "});
            this.lbxProdutos.Location = new System.Drawing.Point(12, 100);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(742, 466);
            this.lbxProdutos.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1041, 598);
            this.Controls.Add(this.lbxProdutos);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProdutos;
    }
}