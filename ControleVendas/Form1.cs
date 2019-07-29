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
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
            lblCabeçalho.Text = 
                " Controle de Vendas - Versão 0.0.1\n" +
                " Desenvolvido por:\n DesbravaLink Tecnologia e Inovação\n" +
                " Versão BetaTest\n" +
                " Desenvolvido como Trabalho Escolar" +
                " Kleyson Gomes and José Dênis";
            txtNumeroVenda.Text = "0.0.1-0001";
        }
    }
}
