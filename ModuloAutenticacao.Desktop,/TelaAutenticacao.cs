using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloAutenticacao.Classes;

namespace ModuloAutenticacao.Desktop_
{
    public partial class TelaAutenticacao : Form
    {
        public TelaAutenticacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaAutenticacao_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Objeto é uma instância (elemento) da classe
            /*
             * QuaTurmaTop aluno1 = new QuaTurmaTop();
             *
             * 1-Coloque o nome da classe
             * 2-Defina o objeto
             * 3-Sinal de "="
             * 4-Operador New
             * 5-Chamada ao construtor
             *
             *
             */
            /*Aluno1.Nome = "José"
              Aluno2.Telefone = "994284424"*/
            
            Usuario usuario = new Usuario();
            usuario.login = txtLogin.Text;
            usuario.senha = txtSenha.Text;
            //MessageBox.Show($"Seja Bem Vindo {usuario.login}!");

            if (usuario.login.Equals("") || usuario.senha.Equals(""))
            {
                MessageBox.Show("Login e Senha obrigatórios!");
                txtLogin.Focus();            
            }
            else if (usuario.login.Equals("senai") && usuario.senha.Equals("123"))
            {

                MessageBox.Show("Seja Bem Vindo!");
                new CadastroDeUsuario().Show();

            }          
            else
            {
                MessageBox.Show($"Você não é Bem-Vindo");
            }
            






        }
    }
}
