using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaDeVendas
{

    public partial class frm_MenuInicial : Form
    {
        
        public frm_MenuInicial()
        {
            InitializeComponent();
        }



        private void btn_CadProdutos_Click(object sender, EventArgs e)
        {
            frm_Produtos frm = new frm_Produtos();
            frm.Show();

        }

        private void btn_CadCategorias_Click(object sender, EventArgs e)
        {
            frm_Categorias frm = new frm_Categorias();
            frm.Show();
        }

        private void frm_MenuInicial_Load(object sender, EventArgs e)
        {

        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
