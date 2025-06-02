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
        private SqlConnection connect; // Adiciona o operador null-forgiving
        private new Login Parent;
        public Register()
        {
            InitializeComponent();
            this.Parent = Parent;
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
        private void buttonregister_Click(object sender, EventArgs e)
        {

            string username = reg_username.Text;
            string password = reg_pass.Text;
            string confirmPassword = reg_confpass.Text;

            if ((username.Length == 0 && password.Length == 0))
            //caso os campos estejam vazios
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else if (password != confirmPassword)
            //caso as senhas não coincidam
            {
                MessageBox.Show("As senhas não coincidem. Por favor, tente novamente.");
                return;
            }
            else
            {
                //testar conexão à BD
                if (!VerifySGBDConnection())
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados.");
                    return;
                }

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Exec AddDatabaseUser @username = '" + username + "', @password = '" + password + "'";
                cmd.Parameters.Clear();
                cmd.Connection = connect;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Conta criada com sucesso!");
                    this.Parent.Show(); //abre o login
                    this.Close(); //fecha o registo
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

        private void buttonlogin_Click(object sender, EventArgs e)
        {

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
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = reg_username.Text;
            string password = reg_pass.Text;
            string confirmPassword = reg_confpass.Text;

            if ((username.Length == 0 && password.Length == 0))
            //caso os campos estejam vazios
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else if (password != confirmPassword)
            //caso as senhas não coincidam
            {
                MessageBox.Show("As senhas não coincidem. Por favor, tente novamente.");
                return;
            }
            else
            {
                //testar conexão à BD
                if (!VerifySGBDConnection())
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados.");
                    return;
                }

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "EXEC dbo.AddDatabaseUser @username = '" + username + "', @password = '" + password + "'";
                cmd.Parameters.Clear();
                cmd.Connection = connect;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Conta criada com sucesso!");
                    this.Parent.Show(); //abre o login
                    this.Close(); //fecha o registo
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
