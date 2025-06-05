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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um grupo.");
                return;
            }
            if (Box_Escala.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma escala.");
                return;
            }

            string grupoSelecionado = comboBox1.SelectedItem.ToString();
            string escalaSelecionada = Box_Escala.SelectedItem.ToString();
            string email = Login.CurrentUsername;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Usuário não identificado.");
                return;
            }
           
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um grupo.");
                return;
            }
            if (Box_Escala.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma escala.");
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Usuário não identificado.");
                return;
            }

            // Ensure grupoSelecionado and escalaSelecionada are not null or empty.  
            if (string.IsNullOrEmpty(grupoSelecionado) || string.IsNullOrEmpty(escalaSelecionada))
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

            // Buscar o id_pessoa pelo email  
            int idPessoa = -1;
            using (var cmdPessoa = new SqlCommand("SELECT id_pessoa FROM igreja.Pessoa WHERE username = @nome_completo", conn))
            {
                cmdPessoa.Parameters.AddWithValue("@Email", email);
                var result = cmdPessoa.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }
                idPessoa = Convert.ToInt32(result);
            }

            // Buscar o id_grupo pelo nome do grupo  
            int idGrupo = -1;
            using (var cmdGrupo = new SqlCommand("SELECT id_grupo FROM igreja.Grupo WHERE nome = @NomeGrupo", conn))
            {
                cmdGrupo.Parameters.AddWithValue("@NomeGrupo", grupoSelecionado);
                var result = cmdGrupo.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Grupo não encontrado.");
                    return;
                }
                idGrupo = Convert.ToInt32(result);
            }

            // Inserir na tabela MembroGrupo  
            using (var cmd = new SqlCommand(
                "INSERT INTO igreja.MembroGrupo (funcao, data_entrada, id_pessoa_membro, id_grupo_membro) " +
                "VALUES (@funcao, @data_entrada, @id_pessoa_membro, @id_grupo_membro)", conn))
            {
                cmd.Parameters.AddWithValue("@funcao", escalaSelecionada);
                cmd.Parameters.AddWithValue("@data_entrada", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@id_pessoa_membro", idPessoa);
                cmd.Parameters.AddWithValue("@id_grupo_membro", idGrupo);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Grupo e escala guardados com sucesso!");
                else
                    MessageBox.Show("Erro ao guardar grupo e escala.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Grupos_Load(object sender, EventArgs e)
        {

        }
    }
}
