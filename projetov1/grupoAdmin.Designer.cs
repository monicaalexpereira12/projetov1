namespace projetov1
{
    partial class grupoAdmin
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
            close = new Label();
            label8 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            Button_to_Profile = new Button();
            Eventos = new Button();
            button1 = new Button();
            Return = new Button();
            Logout = new Button();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            buttonSalvar = new Button();
            label1 = new Label();
            Box_Escala = new ComboBox();
            label3 = new Label();
            textBoxNovoGrupo = new TextBox();
            buttonEditar = new Button();
            buttonRemover = new Button();
            buttonAdicionar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(1045, 8);
            close.Name = "close";
            close.Size = new Size(17, 17);
            close.TabIndex = 14;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.AppWorkspace;
            label8.Location = new Point(621, 443);
            label8.Name = "label8";
            label8.Size = new Size(52, 12);
            label8.TabIndex = 8;
            label8.Text = "BD 2025";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 73);
            panel1.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(656, 9);
            label4.Name = "label4";
            label4.Size = new Size(18, 18);
            label4.TabIndex = 47;
            label4.Text = "X";
            label4.Click += label4_Click;
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
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(34, 100);
            button1.Name = "button1";
            button1.Size = new Size(100, 87);
            button1.TabIndex = 4;
            button1.Text = "Groups";
            button1.UseVisualStyleBackColor = false;
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
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(Logout);
            panel2.Controls.Add(Return);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Eventos);
            panel2.Controls.Add(Button_to_Profile);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 391);
            panel2.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(193, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(276, 22);
            comboBox1.TabIndex = 42;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonSalvar
            // 
            buttonSalvar.FlatStyle = FlatStyle.System;
            buttonSalvar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalvar.Location = new Point(577, 406);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 43;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 90);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 44;
            label1.Text = "Grupo";
            // 
            // Box_Escala
            // 
            Box_Escala.FormattingEnabled = true;
            Box_Escala.Location = new Point(193, 205);
            Box_Escala.Name = "Box_Escala";
            Box_Escala.Size = new Size(276, 23);
            Box_Escala.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(193, 185);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 46;
            label3.Text = "Escala";
            // 
            // textBoxNovoGrupo
            // 
            textBoxNovoGrupo.Location = new Point(193, 357);
            textBoxNovoGrupo.Name = "textBoxNovoGrupo";
            textBoxNovoGrupo.Size = new Size(428, 23);
            textBoxNovoGrupo.TabIndex = 62;
            // 
            // buttonEditar
            // 
            buttonEditar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditar.Location = new Point(193, 398);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(87, 29);
            buttonEditar.TabIndex = 61;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemover.Location = new Point(402, 398);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(87, 29);
            buttonRemover.TabIndex = 60;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdicionar.Location = new Point(299, 398);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(87, 29);
            buttonAdicionar.TabIndex = 59;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // grupoAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 464);
            Controls.Add(textBoxNovoGrupo);
            Controls.Add(buttonEditar);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Controls.Add(label8);
            Controls.Add(close);
            Controls.Add(label3);
            Controls.Add(Box_Escala);
            Controls.Add(label1);
            Controls.Add(buttonSalvar);
            Controls.Add(comboBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "grupoAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "grupocopy1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label close;
        private Label label8;
        private Panel panel1;
        private Label label2;
        private Button Button_to_Profile;
        private Button Eventos;
        private Button button1;
        private Button Return;
        private Button Logout;
        private Panel panel2;
        private ComboBox comboBox1;
        private Button buttonSalvar;
        private Label label1;
        private ComboBox Box_Escala;
        private Label label3;
        private Label label4;
        private TextBox textBoxNovoGrupo;
        private Button buttonEditar;
        private Button buttonRemover;
        private Button buttonAdicionar;
    }
}