using Microsoft.Data.SqlClient;

namespace projetov1
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] {
                   "Missa Dominical",
                   "Casamento",
                   "Batizado",
                   "Procissão",
                   "Retiro",
                   "Encontro de Jovens"
               });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Return_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Grupos gruposForm = new Grupos();
            gruposForm.Show();
            this.Hide();
        }

        private void Button_to_Profile_Click(object sender, EventArgs e)
        {
            DadosPessoa dadosPessoaForm = new DadosPessoa();
            dadosPessoaForm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string username = Login.CurrentUsername;
            string eventoSelecionado = comboBox1.SelectedItem?.ToString() ?? "";
            bool disponibilidade = check_disponibilidade.Checked;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(eventoSelecionado))
            {
                MessageBox.Show("Selecione um evento.");
                return;
            }

            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            
            var cmd = new SqlCommand(
                "INSERT INTO DisponibilidadeEventos (Username, Evento, Disponivel) VALUES (@username, @evento, @disponivel)", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@evento", eventoSelecionado);
            cmd.Parameters.AddWithValue("@disponivel", disponibilidade);

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Disponibilidade registrada!");
            else
                MessageBox.Show("Erro ao registrar disponibilidade.");
        }
    }
}
*