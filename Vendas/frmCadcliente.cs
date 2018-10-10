using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vendas
{
    public partial class frmCadcliente : Form
    {
        string conn = @"Data Source = localhost\PROGRAMAS; Initial Catalog = vendas_sistema; User Id = sa; Password=1234;";
        SqlConnection conexao = new SqlConnection();
        byte[] foto;
        int teste;
        string sexo;
        public frmCadcliente()
        {
            InitializeComponent();
        }

        private void dttDataNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void bttCep_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(txtCep.Text);
                    txtLougradouro.Text = resultado.end;
                    txtComplemento.Text = resultado.complemento;
                    txtCidade.Text = resultado.cidade;
                    txtBairro.Text = resultado.bairro;
                    cmbEstado.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void pctClie_Click(object sender, EventArgs e)
        {

        }

        public void bttFoto_Click(object sender, EventArgs e)
        {
            // if(OpenFileDialog.SHowDialog() == DialogResult.OK)
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Jpeg (*.jpeg)|*.jpeg"; ;
            file.Title = "Selecione a foto";
            if (file.ShowDialog() == DialogResult.OK)
            {

                string nomearquivo = file.FileName;
                Bitmap bmp = new Bitmap(nomearquivo);
                pctClie.Image = bmp;

                MemoryStream ms = new MemoryStream(); //salva em memoria

                bmp.Save(ms, ImageFormat.Jpeg);//pega os valores salvos, e joga no ms
                foto = ms.ToArray();// converte para Byte para assim conseguir armazenar no banco
                teste = 3;
            }

        }

        public void bttGravar_Click(object sender, EventArgs e)
        {
            conexao.ConnectionString = conn;

            
           SqlCommand comando= new SqlCommand("INSERT INTO clientes(nome,cpf_cnpj,rg,data_nasc,sexo,telefone,celular,email,cep,lougradouro,numero,complemento,bairro,cidade,estado,foto_clie) VALUES (@nome,@cpf_cnpj,@rg,@data_nasc,@sexo,@telefone,@celular,@email,@cep,@lougradouro,@numero,@complemento,@bairro,@cidade,@estado,@fotoso)", conexao);


            //Adicionando o valor das textBox nos parametros do comando
            SqlParameter paramfoto = new SqlParameter("@fotoso", SqlDbType.VarBinary);
            paramfoto.Value = foto;

            //fim da foto
            //comando.Parameters.Add("cod_clie", SqlDbType.Int).Value = txtCod_Clie;
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@cpf_cnpj", SqlDbType.VarChar).Value = txtCpf_Cnpj.Text;
            comando.Parameters.Add("@rg", SqlDbType.VarChar).Value = txtRg.Text;
            comando.Parameters.Add("@data_nasc", SqlDbType.DateTime).Value = dttDataNasc.Text;
            comando.Parameters.Add("@sexo", SqlDbType.VarChar).Value = txtSexo.Text;
            comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTel.Text;
            comando.Parameters.Add("@celular", SqlDbType.VarChar).Value = txtCel.Text;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@cep", SqlDbType.VarChar).Value = txtCep.Text;
            comando.Parameters.Add("@lougradouro", SqlDbType.VarChar).Value = txtLougradouro.Text;
            comando.Parameters.Add("@numero", SqlDbType.Int).Value = txtNumero.Text;
            comando.Parameters.Add("@complemento", SqlDbType.VarChar).Value = txtComplemento.Text;
            comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = cmbEstado.Text;
            //comando.Parameters.Add("@foto_clie", SqlDbType.VarBinary).Value = foto;
            comando.Parameters.Add(paramfoto);

            try
            {
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
               

                //abre a conexao
                conexao.Open();
                //executa o comando com os parametros que foram adicionados acima
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados!");
                //fecha a conexao
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void chcFeminino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Feminino";
        }

        private void chcMasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Masculino";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}