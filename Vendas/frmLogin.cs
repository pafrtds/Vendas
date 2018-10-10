using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vendas
{
    public partial class frmLogin : Form
    {
        string conn = @"Data Source = localhost\PROGRAMAS; Initial Catalog = vendas_sistema; User Id = sa; Password=1234;";
        SqlConnection conexao = new SqlConnection();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bttEntrar_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                conexao.ConnectionString = conn;
                conexao.Open();
                SqlCommand obj = new SqlCommand();
                obj.CommandText = "Select * FROM usuario WHERE usuario=@Usuario And  senha=@Senha";
                obj.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txtLogin.Text;
                obj.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha.Text;
                obj.CommandType = CommandType.Text;
                obj.Connection = conexao;

                SqlDataReader reader = obj.ExecuteReader();
                if (reader.HasRows)
                {
                    //todo : usuario logado
                    this.Hide();
                    frmGerenciador objTela = new frmGerenciador();
                    objTela.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha invalidos!");
                    //todo : Login ou Senha Invalida
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            finally

            {
                conexao.Close();   
            }

        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

