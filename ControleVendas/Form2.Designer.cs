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
            this.btnEnviarItem = new System.Windows.Forms.Button();
            this.txtQuatidade = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxProdutos.Font = new System.Drawing.Font("Miriam Mono CLM", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.ItemHeight = 14;
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
            this.lbxProdutos.Location = new System.Drawing.Point(8, 65);
            this.lbxProdutos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(496, 298);
            this.lbxProdutos.TabIndex = 0;
            // 
            // btnEnviarItem
            // 
            this.btnEnviarItem.Location = new System.Drawing.Point(607, 340);
            this.btnEnviarItem.Name = "btnEnviarItem";
            this.btnEnviarItem.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarItem.TabIndex = 1;
            this.btnEnviarItem.Text = "Enviar Item";
            this.btnEnviarItem.UseVisualStyleBackColor = true;
            this.btnEnviarItem.Click += new System.EventHandler(this.BtnEnviarItem_Click);
            // 
            // txtQuatidade
            // 
            this.txtQuatidade.Location = new System.Drawing.Point(582, 314);
            this.txtQuatidade.Name = "txtQuatidade";
            this.txtQuatidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuatidade.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(582, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 389);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtQuatidade);
            this.Controls.Add(this.btnEnviarItem);
            this.Controls.Add(this.lbxProdutos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbxProdutos;
        private System.Windows.Forms.Button btnEnviarItem;
        private System.Windows.Forms.TextBox txtQuatidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}