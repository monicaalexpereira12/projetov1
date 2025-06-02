namespace projetov1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            close = new Label();
            label6 = new Label();
            login_buttonregister = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_pass = new TextBox();
            label5 = new Label();
            login_shpass = new CheckBox();
            login_buttonlogin = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            logoigreja = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoigreja).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(logoigreja);
            panel1.Controls.Add(close);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(login_buttonregister);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(377, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 464);
            panel1.TabIndex = 0;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(282, 9);
            close.Name = "close";
            close.Size = new Size(14, 13);
            close.TabIndex = 12;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(91, 360);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 11;
            label6.Text = "Create an account";
            // 
            // login_buttonregister
            // 
            login_buttonregister.BackColor = Color.SteelBlue;
            login_buttonregister.FlatAppearance.BorderColor = Color.SteelBlue;
            login_buttonregister.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            login_buttonregister.FlatAppearance.MouseOverBackColor = Color.Silver;
            login_buttonregister.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_buttonregister.ForeColor = SystemColors.ButtonHighlight;
            login_buttonregister.Location = new Point(41, 378);
            login_buttonregister.Name = "login_buttonregister";
            login_buttonregister.Size = new Size(226, 36);
            login_buttonregister.TabIndex = 10;
            login_buttonregister.Text = "REGISTER";
            login_buttonregister.UseVisualStyleBackColor = false;
            login_buttonregister.Click += buttonregister_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(726, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 18);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 103);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 2;
            label2.Text = "SIGN IN";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 145);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 3;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // login_username
            // 
            login_username.AcceptsTab = true;
            login_username.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(55, 165);
            login_username.Name = "login_username";
            login_username.Size = new Size(266, 21);
            login_username.TabIndex = 7;
            login_username.TextChanged += login_user_TextChanged;
            // 
            // login_pass
            // 
            login_pass.Location = new Point(55, 234);
            login_pass.Name = "login_pass";
            login_pass.PasswordChar = '*';
            login_pass.Size = new Size(266, 23);
            login_pass.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 214);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 6;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // login_shpass
            // 
            login_shpass.AutoSize = true;
            login_shpass.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_shpass.Location = new Point(55, 263);
            login_shpass.Name = "login_shpass";
            login_shpass.Size = new Size(120, 18);
            login_shpass.TabIndex = 8;
            login_shpass.Text = "Show Password";
            login_shpass.UseVisualStyleBackColor = true;
            // 
            // login_buttonlogin
            // 
            login_buttonlogin.BackColor = Color.LightBlue;
            login_buttonlogin.FlatAppearance.BorderColor = Color.LightBlue;
            login_buttonlogin.FlatStyle = FlatStyle.Flat;
            login_buttonlogin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_buttonlogin.ForeColor = SystemColors.ControlText;
            login_buttonlogin.Location = new Point(220, 307);
            login_buttonlogin.Margin = new Padding(4);
            login_buttonlogin.Name = "login_buttonlogin";
            login_buttonlogin.Padding = new Padding(3);
            login_buttonlogin.Size = new Size(101, 32);
            login_buttonlogin.TabIndex = 9;
            login_buttonlogin.Text = "LOG IN";
            login_buttonlogin.UseVisualStyleBackColor = false;
            login_buttonlogin.Click += buttonlogin_Click;
            // 
            // logoigreja
            // 
            logoigreja.Image = Properties.Resources._720_logo_paroquia_104090608760254f86581d5;
            logoigreja.Location = new Point(41, 75);
            logoigreja.Name = "logoigreja";
            logoigreja.Size = new Size(226, 172);
            logoigreja.SizeMode = PictureBoxSizeMode.Zoom;
            logoigreja.TabIndex = 13;
            logoigreja.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 464);
            Controls.Add(login_buttonlogin);
            Controls.Add(login_shpass);
            Controls.Add(login_pass);
            Controls.Add(label5);
            Controls.Add(login_username);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoigreja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox login_pass;
        private Label label5;
        private Label label4;
        private CheckBox login_shpass;
        private Button login_buttonlogin;
        private Button login_buttonregister;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label close;
        private PictureBox logoigreja;
    }
}
