using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAutenticacao.Desktop_
{
    public partial class CadastroDeUsuario : Form
    {
        
        public CadastroDeUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroDeUsuario_Load(object sender, EventArgs e)
        {
           txtid.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtCadLogin.Enabled = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtCadConfirmarSenha.Text != txtCadSenha.Text)
            {
                MessageBox.Show("senha incorreta!");
                txtCadSenha.Text = "";
                txtCadConfirmarSenha.Text = "";
                txtCadSenha.Focus();

            }
            else
            {
                TxtCadNivel.Focus();
            }
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            //meu
            //função leave
            //Escrever nome  esobre nome no login
            //txtCadLogin.Text = $"{txtCadNome.Text}.{txtSobrenome.Text}";

            /*txtCadLogin.BackColor = Color.White;
            string[] nome = txtCadNome.Text.Split(' ');
            txtCadLogin.Text = nome[0];*/

            txtCadLogin.Text = txtCadNome.Text;
            txtCadLogin.BackColor = Color.White;
            //Clever
            string[] nome = txtCadNome.Text.Split(' ');
            //txtLogin.Text = nome[0];
            //Yedo
            string substring = "";
            string[] subs = txtCadSobrenome.Text.Split();
            foreach (string sub in subs)
            {
                //  MessageBox.Show($"Substring: {sub}");
                substring = sub;
            }
            //===================
            txtCadLogin.Text = $"{nome[0].ToLower()}.{substring.ToLower()}";


        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged_1(object sender, EventArgs e)
        {
            
            txtCadLogin.BackColor = Color.White;
            string[] nome = txtCadNome.Text.Split(' ');
            txtCadLogin.Text = nome[0];


        }

        private void txtCadNome_Leave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string pass = Convert.ToString(random.Next(1000000));
            txtCadSenha.Text = pass;
            txtCadConfirmarSenha.Text = pass;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtCadConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (txtCadConfirmarSenha.Text != txtCadSenha.Text)
            {
                txtCadSenha.ForeColor = Color.Red;
                txtCadConfirmarSenha.ForeColor = Color.Red;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TelaNível().Show();
        }

        private void TxtCadNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
