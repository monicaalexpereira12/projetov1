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


namespace projetov1
{
    public partial class Login : Form
    {
        private SqlConnection connect = null!;

        public Login()
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (!VerifySGBDConnection())
                return;

            string username = login_username.Text;
            string password = login_pass.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Por favor, insira um nome de usuário e senha válidos.");
                return;
            }

            using (SqlCommand cmd = new SqlCommand("verifyDatabaseUserCredentials", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                // Parâmetro de saída
                SqlParameter isValidParam = new SqlParameter("@is_valid", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(isValidParam);

                try
                {
                    cmd.ExecuteNonQuery();
                    bool isValid = (bool)isValidParam.Value;

                    if (isValid)
                    {
                        MessageBox.Show("Login efetuado com sucesso! Olá " + username);
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Credenciais inválidas!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
            
        }
        public static string? CurrentUsername { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button_to_register_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = GetSGBDConnection();

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_user_TextChanged(object sender, EventArgs e)
        {
        }
        private void buttonregister_Click(object sender, EventArgs e)
        {
            Register Registerform = new Register();
            Registerform.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!VerifySGBDConnection())
                return;

            string username = login_username.Text; // Aqui deve ser o nome completo
            string password = login_pass.Text;     // Aqui deve ser a senha

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Por favor, insira um nome de usuário e senha válidos.");
                return;
            }

            using (SqlCommand cmd = new SqlCommand("verifyDatabaseUserCredentials", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                // Parâmetro de saída
                SqlParameter isValidParam = new SqlParameter("@is_valid", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(isValidParam);

                try
                {
                    cmd.ExecuteNonQuery();
                    bool isValid = (bool)isValidParam.Value;

                    if (isValid)
                    {
                        MessageBox.Show("Login efetuado com sucesso! Olá " + username);
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Credenciais inválidas!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
