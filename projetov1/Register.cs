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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using BCrypt.Net;


namespace projetov1
{
    public partial class Register : Form
    {
        private SqlConnection connect;
        public Register()
        {
            InitializeComponent();

        }
        private static SqlConnection GetSGBDConnection()
        {
            string dbServer = "tcp: mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g2";
            string userName = "p2g2";
            string userPass = "-188@BD";
            return new SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName +
                                      "; uid = " + userName + ";" + "password = " + userPass + ";TrustServerCertificate=True");
        }
        private bool VerifySGBDConnection()
        {
            if (connect == null)
                connect = GetSGBDConnection();

            if (connect.State != ConnectionState.Open)
                connect.Open();

            return connect.State == ConnectionState.Open;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            reg_pass.PasswordChar = reg_shpass.Checked ? '\0' : '*';
            reg_confpass.PasswordChar = reg_shpass.Checked ? '\0' : '*';

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Register_Load(object sender, EventArgs e)
        {
            connect = GetSGBDConnection();
            if (!VerifySGBDConnection())
            {
                MessageBox.Show("Erro ao conectar ao banco de dados.");
                this.Close();
            }
        }


        private void buttonlogin_Click(object sender, EventArgs e)
        {

        }
        public bool empty_fields()
        {
            if (reg_username.Text == "" || reg_pass.Text == "" || reg_confpass.Text == "" || emailBox.Text == "")
            { return true; }
            else { return false; }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = reg_username.Text;
            string password = reg_pass.Text;
            string confirmPassword = reg_confpass.Text;
            string email = emailBox.Text;

            if (empty_fields())
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, tente novamente.");
                return;
            }

            try
            {
                if (!VerifySGBDConnection())
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados.");
                    return;
                }

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                // Usando transação para garantir integridade
                using (SqlTransaction transaction = connect.BeginTransaction())
                {
                    try
                    {
                        // 1. Inserir na tabela Pessoa e obter o ID gerado
                        int newId;
                        using (SqlCommand cmd = new SqlCommand(
                            "INSERT INTO igreja.Pessoa (nome_completo, email) OUTPUT INSERTED.id_pessoa VALUES (@nome, @email);",
                            connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@nome", username);
                            cmd.Parameters.AddWithValue("@email", email);
                            newId = (int)cmd.ExecuteScalar();
                        }

                        // 2. Inserir na tabela Users com o mesmo ID
                        using (SqlCommand cmd = new SqlCommand(
                            "INSERT INTO igreja.Users (id_number, password_hash, funcao) VALUES (@id, @password, @role);",
                            connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", newId);
                            cmd.Parameters.AddWithValue("@password", hashedPassword);
                            cmd.Parameters.AddWithValue("@role", "Utilizador");
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                throw new Exception("Falha ao inserir na tabela Users");
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Conta criada com sucesso!");
                        Menu menu = new Menu();
                        menu.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw; 
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) 
                {
                    if (ex.Message.Contains("email"))
                        MessageBox.Show("Este email já está registado.");
                    else if (ex.Message.Contains("username"))
                        MessageBox.Show("Este nome de utilizador já existe.");
                    else
                        MessageBox.Show("Registro duplicado: " + ex.Message);
                }
                else
                {
                    MessageBox.Show("Erro SQL: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (connect?.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
