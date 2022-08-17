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
    public partial class TelaNível : Form
    {
        public TelaNível()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            CarregarResponsabilidades();
        }
        
        private void CarregarResponsabilidades()
        {
            NivelDAO nivelPesquisar = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisar.Pesquisar();


        }


        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
            CarregarResponsabilidades();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Atualizar(txtID.Text, txtNome.Text));
            NivelDAO nivelQuery = new NivelDAO();
            dgvNivel.DataSource = nivelQuery.Pesquisar();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            NivelDAO nivelDAO = new NivelDAO();
            dgvNivel.DataSource = nivelDAO.PesquisarPorNome(txtNome.Text);
            //MessageBox.Show(nivelDAO.PesquisarPorNome("José"));
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Deletar(txtID.Text)); //DELETAR USUARIO
            NivelDAO nivelQuery = new NivelDAO();
            dgvNivel.DataSource = nivelQuery.Pesquisar();
        }

        private void dgvNivel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
