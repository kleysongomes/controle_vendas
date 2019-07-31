using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas 
{
    public partial class Form2 : Form
    {
        frmPrincipal frm1;
        double dblSubtotal1;
        string[] ArrayItem = 
            {
                "COMPUTADOR MIRANDA CELERON J3060/4GB/HD500GB/LINUX",
                "COMPUTADOR V520S I3-7100/4GB/500GB/SEM SISTEMA",
                "HD 1TB PORTATIL USB 3.0 EXPANSION STEA1000400",
                "HD 4TB PORTATIL USB 3.0 EXPANSION STEA4000400",
                "SSD 240GB SATA3 SA400S37",
                "SSD 240GB M.2 SATA WD GREEN WDS240G2G0B",
                "PEN DRIVE 8GB USB 2.0 MINI PRETO PD770",
                "PEN DRIVE 32GB USB 2.0 TWIST 2 PD589",
                "PEN DRIVE 64GB USB 2.0 CRUZER BLADE",
                "SOFTWARE WINDOWS 10 HOME 64BITS (OEM)",
                "SOFTWARE WINDOWS 10 PRO 64BITS (OEM)",
                "SOFTWARE WINDOWS SERVER 2016 ESSENTIALS 64BITS - G35-01040",
                "BASE P/ NOTEBOOK C/COOLER AC166",
                "HUB 4PT USB 2.0 AC042",
                "LEITOR CARTÃO MEMORIA USB 9207",
                "MOUSE PAD CORES VARIADAS AC066",
                "CASE P/ HD 3,5 EXTERNO SATA USB C/VENT.PTO GA119", 
                "CASE P/ HD 2,5 EXTERNO SATA USB AZUL GA117", 
                "BASE P/ NOTEBOOK C/ VENTILADOR LED",
                "MULTIPLICADOR HDMI 4 PORTAS 9286",
                "DOCKING STATION PARA HD 2,5''/3,5 SATA GA125",
                "MOUSE PAD CRIATIVO YOUR FATHER",
                "MOUSE PAD APOIO P/PULSO GEL PTO 6013428"
            };
        int[] ArrayQuantidade =
            {
                20,10,5,7,10,10,5,50,
                7,20,10,5,6,10,12,25,10,10,
                5,8,9,10,10
            };
        double[] ArrayValor = 
            {
                900, 850.00, 270.00, 520.00, 170.00, 112.00, 14.00, 20.00,
                50.00, 500.00, 900.00,950.00,60.00,25.00,15.00,23.00,100.00,125.00,
                70.00,30.00,250.00,15.00,20.00
            };

        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(frmPrincipal frmTela)
        {
            InitializeComponent();
            frm1 = frmTela;
            lblCabeçalho2.Text = frm1.lblCabeçalho.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int linha = 0; linha < 23; linha++)
            {
                lbxProdutos.Items.Add(ArrayItem[linha]);
            }
        }

        private void BtnEnviarItem_Click(object sender, EventArgs e)
        {
            // lbxCompra.SelectedItems.Add(lbxProdutos.SelectedItems.ToString());
            frm1.lbxCompra.Items.Add(lbxProdutos.SelectedItem.ToString());
            frm1.lbxQuantidade1.Items.Add(txtQuantidade2.Text.ToString());
            frm1.lbxValor1.Items.Add(txtValor2.Text.ToString());

            dblSubtotal1 = dblSubtotal1 + Convert.ToDouble(txtQuantidade2.Text) * Convert.ToDouble(ArrayValor[lbxProdutos.SelectedIndex]);
            frm1.txtSubTotal1.Text = Convert.ToString(dblSubtotal1);

            txtQtdEstoque.Clear();
            txtValor2.Clear();
            txtQuantidade2.Clear();


        }

        

        private void LbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQtdEstoque.Text = ArrayQuantidade[lbxProdutos.SelectedIndex].ToString();
            txtValor2.Text = ArrayValor[lbxProdutos.SelectedIndex].ToString();
        }
    }
}
