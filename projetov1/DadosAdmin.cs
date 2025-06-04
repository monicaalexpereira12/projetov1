using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace projetov1
{
    public partial class DadosAdmin : Form
    {
        public DadosAdmin()
        {
            InitializeComponent();
        }
        public static (string Nome, string Email, string Morada, string DataNascimento, string Telefone)? BuscarDadosUsuario(string username)
        {
            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            var cmd = new SqlCommand("SELECT Nome, Email, Morada, DataNascimento, Telefone FROM Users WHERE Username = @username", conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (
                    reader["Nome"].ToString() ?? "",
                    reader["Email"].ToString() ?? "",
                    reader["Morada"].ToString() ?? "",
                    reader["DataNascimento"].ToString() ?? "",
                    reader["Telefone"].ToString() ?? ""
                );
            }
            return null;
        }
        private void Button_to_Profile_Click(object sender, EventArgs e)
        {

        }

        private void alterardados_Click(object sender, EventArgs e)
        {
            textBoxNome.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBoxMorada.ReadOnly = false;
            textBoxDataNascimento.ReadOnly = false;
            textBoxTelefone.ReadOnly = false;
            buttonSalvar.Visible = true;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var username = Login.CurrentUsername;
            if (string.IsNullOrEmpty(username)) return;

            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string morada = textBoxMorada.Text;
            string dataNascimento = textBoxDataNascimento.Text;
            string telefone = textBoxTelefone.Text;

            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            var cmd = new SqlCommand(
                "UPDATE users SET Nome=@nome, Email=@email, Morada=@morada, DataNascimento=@dataNascimento, Telefone=@telefone WHERE Username=@username", conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@morada", morada);
            cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@username", username);

            int rows = cmd.ExecuteNonQuery();

            textBoxNome.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxMorada.ReadOnly = true;
            textBoxDataNascimento.ReadOnly = true;
            textBoxTelefone.ReadOnly = true;
            buttonSalvar.Visible = false;

            if (rows > 0)
                MessageBox.Show("Dados atualizados com sucesso!");
            else
                MessageBox.Show("Erro ao atualizar dados.");
        }

        private void Grupos_Click(object sender, EventArgs e)
        {
            grupoAdmin gruposForm = new grupoAdmin();
            gruposForm.Show();
            this.Hide();
        }

        private void Return_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
