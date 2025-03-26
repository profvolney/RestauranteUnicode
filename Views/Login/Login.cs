using Microsoft.Data.SqlClient;
using RestauranteUnicode.Views.Cadastrar;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestauranteUnicode
{
    public partial class RestauranteUnicode : Form
    {
        public RestauranteUnicode()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string email = txtEmail.Text.Trim();
                string senha = txtSenha.Text.Trim();

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("preencha todos os campos!");
                    return;
                }
                else
                {
                    try
                    {
                        //pegando a conexão com o banco de dados
                        SqlConnection con = new SqlConnection("data source=desktop-5q9oj4o;initial catalog=restauranteunicode;integrated security=true");

                        //abrindo a conexão
                        con.Open();

                        //instrução sql 
                        string sql = "select * from users where username = @username and password = @password";

                        // passando a instrução sql e a conexão para o comando
                        Microsoft.Data.SqlClient.SqlCommand cmd = new SqlCommand(sql, con);

                        // passando os parâmetros para o comando
                        cmd.Parameters.AddWithValue("@username", email);
                        cmd.Parameters.AddWithValue("@password", senha);

                        // executando o comando e obtendo o resultado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("login efetuado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("email ou senha incorretos!" + ex.Message);
                    }

                }

            }
            catch
            {

            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cad = new Cadastrar();
            cad.Show();
        }

        private void btnCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        
    }
}
