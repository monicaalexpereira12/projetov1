namespace projetov1
{
    partial class Form1
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
            buttonregister = new Button();
            buttonsignin = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            buttonlogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonregister);
            panel1.Controls.Add(buttonsignin);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(451, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 479);
            panel1.TabIndex = 0;
            // 
            // buttonregister
            // 
            buttonregister.FlatAppearance.BorderColor = Color.SteelBlue;
            buttonregister.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            buttonregister.FlatAppearance.MouseOverBackColor = Color.Silver;
            buttonregister.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonregister.Location = new Point(114, 235);
            buttonregister.Name = "buttonregister";
            buttonregister.Size = new Size(95, 35);
            buttonregister.TabIndex = 10;
            buttonregister.Text = "REGISTER";
            buttonregister.UseVisualStyleBackColor = true;
            // 
            // buttonsignin
            // 
            buttonsignin.FlatAppearance.BorderColor = Color.SteelBlue;
            buttonsignin.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            buttonsignin.FlatAppearance.MouseOverBackColor = Color.Silver;
            buttonsignin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonsignin.Location = new Point(114, 185);
            buttonsignin.Name = "buttonsignin";
            buttonsignin.Size = new Size(95, 32);
            buttonsignin.TabIndex = 9;
            buttonsignin.Text = "SIGN IN";
            buttonsignin.UseVisualStyleBackColor = true;
            buttonsignin.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(244, 455);
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
            // textBox1
            // 
            textBox1.Location = new Point(55, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(55, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 23);
            textBox2.TabIndex = 7;
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(55, 263);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 18);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonlogin
            // 
            buttonlogin.BackColor = Color.LightBlue;
            buttonlogin.FlatAppearance.BorderColor = Color.LightSkyBlue;
            buttonlogin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonlogin.Location = new Point(220, 293);
            buttonlogin.Margin = new Padding(4);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Padding = new Padding(3);
            buttonlogin.Size = new Size(101, 32);
            buttonlogin.TabIndex = 9;
            buttonlogin.Text = "LOG IN";
            buttonlogin.UseVisualStyleBackColor = false;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 478);
            Controls.Add(buttonlogin);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private CheckBox checkBox1;
        private Button buttonlogin;
        private Button buttonregister;
        private Button buttonsignin;
    }
}
