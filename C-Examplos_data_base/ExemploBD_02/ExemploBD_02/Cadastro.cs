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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Heroi heroi = new Heroi();
            heroi.Nome = txtNome.Text;
            heroi.NomePessoa = txtNomePessoa.Text;
            heroi.ContaBancaria = Convert.ToDouble(txtContaBancaria.Text);
            heroi.DataNascimento = dtHeroi.Value;
            heroi.Escuridao = rdbEscuridaoSim.Checked;
            heroi.QtdFilmes = Convert.ToByte(txtQuantidadedeFilmes);
            heroi.Raca = cbRaca.SelectedItem.ToString();
            heroi.Sexo = cb.Checked ? 'm' : 'h';
            heroi.Descricao = rtbDescricao.Text;
            bool cadastrou = new HeroiRepositorio().Inserir(heroi);

            if (cadastrou)
            {
                MessageBox.Show("Registro cadastrado com sucesso");

            }
            else
            {
                MessageBox.Show("Deu ruim, chame os prog.");
            }



        }
    }
}
