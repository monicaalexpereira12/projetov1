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

            var email = Login.CurrentUsername; // Supondo que Login.CurrentUsername armazene o email do usuário
            if (!string.IsNullOrEmpty(email))
            {
                var dados = BuscarDadosUsuario(email);
                if (dados != null)
                {
                    textBoxNome.Text = dados.Value.Nome;
                    textBoxEmail.Text = dados.Value.Email;
                    textBoxMorada.Text = dados.Value.Morada;
                    textBoxDataNascimento.Text = dados.Value.DataNascimento;
                    textBoxTelefone.Text = dados.Value.Telefone;
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

        }

        private void labelNome_Click(object sender, EventArgs e)
        {


        }
        public static (string Nome, string Email, string Morada, string DataNascimento, string Telefone)? BuscarDadosUsuario(string email)
        {
            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            var cmd = new SqlCommand(
                "SELECT nome_completo, email, morada, data_nascimento, phone_number FROM igreja.Pessoa WHERE email = @email", conn);
            cmd.Parameters.AddWithValue("@email", email);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (
                    reader["nome_completo"].ToString() ?? "",
                    reader["email"].ToString() ?? "",
                    reader["morada"].ToString() ?? "",
                    reader["data_nascimento"]?.ToString() ?? "",
                    reader["phone_number"].ToString() ?? ""
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Grupos_Click(object sender, EventArgs e)
        {
            Grupos gruposForm = new Grupos();
            gruposForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
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

        private void Salvar_Click(object sender, EventArgs e)
        {
            string nomeCompleto = textBoxNome.Text;
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
                "INSERT INTO igreja.Pessoa (nome_completo, email, morada, data_nascimento, phone_number) " +
                "VALUES (@nome_completo, @email, @morada, @data_nascimento, @phone_number)", conn);
            cmd.Parameters.AddWithValue("@nome_completo", nomeCompleto);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@morada", morada);
            cmd.Parameters.AddWithValue("@data_nascimento", string.IsNullOrWhiteSpace(dataNascimento) ? (object)DBNull.Value : DateTime.Parse(dataNascimento));
            cmd.Parameters.AddWithValue("@phone_number", telefone);

            int rows = cmd.ExecuteNonQuery();

            // Bloqueia os campos e esconde o botão salvar
            textBoxNome.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxMorada.ReadOnly = true;
            textBoxDataNascimento.ReadOnly = true;
            textBoxTelefone.ReadOnly = true;
            buttonSalvar.Visible = false;

            if (rows > 0)
                MessageBox.Show("Dados inseridos com sucesso!");
            else
                MessageBox.Show("Erro ao inserir dados.");
        }

        private void Eventos_Click(object sender, EventArgs e)
        {
            Eventos eventosForm = new Eventos();
            eventosForm.Show();
            this.Hide();
        }
    }
}
