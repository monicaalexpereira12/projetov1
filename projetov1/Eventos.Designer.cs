namespace projetov1
{
    partial class Eventos
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
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label8 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            Logout = new Button();
            Return = new Button();
            button1 = new Button();
            Button_to_Profile = new Button();
            label4 = new Label();
            panel1 = new Panel();
            close = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.AppWorkspace;
            label8.Location = new Point(621, 443);
            label8.Name = "label8";
            label8.Size = new Size(52, 12);
            label8.TabIndex = 47;
            label8.Text = "BD 2025";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(Logout);
            panel2.Controls.Add(Return);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Button_to_Profile);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 391);
            panel2.TabIndex = 48;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderColor = Color.SkyBlue;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            button3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(34, 193);
            button3.Name = "button3";
            button3.Size = new Size(100, 87);
            button3.TabIndex = 50;
            button3.Text = "Events";
            button3.UseVisualStyleBackColor = false;
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
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(34, 100);
            button1.Name = "button1";
            button1.Size = new Size(100, 87);
            button1.TabIndex = 4;
            button1.Text = "Groups";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Button_to_Profile
            // 
            Button_to_Profile.BackColor = Color.White;
            Button_to_Profile.FlatAppearance.BorderColor = Color.SkyBlue;
            Button_to_Profile.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            Button_to_Profile.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_to_Profile.Location = new Point(34, 3);
            Button_to_Profile.Name = "Button_to_Profile";
            Button_to_Profile.Size = new Size(100, 87);
            Button_to_Profile.TabIndex = 3;
            Button_to_Profile.Text = "Profile";
            Button_to_Profile.UseVisualStyleBackColor = false;
            Button_to_Profile.Click += Button_to_Profile_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 73);
            panel1.TabIndex = 49;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(656, 9);
            close.Name = "close";
            close.Size = new Size(18, 18);
            close.TabIndex = 50;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 464);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Eventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eventos";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label8;
        private Panel panel2;
        private Button Logout;
        private Button Return;
        private Button button1;
        private Button Button_to_Profile;
        private Label label4;
        private Panel panel1;
        private Button button3;
        private Label close;
    }
}
