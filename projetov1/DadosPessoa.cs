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
    public partial class DadosPessoa : Form
    {
        public DadosPessoa()
        {
            InitializeComponent();

            var username = Login.CurrentUsername;
            if (!string.IsNullOrEmpty(username))
            {
                var dados = BuscarDadosUsuario(username);
                if (dados != null)
                {
                    labelNome.Text = dados.Value.Nome;
                    labelEmail.Text = dados.Value.Email;
                    labelMorada.Text = dados.Value.Morada;
                    labelDataNascimento.Text = dados.Value.DataNascimento;
                    labelTelefone.Text = dados.Value.Telefone;
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }
            }
        }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Morada { get; set; } = string.Empty;
        public string DataNascimento { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            Menu Menuform = new Menu();
            Menuform.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Loginform = new Login();
            Loginform.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public DadosPessoa(string nome, string email, string morada, string dataNascimento, string telefone)
        {
            InitializeComponent();
            Nome = Login.CurrentUsername;
            Email = email;
            Morada = morada;
            DataNascimento = dataNascimento;
            Telefone = telefone;

            // Exemplo de atribuição aos controles do formulário
            labelNome.Text = Nome;
            labelEmail.Text = Email;
            labelMorada.Text = Morada;
            labelDataNascimento.Text = DataNascimento;
            labelTelefone.Text = Telefone;
        }

        private void labelNome_Click(object sender, EventArgs e)
        {


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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelMorada_Click(object sender, EventArgs e)
        {

        }
    }
}
