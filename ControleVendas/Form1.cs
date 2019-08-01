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
    public partial class frmPrincipal : Form
    {
        Form2 frmListProdutos;

        int[] ArrayContLbx = new int[1000];

        string strLogText;
        double dblFreteCalc;
        double dblTotalPagar;
        public frmPrincipal()
        {
            InitializeComponent();
            
            string versao = "0.1.5";
            lblCabeçalho.Text = 
                " Controle de Vendas - " + versao + "\n" +
                " Desenvolvido por:\n DesbravaLink Tecnologia e Inovação\n" +
                " Versão BetaTeste\n" +
                " Desenvolvido como Trabalho Escolar" +
                " Kleyson Gomes and José Dênis";
            txtNumeroVenda.Text = versao + "."+ DateTime.Now.ToString("yyyyMMddHHmmss");

        }
        public frmPrincipal(Form2 frmProdutos)
        {
            frmListProdutos = frmProdutos;
        }
            private void BtnAdcionarProduto_Click(object sender, EventArgs e)
        {
            //Abre formListProdutos
            Form2 frmProdutos = new Form2(this);
            frmProdutos.Show();
        }

        private void BtnRemoverProduto_Click(object sender, EventArgs e)
        {
            //Remove o produto selecionado da lbxCompra
            this.lbxQuantidade1.Items.RemoveAt(lbxCompra.SelectedIndex);
            this.lbxValor1.Items.RemoveAt(lbxCompra.SelectedIndex);
            this.lbxCompra.Items.Remove(lbxCompra.SelectedItem.ToString());
        }

        private void BtnCalcularFrete_Click(object sender, EventArgs e)
        {
            //Exibe o valor do frete em txtfrete1 que é 10% do valor descrito em txtSubTotal1 
            dblFreteCalc = (Convert.ToDouble(txtSubTotal1.Text)*10)/100;
            txtFrete1.Text = Convert.ToString(dblFreteCalc);

            dblTotalPagar = dblTotalPagar + Convert.ToDouble(txtSubTotal1.Text) + Convert.ToDouble(txtFrete1.Text);
            txtTotalPagar.Text = Convert.ToString(dblTotalPagar);
        }

        private void BtnGerarVenda_Click(object sender, EventArgs e)
        {
            strLogText ="\n\nSubtotal: R$" + txtSubTotal1.Text + "\nFrete: R$" + txtFrete1.Text 
                        + "\nValot Pago: R$" + txtTotalPagar.Text + "\nForma de Pagamento: " + cbxFormadePagto.Text 
                        + "\n\nVendedor: " + txtNomeVendedor.Text + "\nID do Vendedor: " + txtIDVendedor.Text;
            System.IO.File.WriteAllText
                (@"C:\Repositorios\controle_vendas\LogVendas\Venda_" + txtNumeroVenda.Text + ".txt", "Arquivo de log da venda " + txtNumeroVenda.Text + "\n");
            for (int cont = 0; cont < lbxCompra.Items.Count ;cont ++)
            {
                System.IO.File.AppendAllText
                    (@"C:\Repositorios\controle_vendas\LogVendas\Venda_" + txtNumeroVenda.Text + ".txt", "\nProduto: " + lbxCompra.Items[cont].ToString());
                System.IO.File.AppendAllText
                    (@"C:\Repositorios\controle_vendas\LogVendas\Venda_" + txtNumeroVenda.Text + ".txt", "\nQuantidade: " + lbxQuantidade1.Items[cont].ToString());
                System.IO.File.AppendAllText
                    (@"C:\Repositorios\controle_vendas\LogVendas\Venda_" + txtNumeroVenda.Text + ".txt", "\nValor: " + lbxValor1.Items[cont].ToString());
            }
            System.IO.File.AppendAllText(@"C:\Repositorios\controle_vendas\LogVendas\Venda_" + txtNumeroVenda.Text + ".txt", strLogText);
            //
            //
            MessageBox.Show("Dados registrados\nlog_Realizado_System_form2", "Hello Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //#
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
