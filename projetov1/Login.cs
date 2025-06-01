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
        private SqlConnection connect;
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

            if ((username.Length == 0 && password.Length == 0) || !VerifySGBDConnection())
            {
                return;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("DECLARE @is_valid BIT;EXEC verifyDatabaseUserCredentials '{0}', '{1}', @is_valid OUTPUT;SELECT @is_valid; ", username, password);
            cmd.Connection = connect;  

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bool isValid = (bool)reader[0]; // Assuming @is_valid is the first column returned  

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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.Show();
            this.Hide();
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
    }
}
