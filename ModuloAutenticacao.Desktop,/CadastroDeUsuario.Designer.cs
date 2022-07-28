namespace ModuloAutenticacao.Desktop_
{
    partial class CadastroDeUsuario
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
            this.components = new System.ComponentModel.Container();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.txtCadLogin = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lbld = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCadNome
            // 
            this.txtCadNome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCadNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCadNome.Location = new System.Drawing.Point(56, 122);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(367, 20);
            this.txtCadNome.TabIndex = 2;
            this.txtCadNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCadLogin
            // 
            this.txtCadLogin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCadLogin.Enabled = false;
            this.txtCadLogin.Location = new System.Drawing.Point(56, 200);
            this.txtCadLogin.Name = "txtCadLogin";
            this.txtCadLogin.Size = new System.Drawing.Size(367, 20);
            this.txtCadLogin.TabIndex = 4;
            this.txtCadLogin.Text = "\r\n";
            this.txtCadLogin.UseWaitCursor = true;
            this.txtCadLogin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(55, 106);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(55, 145);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 8;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(57, 184);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCadastrar.Location = new System.Drawing.Point(118, 343);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(195, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSobrenome.Location = new System.Drawing.Point(56, 161);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(367, 20);
            this.txtSobrenome.TabIndex = 11;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.txtSobrenome_TextChanged_1);
            this.txtSobrenome.Leave += new System.EventHandler(this.txtSobrenome_TextChanged);
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(55, 67);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(18, 13);
            this.lbld.TabIndex = 12;
            this.lbld.Text = "ID";
            this.lbld.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtid.Location = new System.Drawing.Point(56, 83);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(367, 20);
            this.txtid.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(365, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nível";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Confirmar Senha";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(56, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(58, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(365, 20);
            this.textBox2.TabIndex = 21;
            // 
            // CadastroDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(476, 378);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCadLogin);
            this.Controls.Add(this.txtCadNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroDeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroDeUsuario";
            this.Load += new System.EventHandler(this.CadastroDeUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.TextBox txtCadLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}