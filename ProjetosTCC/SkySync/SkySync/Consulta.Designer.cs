namespace SkySync
{
    partial class Consulta
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
            btnVoltar = new Button();
            btnConsultar = new Button();
            lblConsulta = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(700, 22);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 37;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(235, 161);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(100, 29);
            btnConsultar.TabIndex = 36;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.BackColor = Color.Transparent;
            lblConsulta.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsulta.ForeColor = Color.White;
            lblConsulta.Location = new Point(287, 8);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(220, 37);
            lblConsulta.TabIndex = 35;
            lblConsulta.Text = "Consultar Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 102);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 27;
            label1.Text = "Nome do Cliente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(235, 102);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(340, 23);
            txtNome.TabIndex = 19;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_880_640;
            ClientSize = new Size(800, 227);
            Controls.Add(btnVoltar);
            Controls.Add(btnConsultar);
            Controls.Add(lblConsulta);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "Consulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnConsultar;
        private Label lblConsulta;
        private Label label1;
        private TextBox txtNome;
    }
}