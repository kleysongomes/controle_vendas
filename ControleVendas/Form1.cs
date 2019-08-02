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
        Form3 frmCupom;

        string strLogText;
        string versao;
        string strCumpom3;
        string strLinhaCupom;

        double dblFreteCalc;
        double dblTotalPagar;

        public frmPrincipal()
        {
            InitializeComponent();
            
            versao = "0.2.8";
            lblCabeçalho.Text = 
                " Controle de Vendas - Versão " + versao + "\n" +
                " Desenvolvido por:\n DesbravaLink Tecnologia e Inovação\n" +
                " Versão BetaTeste\n" +
                " Desenvolvido como Trabalho Escolar\n" +
                " Kleyson Gomes and José Dênis";
            txtNumeroVenda.Text = versao + "."+ DateTime.Now.ToString("yyyyMMddHHmmss");

        }
        public frmPrincipal(Form2 frmProdutos)
        {
            frmListProdutos = frmProdutos;
        }
        public frmPrincipal(Form3 frmCupomProdutos)
        {
            frmCupom = frmCupomProdutos;
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

            //
            txtFrete1.Clear();
            dblFreteCalc = (Convert.ToDouble(txtSubTotal1.Text) * 10) / 100;
            txtFrete1.Text = Convert.ToString(dblFreteCalc);

            dblTotalPagar = Convert.ToDouble(txtSubTotal1.Text) + Convert.ToDouble(txtFrete1.Text);
            txtTotalPagar.Text = Convert.ToString(dblTotalPagar);
            //#
        }

        private void BtnCalcularFrete_Click(object sender, EventArgs e)
        {
            //Exibe o valor do frete em txtfrete1 que é 10% do valor descrito em txtSubTotal1 
            txtFrete1.Clear();
            dblFreteCalc = (Convert.ToDouble(txtSubTotal1.Text)*10)/100;
            txtFrete1.Text = Convert.ToString(dblFreteCalc);

            dblTotalPagar = Convert.ToDouble(txtSubTotal1.Text) + Convert.ToDouble(txtFrete1.Text);
            txtTotalPagar.Text = Convert.ToString(dblTotalPagar);
        }

        private void BtnGerarVenda_Click(object sender, EventArgs e)
        {
            strLogText ="\n\nSubtotal: R$" + txtSubTotal1.Text + "\nFrete: R$" + txtFrete1.Text 
                        + "\nValor Total Pago: R$" + txtTotalPagar.Text + "\nForma de Pagamento: " + cbxFormadePagto.Text 
                        + "\n\nVendedor: " + txtNomeVendedor.Text + "\nID do Vendedor: " + txtIDVendedor.Text;
            System.IO.File.WriteAllText
                (@"C:\Repositorios\controle_vendas\LogVendas\Venda_" + txtNumeroVenda.Text + ".txt", "Arquivo de log da venda " + txtNumeroVenda.Text + "\n");
            for (int cont = 0; cont < lbxCompra.Items.Count ;cont ++)
            {
                //Escreve no txt de log os itens de acordo com o contador
                System.IO.File.AppendAllText
                    (@"C:\Repositorios\controle_vendas\LogVendas\Venda_" + txtNumeroVenda.Text + ".txt", "\nProduto: " + lbxCompra.Items[cont].ToString());
                System.IO.File.AppendAllText
                    (@"C:\Repositorios\controle_vendas\LogVendas\Venda_" + txtNumeroVenda.Text + ".txt", "\nQuantidade: " + lbxQuantidade1.Items[cont].ToString());
                System.IO.File.AppendAllText
                    (@"C:\Repositorios\controle_vendas\LogVendas\Venda_" + txtNumeroVenda.Text + ".txt", "\nValor Unitario: " + lbxValor1.Items[cont].ToString());
                //#

                //Salva na str os itens, qtds e valores unitarios para envio ao cupom de acordo com o contador
                strCumpom3 = "\n" + strCumpom3 + "\nItem: " + lbxCompra.Items[cont].ToString() + 
                    "\n Qtd: " + lbxQuantidade1.Items[cont].ToString() + "\nValor Unitario: " + lbxValor1.Items[cont].ToString();
                //#

            }
            System.IO.File.AppendAllText(@"C:\Repositorios\controle_vendas\LogVendas\Venda_" + txtNumeroVenda.Text + ".txt", strLogText);
            //

            //Aviso de que foi gerado o log
            MessageBox.Show("Dados registrados\nlog_Realizado_System_form2", versao , MessageBoxButtons.OK, MessageBoxIcon.Information);
            //#

            //Declaro o obj do form 3 e inicia o form3
            Form3 frmCupomProdutos = new Form3();
            frmCupomProdutos.Show();
            //#

            //Passa os dados do form 1 para a textbox do form3
            strLinhaCupom = "\n\n  - - - - - - - - - - - - - - - - - - - - - - - - - - - -  \n";
            strCumpom3 = strCumpom3 + strLinhaCupom + "\nForma de Pagamento:- - - - -" + cbxFormadePagto.Text  + "\n" + "Subtotal:- - - - -R$" + txtSubTotal1.Text
                + "\n" +  "Frete:- - - - -R$" + txtFrete1.Text  + "\n" + "Valor Total Pago:- - - - -R$" + txtTotalPagar.Text;

            frmCupomProdutos.lblCupom.Text = lblCabeçalho.Text + strLinhaCupom +  strCumpom3;
            //#
        }
    }
}
