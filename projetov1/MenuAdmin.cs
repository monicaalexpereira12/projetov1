﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetov1
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Grupos_Click(object sender, EventArgs e)
        {
        }


        private void logoigreja_Click(object sender, EventArgs e)
        {

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

        private void profile_Click(object sender, EventArgs e)
        {
            DadosAdmin dadosPessoaform = new DadosAdmin();
            dadosPessoaform.Show();
            this.Hide();
        }

        private void teams_Click(object sender, EventArgs e)
        {
            grupoAdmin gruposForm = new grupoAdmin();
            gruposForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Eventos eventosForm = new Eventos();
            eventosForm.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
