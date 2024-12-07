namespace SkySync
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            lblBemVindo = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            picAgendamentos = new PictureBox();
            picCadastro = new PictureBox();
            picVeiculos = new PictureBox();
            picConsulta = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAgendamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCadastro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVeiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picConsulta).BeginInit();
            SuspendLayout();
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.BackColor = Color.Transparent;
            lblBemVindo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = Color.White;
            lblBemVindo.Location = new Point(112, 22);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(154, 37);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Bem-vindo ";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(566, 22);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // picAgendamentos
            // 
            picAgendamentos.Location = new Point(93, 133);
            picAgendamentos.Margin = new Padding(3, 2, 3, 2);
            picAgendamentos.Name = "picAgendamentos";
            picAgendamentos.Size = new Size(109, 46);
            picAgendamentos.TabIndex = 3;
            picAgendamentos.TabStop = false;
            // 
            // picCadastro
            // 
            picCadastro.BackColor = Color.Transparent;
            picCadastro.BackgroundImage = Properties.Resources.cadastroBranco;
            picCadastro.BackgroundImageLayout = ImageLayout.Zoom;
            picCadastro.Location = new Point(227, 133);
            picCadastro.Margin = new Padding(3, 2, 3, 2);
            picCadastro.Name = "picCadastro";
            picCadastro.Size = new Size(109, 46);
            picCadastro.TabIndex = 4;
            picCadastro.TabStop = false;
            picCadastro.Click += picCadastro_Click_1;
            // 
            // picVeiculos
            // 
            picVeiculos.Location = new Point(486, 133);
            picVeiculos.Margin = new Padding(3, 2, 3, 2);
            picVeiculos.Name = "picVeiculos";
            picVeiculos.Size = new Size(109, 46);
            picVeiculos.TabIndex = 5;
            picVeiculos.TabStop = false;
            picVeiculos.Click += picVeiculos_Click;
            // 
            // picConsulta
            // 
            picConsulta.BackColor = Color.Transparent;
            picConsulta.BackgroundImage = Properties.Resources.consulta;
            picConsulta.BackgroundImageLayout = ImageLayout.Zoom;
            picConsulta.Location = new Point(356, 133);
            picConsulta.Margin = new Padding(3, 2, 3, 2);
            picConsulta.Name = "picConsulta";
            picConsulta.Size = new Size(109, 46);
            picConsulta.TabIndex = 6;
            picConsulta.TabStop = false;
            picConsulta.Click += picConsulta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 189);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 7;
            label1.Text = "Em Desenvolvimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(224, 189);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 8;
            label2.Text = "Cadastro de Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(382, 188);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 9;
            label3.Text = "Consulta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(483, 188);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 10;
            label4.Text = "Em Desenvolvimento";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_880_640;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(673, 436);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picConsulta);
            Controls.Add(picVeiculos);
            Controls.Add(picCadastro);
            Controls.Add(picAgendamentos);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lblBemVindo);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAgendamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCadastro).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVeiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBemVindo;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox picAgendamentos;
        private PictureBox picCadastro;
        private PictureBox picVeiculos;
        private PictureBox picConsulta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}