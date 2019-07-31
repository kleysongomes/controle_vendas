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
        public frmPrincipal()
        {
            InitializeComponent();
            
            string versao = "0.0.5";
            lblCabeçalho.Text = 
                " Controle de Vendas - " + versao + "\n" +
                " Desenvolvido por:\n DesbravaLink Tecnologia e Inovação\n" +
                " Versão BetaTeste\n" +
                " Desenvolvido como Trabalho Escolar" +
                " Kleyson Gomes and José Dênis";
            txtNumeroVenda.Text = "0.0.1-0001";
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
        }

        private void BtnGerarVenda_Click(object sender, EventArgs e)
        {
            //Abre formRelatorioCompra
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
