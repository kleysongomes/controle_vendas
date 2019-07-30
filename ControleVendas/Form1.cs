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
        Form2 frmProdutos = new Form2();
        public frmPrincipal()
        {
            InitializeComponent();
            lblCabeçalho.Text = 
                " Controle de Vendas - Versão 0.0.1\n" +
                " Desenvolvido por:\n DesbravaLink Tecnologia e Inovação\n" +
                " Versão BetaTeste\n" +
                " Desenvolvido como Trabalho Escolar" +
                " Kleyson Gomes and José Dênis";
            txtNumeroVenda.Text = "0.0.1-0001";
        }

        private void BtnAdcionarProduto_Click(object sender, EventArgs e)
        {
            //Form2 frmProdutos = new Form2();
            frmProdutos.Show();
            //Abre formListProdutos
        }

        private void BtnRemoverProduto_Click(object sender, EventArgs e)
        {
            //Remove o produto selecionado da lbxCompra
        }

        private void BtnCalcularFrete_Click(object sender, EventArgs e)
        {
            //Exibe o valor do frete em txtfrete1 que é 10% do valor descrito em txtSubTotal1 
        }

        private void BtnGerarVenda_Click(object sender, EventArgs e)
        {
            //Abre formRelatorioCompra
        }
    }
}
