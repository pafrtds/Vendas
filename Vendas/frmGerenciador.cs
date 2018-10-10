using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Vendas
{
    public partial class frmGerenciador : Form
    {
        string conn = @"Data Source = localhost\PROGRAMAS; Initial Catalog = vendas_sistema; User Id = sa; Password=1234;";
        SqlConnection conexao = new SqlConnection();
        public frmGerenciador()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadcliente objTela = new frmCadcliente();
            objTela.ShowDialog();
        }
    }
}
