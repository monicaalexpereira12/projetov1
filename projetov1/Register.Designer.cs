namespace projetov1
{
    partial class Register
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
            reg_shpass = new CheckBox();
            reg_pass = new TextBox();
            label5 = new Label();
            reg_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            logoigreja = new PictureBox();
            button1 = new Button();
            close = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            reg_confpass = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoigreja).BeginInit();
            SuspendLayout();
            // 
            // reg_shpass
            // 
            reg_shpass.AutoSize = true;
            reg_shpass.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_shpass.Location = new Point(55, 305);
            reg_shpass.Name = "reg_shpass";
            reg_shpass.Size = new Size(120, 18);
            reg_shpass.TabIndex = 16;
            reg_shpass.Text = "Show Password";
            reg_shpass.UseVisualStyleBackColor = true;
            reg_shpass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // reg_pass
            // 
            reg_pass.Location = new Point(53, 220);
            reg_pass.Name = "reg_pass";
            reg_pass.PasswordChar = '*';
            reg_pass.Size = new Size(266, 23);
            reg_pass.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 200);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 13;
            label5.Text = "Password";
            // 
            // reg_username
            // 
            reg_username.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_username.Location = new Point(55, 165);
            reg_username.Name = "reg_username";
            reg_username.Size = new Size(264, 21);
            reg_username.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 145);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 103);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 11;
            label2.Text = "REGISTER";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(logoigreja);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(close);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(377, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 464);
            panel1.TabIndex = 10;
            // 
            // logoigreja
            // 
            logoigreja.Image = Properties.Resources._720_logo_paroquia_104090608760254f86581d5;
            logoigreja.Location = new Point(41, 75);
            logoigreja.Name = "logoigreja";
            logoigreja.Size = new Size(226, 172);
            logoigreja.SizeMode = PictureBoxSizeMode.Zoom;
            logoigreja.TabIndex = 15;
            logoigreja.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(41, 378);
            button1.Name = "button1";
            button1.Size = new Size(226, 36);
            button1.TabIndex = 14;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(282, 9);
            close.Name = "close";
            close.Size = new Size(17, 17);
            close.TabIndex = 13;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(64, 360);
            label6.Name = "label6";
            label6.Size = new Size(173, 15);
            label6.TabIndex = 11;
            label6.Text = "Already have an account?";
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
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 256);
            label1.Name = "label1";
            label1.Size = new Size(141, 17);
            label1.TabIndex = 18;
            label1.Text = "Confirm password";
            label1.Click += label1_Click;
            // 
            // reg_confpass
            // 
            reg_confpass.Location = new Point(53, 276);
            reg_confpass.Name = "reg_confpass";
            reg_confpass.PasswordChar = '*';
            reg_confpass.Size = new Size(266, 23);
            reg_confpass.TabIndex = 19;
            reg_confpass.TextChanged += textBox3_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.FlatAppearance.BorderColor = Color.LightBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(253, 343);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Padding = new Padding(3);
            button2.Size = new Size(101, 32);
            button2.TabIndex = 20;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 464);
            Controls.Add(button2);
            Controls.Add(reg_confpass);
            Controls.Add(label1);
            Controls.Add(reg_shpass);
            Controls.Add(reg_pass);
            Controls.Add(label5);
            Controls.Add(reg_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoigreja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox reg_shpass;
        private TextBox reg_pass;
        private Label label5;
        private TextBox reg_username;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label6;
        private Label label4;
        private Label label1;
        private TextBox reg_confpass;
        private Label close;
        private Button button1;
        private Button button2;
        private PictureBox logoigreja;
    }
}