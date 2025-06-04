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
    public partial class grupoAdmin : Form
    {
        public grupoAdmin()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Leitor", "Catequista", "Acólito", "Ministro da Comunhão Eucarística", "Corista", "Catequizados" });

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Return_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
            this.Hide();
        }

        private void Button_to_Profile_Click(object sender, EventArgs e)
        {
            DadosAdmin dadosPessoaForm = new DadosAdmin();
            dadosPessoaForm.Show();
            this.Hide();
        }

        private void Eventos_Click(object sender, EventArgs e)
        {
            EventosAdmin eventosForm = new EventosAdmin();
            eventosForm.Show();
            this.Hide();
        }
        private void CarregarGrupos()
        {
            comboBox1.Items.Clear();
            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            var cmd = new SqlCommand("SELECT Nome FROM Grupos", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Nome"].ToString());
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void TipoGrupoLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Box_Escala.Items.Clear();

            switch (comboBox1.SelectedItem?.ToString())
            {
                case "Leitor":
                    Box_Escala.Items.AddRange(new string[] { "1ª Leitura", "2ª Leitura", "Salmo" });
                    break;
                case "Catequista":
                    Box_Escala.Items.AddRange(new string[] { "Infância", "Adolescentes", "Adultos" });
                    break;
                case "Acólito":
                    Box_Escala.Items.AddRange(new string[] { "Missa Dominical", "Casamento", "Batizado" });
                    break;
                case "Ministro da Comunhão Eucarística":
                    Box_Escala.Items.AddRange(new string[] { "Celebração", "Visita a Doentes" });
                    break;
                case "Corista":
                    Box_Escala.Items.AddRange(new string[] { "Soprano", "Contralto", "Tenor", "Baixo" });
                    break;
                case "Catequizados":
                    Box_Escala.Items.AddRange(new string[] { "1º Ano", "2º Ano", "3º Ano" });
                    break;
                default:
                    break;
            }

        }
        //apesar de clicar no botão salvar, o grupo não é atualizado na base de dados e aparece o popup
        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            string grupoSelecionado = comboBox1.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrEmpty(grupoSelecionado))
            {
                MessageBox.Show("Selecione um grupo para remover.");
                return;
            }

            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Grupos WHERE Nome = @nome", conn);
            cmd.Parameters.AddWithValue("@nome", grupoSelecionado);
            cmd.ExecuteNonQuery();

            CarregarGrupos();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string novoGrupo = textBoxNovoGrupo.Text.Trim();
            if (string.IsNullOrEmpty(novoGrupo))
            {
                MessageBox.Show("Digite o nome do grupo.");
                return;
            }

            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            var checkCmd = new SqlCommand("SELECT COUNT(*) FROM Grupos WHERE Nome = @nome", conn);
            checkCmd.Parameters.AddWithValue("@nome", novoGrupo);
            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Grupo já existe.");
                return;
            }

            var cmd = new SqlCommand("INSERT INTO Grupos (Nome) VALUES (@nome)", conn);
            cmd.Parameters.AddWithValue("@nome", novoGrupo);
            cmd.ExecuteNonQuery();

            CarregarGrupos();
            textBoxNovoGrupo.Clear();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            buttonAdicionar.Visible = true;
            buttonRemover.Visible = true;
            buttonSalvar.Visible = true;
            textBoxNovoGrupo.Visible = true;
            comboBox1.Visible = true;
            Box_Escala.Visible = true;
            buttonEditar.Visible = false;
        }
    }
}
