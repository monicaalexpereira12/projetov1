using Microsoft.Data.SqlClient;

namespace projetov1
{
    public partial class EventosAdmin : Form
    {

        // Adicione o seguinte campo ao início da classe EventosAdmin para corrigir o erro CS0103.  
        // Isso garante que o controle "check_disponibilidade" seja declarado corretamente.  

        private CheckBox check_disponibilidade;
        public EventosAdmin()
        {
            InitializeComponent();
            CarregarEventos();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }



        private void Return_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
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
            grupoAdmin gruposForm = new grupoAdmin();
            gruposForm.Show();
            this.Hide();
        }

        private void Button_to_Profile_Click(object sender, EventArgs e)
        {
            DadosAdmin dadosPessoaForm = new DadosAdmin();
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

            // Supondo que existe uma tabela DisponibilidadeEventos com Username, Evento, Disponivel
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
        private void CarregarEventos()
        {
            comboBox1.Items.Clear();
            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            var cmd = new SqlCommand("SELECT Nome FROM Eventos", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Nome"].ToString());
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string novoEvento = textBoxNovoEvento.Text.Trim();
            if (string.IsNullOrEmpty(novoEvento))
            {
                MessageBox.Show("Digite o nome do evento.");
                return;
            }

            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            var cmd = new SqlCommand("INSERT INTO Eventos (Nome) VALUES (@nome)", conn);
            cmd.Parameters.AddWithValue("@nome", novoEvento);
            cmd.ExecuteNonQuery();

            CarregarEventos();
            textBoxNovoEvento.Clear();
        }
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            string eventoSelecionado = comboBox1.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrEmpty(eventoSelecionado))
            {
                MessageBox.Show("Selecione um evento para remover.");
                return;
            }

            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            using var conn = new SqlConnection($"Data Source={dbServer};Initial Catalog={dbName};uid={userName};password={userPass};TrustServerCertificate=True");
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Eventos WHERE Nome = @nome", conn);
            cmd.Parameters.AddWithValue("@nome", eventoSelecionado);
            cmd.ExecuteNonQuery();

            CarregarEventos();
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            buttonAdicionar.Visible = true;
            buttonRemover.Visible = true;
            buttonSalvar.Visible = true;
            textBoxNovoEvento.Visible = true;
            comboBox1.Visible = true;
            buttonEditar.Visible = false;
        }
    }
}
