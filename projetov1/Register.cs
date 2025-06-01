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
    public partial class Register : Form
    {
        private SqlConnection connect = null!; // Adiciona o operador null-forgiving
        public Register()
        {
            InitializeComponent();
            connect = GetSGBDConnection();
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

        private void buttonregister_Click(object sender, EventArgs e)
        {
            if (!VerifySGBDConnection())
                return;

            string username = reg_username.Text;
            string password = reg_pass.Text;

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
                    bool isValid = (bool)reader[0];

                    if (isValid)
                    {
                        MessageBox.Show("Registro efetuado com sucesso! Bem vindo " + username);
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

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            Login Loginform = new Login();
            Loginform.Show();
            this.Hide();
        }
        public bool empty_fields()
        {
            if (reg_username.Text == "" || reg_pass.Text == "" || reg_confpass.Text == "")
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
            this.Hide();
        }
    }
}
