using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBD_01
{
    public partial class Form1 : Form
    {

        private string caminhoConexao = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\i3i\Documents\exemploBD_01.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Conexão com BD
            SqlConnection sqlConnection = new SqlConnection(caminhoConexao);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            
            command.CommandText = "INSERT INTO Cores VALUES (@Cor)";

            string inputCor = txtCor.Text;
            command.Parameters.AddWithValue("@Cor",inputCor);
            command.ExecuteNonQuery();
            sqlConnection.Close();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = caminhoConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand("SELECT Nome FROM Cores;");
            comando.Connection = conexao;

            //Cria em memória uma tabela           
            DataTable dtTable = new DataTable();
            //Executa o caomando e retorna um SQLDataReader
            //Load - Define ao DataTable(tabelas em memória) as colunas
            //e registros (retornados do SELECT)
            dtTable.Load(comando.ExecuteReader());
            
            StringBuilder sb = new StringBuilder();
            //percorre os registros da tabela em memória
            for (int i = 0; i < dtTable.Rows.Count; i++)
            {
                string cor = dtTable.Rows[i][0].ToString();
                sb.AppendLine(cor);
            }
            rtxResultado.Clear();
            rtxResultado.AppendText(sb.ToString());
            conexao.Close();
          
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(caminhoConexao);            
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM Cores WHERE Nome = @Cor";
            string corEscolhida = cbCor.SelectedItem.ToString();
            command.Parameters.AddWithValue("@Cor", corEscolhida);
            command.ExecuteNonQuery();
            cbCor.SelectedIndex = -1;
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbCor_DropDown(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(caminhoConexao);
            conexao.Open();

            SqlCommand command = new SqlCommand("SELECT Nome FROM Cores ORDER BY Nome", conexao);
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            cbCor.Items.Clear();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbCor.Items.Add(table.Rows[i][0].ToString());
            }
            conexao.Close();
        }

        private void cbCorAlterar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCorAlterar.SelectedIndex != -1)
            {
                txtNovoNome.Text = cbCorAlterar.SelectedItem.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(caminhoConexao);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "UPDATE Cores SET Nome = @NovoNome WHERE Nome = @AntigoNome";

            string novoNome = txtNovoNome.Text;
            string antigoNome = cbCorAlterar.SelectedItem.ToString();

            comando.Parameters.AddWithValue("@NovoNome", novoNome);
            comando.Parameters.AddWithValue("@AntigoNome", antigoNome);
            comando.ExecuteNonQuery();

            cbCorAlterar.SelectedIndex = -1;
           
            txtNovoNome.Text = "";
            conexao.Close();
        }

        private void cbCorAlterar_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void cbCorAlterar_DropDown(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(caminhoConexao);
            conexao.Open();

            SqlCommand command = new SqlCommand("SELECT Nome FROM Cores ORDER BY Nome", conexao);
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            cbCorAlterar.Items.Clear();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbCorAlterar.Items.Add(table.Rows[i][0].ToString());
            }
            conexao.Close();
        }
    }
}
