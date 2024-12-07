namespace SkySync
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 171);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(201, 318);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(195, 370);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(286, 320);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(345, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(286, 372);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(345, 23);
            txtSenha.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(556, 416);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 32);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(375, 178);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_880_640;
            ClientSize = new Size(864, 601);
            Controls.Add(pictureBox2);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnEntrar;
        private PictureBox pictureBox2;
    }
}
