namespace dr.juliana.solucoes
{
    partial class FrmLogin
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
            linhaSup = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            lblUsuario = new Label();
            lblSenha = new Label();
            lblTitulo = new Label();
            btnClosed = new Label();
            SuspendLayout();
            // 
            // linhaSup
            // 
            linhaSup.Dock = DockStyle.Top;
            linhaSup.Location = new Point(0, 0);
            linhaSup.Name = "linhaSup";
            linhaSup.Size = new Size(601, 25);
            linhaSup.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(35, 163);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(254, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(35, 230);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(254, 23);
            txtSenha.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(35, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(254, 25);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(35, 135);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(254, 25);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.BackColor = Color.Transparent;
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(35, 202);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(254, 25);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha:";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(34, 79);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(255, 33);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "DR. JULIANA SOLUÇÔES";
            // 
            // btnClosed
            // 
            btnClosed.BackColor = SystemColors.Control;
            btnClosed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClosed.ForeColor = SystemColors.ControlDarkDark;
            btnClosed.Location = new Point(576, 0);
            btnClosed.Name = "btnClosed";
            btnClosed.Size = new Size(25, 25);
            btnClosed.TabIndex = 8;
            btnClosed.Text = "X";
            btnClosed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bkgMedicinaTecnologia2;
            ClientSize = new Size(601, 357);
            Controls.Add(btnClosed);
            Controls.Add(lblTitulo);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(linhaSup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label linhaSup;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
        private Label lblUsuario;
        private Label lblSenha;
        private Label lblTitulo;
        private Label btnClosed;
    }
}
