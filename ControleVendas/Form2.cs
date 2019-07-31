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

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(frmPrincipal frmTela)
        {
            InitializeComponent();
            frm1 = frmTela;
        }

        private void BtnEnviarItem_Click(object sender, EventArgs e)
        {
            // lbxCompra.SelectedItems.Add(lbxProdutos.SelectedItems.ToString());
            frm1.lbxCompra.Items.Add(lbxProdutos.SelectedItem.ToString());
            frm1.lbxQuantProduto.Items.Add(txtQuatidade.Text.ToString());
        }
    }
}
