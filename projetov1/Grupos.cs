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
    public partial class Grupos : Form
    {
        public Grupos()
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
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Button_to_Profile_Click(object sender, EventArgs e)
        {
            DadosPessoa dadosPessoaForm = new DadosPessoa();
            dadosPessoaForm.Show();
            this.Hide();
        }

        private void Eventos_Click(object sender, EventArgs e)
        {
            Eventos eventosForm = new Eventos();
            eventosForm.Show();
            this.Hide();
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
            string grupoSelecionado = comboBox1.SelectedItem?.ToString() ?? "";
            string escalaSelecionada = Box_Escala.SelectedItem?.ToString() ?? "";
            string username = Login.CurrentUsername;
            if (string.IsNullOrEmpty(grupoSelecionado) || string.IsNullOrEmpty(escalaSelecionada) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Selecione um grupo e uma escala.");
                return;
            }

            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            // Atualiza os campos Role e Escala na tabela users
            var cmd = new SqlCommand("UPDATE users SET Role=@role, Escala=@escala WHERE username=@username", conn);
            cmd.Parameters.AddWithValue("@role", grupoSelecionado);
            cmd.Parameters.AddWithValue("@escala", escalaSelecionada);
            cmd.Parameters.AddWithValue("@username", username);

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Grupo e escala atualizados com sucesso!");
            else
                MessageBox.Show("Erro ao atualizar grupo e escala.");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
