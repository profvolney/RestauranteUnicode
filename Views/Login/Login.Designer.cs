using RestauranteUnicode.Models.CustomControls;

namespace RestauranteUnicode
{
    partial class RestauranteUnicode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestauranteUnicode));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            textBoxCustom2 = new TextBoxCustom();
            textBoxCustom1 = new TextBoxCustom();
            btnCadastrar = new ButtonCustom();
            btnLogin = new ButtonCustom();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Tomato;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 44);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 192, 128);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(329, 36);
            label1.TabIndex = 0;
            label1.Text = "UNICODE Restaurante";
            // 
            // panel3
            // 
            panel3.Location = new Point(338, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 41);
            panel3.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(734, 3);
            button1.Name = "button1";
            button1.Size = new Size(56, 41);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 456);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(textBoxCustom2);
            panel2.Controls.Add(textBoxCustom1);
            panel2.Controls.Add(btnCadastrar);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 456);
            panel2.TabIndex = 2;
            // 
            // textBoxCustom2
            // 
            textBoxCustom2.Location = new Point(172, 240);
            textBoxCustom2.Name = "textBoxCustom2";
            textBoxCustom2.Padding = new Padding(7);
            textBoxCustom2.Size = new Size(250, 30);
            textBoxCustom2.TabIndex = 18;
            // 
            // textBoxCustom1
            // 
            textBoxCustom1.Location = new Point(172, 140);
            textBoxCustom1.Name = "textBoxCustom1";
            textBoxCustom1.Padding = new Padding(7);
            textBoxCustom1.Size = new Size(250, 30);
            textBoxCustom1.TabIndex = 17;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Tomato;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(172, 370);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(250, 40);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastre-se";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            btnCadastrar.KeyDown += btnCadastrar_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Tomato;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(172, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 40);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.KeyDown += btnLogin_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(234, 18);
            label4.Name = "label4";
            label4.Size = new Size(103, 38);
            label4.TabIndex = 10;
            label4.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(172, 188);
            label3.Name = "label3";
            label3.Size = new Size(78, 27);
            label3.TabIndex = 9;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 89);
            label2.Name = "label2";
            label2.Size = new Size(78, 27);
            label2.TabIndex = 8;
            label2.Text = "E-mail";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(276, 425);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Esqueceu a senha?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // RestauranteUnicode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 500);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "RestauranteUnicode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UnicodeFormStart";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Button button1;
        private Label label4;
        private TextBoxCustom txtSenha;
        private TextBoxCustom txtEmail;
        private ButtonCustom btnLogin;
        private ButtonCustom btnCadastrar;
        private TextBoxCustom textBoxCustom2;
        private TextBoxCustom textBoxCustom1;
    }
}
