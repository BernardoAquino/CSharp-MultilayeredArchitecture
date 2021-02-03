namespace ProjetoCamadas3A44
{
    partial class FrmSenha
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
            this.btn_alterar = new System.Windows.Forms.Button();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lbl_novaSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(6, 96);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(211, 23);
            this.btn_alterar.TabIndex = 10;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Location = new System.Drawing.Point(44, 42);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.PasswordChar = '*';
            this.txtSenhaNova.Size = new System.Drawing.Size(173, 20);
            this.txtSenhaNova.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(44, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(3, 45);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(41, 13);
            this.lbl_senha.TabIndex = 7;
            this.lbl_senha.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email:";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(92, 70);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = '*';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(125, 20);
            this.txtConfirmaSenha.TabIndex = 13;
            // 
            // lbl_novaSenha
            // 
            this.lbl_novaSenha.AutoSize = true;
            this.lbl_novaSenha.Location = new System.Drawing.Point(3, 73);
            this.lbl_novaSenha.Name = "lbl_novaSenha";
            this.lbl_novaSenha.Size = new System.Drawing.Size(83, 13);
            this.lbl_novaSenha.TabIndex = 12;
            this.lbl_novaSenha.Text = "Confirma senha:";
            // 
            // FrmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 129);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.lbl_novaSenha);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.label1);
            this.Name = "FrmSenha";
            this.Text = "FrmSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lbl_novaSenha;
    }
}