namespace projetov1
{
    partial class Menu
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
            panel1 = new Panel();
            close = new Label();
            label4 = new Label();
            panel2 = new Panel();
            Logout = new Button();
            logoigreja = new PictureBox();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            label3 = new Label();
            profile = new PictureBox();
            teams = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            events = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoigreja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teams).BeginInit();
            ((System.ComponentModel.ISupportInitialize)events).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(close);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 54);
            panel1.TabIndex = 1;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(659, 9);
            close.Name = "close";
            close.Size = new Size(17, 17);
            close.TabIndex = 12;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(232, 444);
            label4.Name = "label4";
            label4.Size = new Size(52, 12);
            label4.TabIndex = 8;
            label4.Text = "BD 2025";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(Logout);
            panel2.Controls.Add(logoigreja);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 410);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // Logout
            // 
            Logout.BackgroundImageLayout = ImageLayout.None;
            Logout.FlatAppearance.BorderSize = 2;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout.ForeColor = SystemColors.ControlLightLight;
            Logout.Location = new Point(51, 299);
            Logout.Name = "Logout";
            Logout.Size = new Size(100, 26);
            Logout.TabIndex = 11;
            Logout.Text = "Log Out";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // logoigreja
            // 
            logoigreja.Image = Properties.Resources._720_logo_paroquia_104090608760254f86581d5;
            logoigreja.Location = new Point(12, 6);
            logoigreja.Name = "logoigreja";
            logoigreja.Size = new Size(170, 133);
            logoigreja.SizeMode = PictureBoxSizeMode.Zoom;
            logoigreja.TabIndex = 9;
            logoigreja.TabStop = false;
            logoigreja.Click += logoigreja_Click;
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
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 72);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 6;
            label1.Text = "Bem Vindo, ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 69);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 7;
            label3.Text = "(username)";
            // 
            // profile
            // 
            profile.Image = Properties.Resources.user_profile_icon_free_vector;
            profile.InitialImage = Properties.Resources.user_profile_icon_free_vector;
            profile.Location = new Point(232, 200);
            profile.Name = "profile";
            profile.Size = new Size(123, 114);
            profile.SizeMode = PictureBoxSizeMode.Zoom;
            profile.TabIndex = 8;
            profile.TabStop = false;
            profile.WaitOnLoad = true;
            profile.Click += profile_Click;
            // 
            // teams
            // 
            teams.Image = Properties.Resources._1000_F_226462576_aXJLcq7m9kkuBebIQO742hGh02vqSoPt;
            teams.Location = new Point(380, 200);
            teams.Name = "teams";
            teams.Size = new Size(123, 114);
            teams.SizeMode = PictureBoxSizeMode.Zoom;
            teams.TabIndex = 9;
            teams.TabStop = false;
            teams.Click += teams_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(261, 317);
            label5.Name = "label5";
            label5.Size = new Size(69, 22);
            label5.TabIndex = 11;
            label5.Text = "Profile";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(409, 317);
            label6.Name = "label6";
            label6.Size = new Size(77, 22);
            label6.TabIndex = 12;
            label6.Text = "Groups";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(558, 317);
            label7.Name = "label7";
            label7.Size = new Size(72, 22);
            label7.TabIndex = 13;
            label7.Text = "Events";
            // 
            // events
            // 
            events.Image = Properties.Resources.istockphoto_1212381977_612x612;
            events.Location = new Point(530, 200);
            events.Name = "events";
            events.Size = new Size(123, 114);
            events.SizeMode = PictureBoxSizeMode.Zoom;
            events.TabIndex = 15;
            events.TabStop = false;
            events.Click += pictureBox1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 464);
            ControlBox = false;
            Controls.Add(events);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(teams);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(profile);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoigreja).EndInit();
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            ((System.ComponentModel.ISupportInitialize)teams).EndInit();
            ((System.ComponentModel.ISupportInitialize)events).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox logoigreja;
        private Button Logout;
        private Label label1;
        private Label label3;
        private PictureBox profile;
        private PictureBox teams;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox events;
    }
}