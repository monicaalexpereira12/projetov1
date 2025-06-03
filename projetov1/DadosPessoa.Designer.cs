namespace projetov1
{
    partial class DadosPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            Logout = new Button();
            Return = new Button();
            Grupos = new Button();
            Eventos = new Button();
            Button_to_Profile = new Button();
            label2 = new Label();
            imageList1 = new ImageList(components);
            close = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            textBoxMorada = new TextBox();
            textBoxDataNascimento = new TextBox();
            textBoxTelefone = new TextBox();
            alterardados = new Button();
            buttonSalvar = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(Logout);
            panel2.Controls.Add(Return);
            panel2.Controls.Add(Grupos);
            panel2.Controls.Add(Eventos);
            panel2.Controls.Add(Button_to_Profile);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 391);
            panel2.TabIndex = 4;
            // 
            // Logout
            // 
            Logout.BackgroundImageLayout = ImageLayout.None;
            Logout.FlatAppearance.BorderSize = 2;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout.ForeColor = SystemColors.ControlLightLight;
            Logout.Location = new Point(34, 333);
            Logout.Name = "Logout";
            Logout.Size = new Size(100, 26);
            Logout.TabIndex = 10;
            Logout.Text = "Log Out";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // Return
            // 
            Return.BackgroundImageLayout = ImageLayout.None;
            Return.FlatAppearance.BorderSize = 2;
            Return.FlatStyle = FlatStyle.Flat;
            Return.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Return.ForeColor = SystemColors.ControlLightLight;
            Return.Location = new Point(34, 301);
            Return.Name = "Return";
            Return.Size = new Size(100, 26);
            Return.TabIndex = 9;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = true;
            Return.Click += Return_Click;
            // 
            // Grupos
            // 
            Grupos.FlatAppearance.BorderColor = Color.DarkGray;
            Grupos.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            Grupos.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Grupos.Location = new Point(34, 100);
            Grupos.Name = "Grupos";
            Grupos.Size = new Size(100, 87);
            Grupos.TabIndex = 4;
            Grupos.Text = "Teams";
            Grupos.UseVisualStyleBackColor = true;
            Grupos.Click += Grupos_Click;
            // 
            // Eventos
            // 
            Eventos.FlatAppearance.BorderColor = Color.DarkGray;
            Eventos.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            Eventos.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Eventos.Location = new Point(34, 193);
            Eventos.Name = "Eventos";
            Eventos.Size = new Size(100, 87);
            Eventos.TabIndex = 5;
            Eventos.Text = "Events";
            Eventos.UseVisualStyleBackColor = true;
            Eventos.Click += Eventos_Click;
            // 
            // Button_to_Profile
            // 
            Button_to_Profile.BackColor = Color.SteelBlue;
            Button_to_Profile.FlatAppearance.BorderColor = Color.SkyBlue;
            Button_to_Profile.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            Button_to_Profile.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_to_Profile.ForeColor = SystemColors.ButtonFace;
            Button_to_Profile.Location = new Point(34, 3);
            Button_to_Profile.Name = "Button_to_Profile";
            Button_to_Profile.Size = new Size(100, 87);
            Button_to_Profile.TabIndex = 3;
            Button_to_Profile.Text = "Profile";
            Button_to_Profile.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(232, 444);
            label2.Name = "label2";
            label2.Size = new Size(52, 12);
            label2.TabIndex = 8;
            label2.Text = "BD 2025";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(656, 9);
            close.Name = "close";
            close.Size = new Size(17, 17);
            close.TabIndex = 14;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 167);
            label1.Name = "label1";
            label1.Size = new Size(45, 14);
            label1.TabIndex = 20;
            label1.Text = "Name:";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 209);
            label3.Name = "label3";
            label3.Size = new Size(43, 14);
            label3.TabIndex = 21;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(184, 258);
            label4.Name = "label4";
            label4.Size = new Size(62, 14);
            label4.TabIndex = 22;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(184, 309);
            label5.Name = "label5";
            label5.Size = new Size(65, 14);
            label5.TabIndex = 23;
            label5.Text = "Birthdate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(184, 356);
            label6.Name = "label6";
            label6.Size = new Size(97, 14);
            label6.TabIndex = 24;
            label6.Text = "Phone Number:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 73);
            panel1.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.AppWorkspace;
            label8.Location = new Point(232, 444);
            label8.Name = "label8";
            label8.Size = new Size(52, 12);
            label8.TabIndex = 8;
            label8.Text = "BD 2025";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_profile_icon_free_vector;
            pictureBox1.Location = new Point(534, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(184, 130);
            label7.Name = "label7";
            label7.Size = new Size(103, 18);
            label7.TabIndex = 27;
            label7.Text = "O seu perfil:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(235, 163);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.ReadOnly = true;
            textBoxNome.Size = new Size(272, 23);
            textBoxNome.TabIndex = 28;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(235, 205);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(272, 23);
            textBoxEmail.TabIndex = 29;
            // 
            // textBoxMorada
            // 
            textBoxMorada.Location = new Point(252, 254);
            textBoxMorada.Name = "textBoxMorada";
            textBoxMorada.ReadOnly = true;
            textBoxMorada.Size = new Size(255, 23);
            textBoxMorada.TabIndex = 30;
            // 
            // textBoxDataNascimento
            // 
            textBoxDataNascimento.Location = new Point(255, 305);
            textBoxDataNascimento.Name = "textBoxDataNascimento";
            textBoxDataNascimento.ReadOnly = true;
            textBoxDataNascimento.Size = new Size(136, 23);
            textBoxDataNascimento.TabIndex = 31;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(287, 352);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.ReadOnly = true;
            textBoxTelefone.Size = new Size(147, 23);
            textBoxTelefone.TabIndex = 32;
            // 
            // alterardados
            // 
            alterardados.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            alterardados.Location = new Point(575, 409);
            alterardados.Name = "alterardados";
            alterardados.Size = new Size(87, 29);
            alterardados.TabIndex = 33;
            alterardados.Text = "Alterar";
            alterardados.UseVisualStyleBackColor = true;
            alterardados.Click += alterardados_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalvar.Location = new Point(472, 409);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(87, 29);
            buttonSalvar.TabIndex = 34;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Visible = false;
            buttonSalvar.Click += Salvar_Click;
            // 
            // DadosPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 464);
            Controls.Add(buttonSalvar);
            Controls.Add(alterardados);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxDataNascimento);
            Controls.Add(textBoxMorada);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DadosPessoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DadosPessoa";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button Grupos;
        private Button Eventos;
        private Button Button_to_Profile;
        private Label label2;
        private ImageList imageList1;
        private Button Return;
        private Button Logout;
        private Label close;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private TextBox textBoxMorada;
        private TextBox textBoxDataNascimento;
        private TextBox textBoxTelefone;
        private Button alterardados;
        private Button buttonSalvar;
    }
}