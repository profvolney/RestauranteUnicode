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
using Microsoft.Data.SqlClient;

namespace RestauranteUnicode
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.Open();

                    string sql = "INSERT INTO Cardapio (Prato, Descricao, Recheios, Ingredientes, " +
                        "Preco, Opcionais) VALUES (Prato= @Prato, Descricao = @Descricao, " +
                        "Recheios = @Recheios, Ingredientes = @Ingredientes, Preco = @Preco, Opcionais = @Opcionais)";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@Prato", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Descricao", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Recheios", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Ingredientes", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Preco", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Opcionais", textBox6.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir no banco de dados!" + ex.Message);
            }
            

        }
    }
}
