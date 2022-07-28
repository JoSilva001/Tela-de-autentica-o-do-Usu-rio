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

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            txtCadLogin.Text = $"{txtCadNome.Text}.{txtSobrenome.Text}";
     
            //txtCadLogin.BackColor = Color.Red;
            
                
            //txtCadLogin.Text = textBox1.Text + "." + textBox2.Text;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}
