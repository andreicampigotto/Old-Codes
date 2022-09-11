using ExemploBD_02.Modelo;
using ExemploBD_02.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBD_02
{
    public partial class ListaHerois : Form
    {
        public ListaHerois()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new Cadastro().ShowDialog();
        }
        private void AtualizarLista()
        {
            string coluna = "Nome";

            if (rbnRaça.Checked)
            {
                coluna = "Raçaa";
            }
            else if (rbnContaBancaria.Checked)
            {
                coluna = "Conta_Bancaria";
            }

            string tipoOrdenacao = "ASC";
            if (rbnDecrescente.Checked)
            {
                tipoOrdenacao = "DESC";
            }
            dataGridView1.Rows.Clear();
            List<Heroi> herois = new HeroiRepositorio().ObterTodos(txtPesquisa.Text, coluna, tipoOrdenacao);
            foreach (Heroi heroi in herois)
            {
                dataGridView1.Rows.Add(new object[]{
                   heroi.Id,
                   heroi.Nome,
                   heroi.Raca,
                   heroi.ContaBancaria

            });
            }
        }
    }
}
