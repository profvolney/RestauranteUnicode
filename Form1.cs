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

        private void button2_Click(object sender, EventArgs e)
        {
            string Email = textBox1.Text.Trim();
            string Senha = textBox2.Text.Trim();

            if(string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Senha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else
            {
                try
                {
                    //Pegando a conexão com o banco de dados
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-5Q9OJ4O;Initial Catalog=RestauranteUnicode;Integrated Security=True");
                    
                    //Abrindo a conexão
                    con.Open();

                    //Instrução SQL 
                    string sql = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                    
                    // Passando a instrução SQL e a conexão para o comando
                    SqlCommand cmd = new SqlCommand(sql, con);
                    
                    // Passando os parâmetros para o comando
                    cmd.Parameters.AddWithValue("@Username", Email);
                    cmd.Parameters.AddWithValue("@Password", Senha);
                    
                    // Executando o comando e obtendo o resultado
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Login efetuado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Email ou senha incorretos!" + ex.Message);                    
                }
                     
            }
        }
    }
}
