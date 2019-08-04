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
        //declaração dos Forms
        frmPrincipal frm1;
        //#
        //Variaves Globais
        double dblSubtotal1;
        double dblTotalPagar2;
        //#

        //Arrays(Item, Quantidade, Valor)
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
        //#
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(frmPrincipal frmTela)
        {
            //Recebendo o Form1 como parametro
            InitializeComponent();
            frm1 = frmTela;
            lblCabeçalho2.Text = frm1.lblCabeçalho.Text;
            //#
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //For para percorrer o arrai item e pegar o index dele para exibição de Quantitade e Valor equivalentes na posição do Array
            for (int linha = 0; linha < 23; linha++)
            {
                lbxProdutos.Items.Add(ArrayItem[linha]);
            }
            //#

            //btnEviarItem inicia Inativo
            btnEnviarItem.Enabled = false;
            //#
        }
        private void LbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Passando os dados dos Arrays Valor e Quantidade para as Texbox Valor2 e QtdEstoque coletado por meio do index obtido no for a cima
            txtQtdEstoque.Text = ArrayQuantidade[lbxProdutos.SelectedIndex].ToString();
            txtValor2.Text = ArrayValor[lbxProdutos.SelectedIndex].ToString();
            //#

            //btnEviarItem se torna ativo quando um item é selecionado
            btnEnviarItem.Enabled = true;
            //#
        }
        private void BtnEnviarItem_Click(object sender, EventArgs e)
        {
            if (ArrayQuantidade[lbxProdutos.SelectedIndex] >= Convert.ToInt32(txtQuantidade2.Text))
            { 
                //Pasando o Item selecionado no Form2 para o Form1
                frm1.lbxCompra.Items.Add(lbxProdutos.SelectedItem.ToString());
                frm1.lbxQuantidade1.Items.Add(txtQuantidade2.Text.ToString());
                frm1.lbxValor1.Items.Add(txtValor2.Text.ToString());
                //#
            
                //Calculo do SubTotal
                dblSubtotal1 = dblSubtotal1 + Convert.ToDouble(txtQuantidade2.Text) * Convert.ToDouble(ArrayValor[lbxProdutos.SelectedIndex]);
                frm1.txtSubTotal1.Text = Convert.ToString(dblSubtotal1);
                //#
            
                //Calculando o SubTotal + Frete = Valor Total a pagar e enviando para o form1
                dblTotalPagar2 = Convert.ToDouble(frm1.txtSubTotal1.Text) + Convert.ToDouble(frm1.txtFrete1.Text);
                frm1.txtTotalPagar.Text =  Convert.ToString(dblTotalPagar2);
                //#
            
                //Altera a quantidade no ArrayQuantidade
                ArrayQuantidade[lbxProdutos.SelectedIndex] = Convert.ToInt32(Convert.ToDouble(txtQtdEstoque.Text) - Convert.ToDouble(txtQuantidade2.Text));
                //#

                //Limpando os dados das Texbox coletado no inicio da instrução
                txtQtdEstoque.Clear();
                txtValor2.Clear();
                txtQuantidade2.Clear();
                //#
            }
            else
            {
                //Aviso de alerta de falta de protudo no estoque
                MessageBox.Show("Produto em falta de Estoque", "Erro: 666", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //#
            }
        }
    }
}
