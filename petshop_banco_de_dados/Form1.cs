using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace petshop_banco_de_dados
{
    public partial class petshop : Form
    {
        public petshop()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "petshop";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void limpar()
        {
            tbId.Clear();
            tbCliente.Clear();
            tbCpf.Clear();
            tbEspecie.Clear();
            tbPet.Clear();
            tbCep.Clear();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM cliente";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgPetshop.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgPetshop.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME DO CLIENTE
                    row.Cells[2].Value = reader.GetString(2);//CPF
                    row.Cells[3].Value = reader.GetString(3);//ESPECIE
                    row.Cells[4].Value = reader.GetString(4);//NOME DO PET
                    row.Cells[5].Value = reader.GetString(5);//CEP
                    dgPetshop.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO cliente (nomeCliente,cpfCliente,especiepetCliente,nomepetCliente, cepCliente) " +
                    "VALUES('" + tbCliente.Text + "', '" + tbCpf.Text + "','" + tbEspecie.Text + "', '" + tbPet.Text + "', '" + tbCep.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                limpar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        

        private void btDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM filme WHERE idFilme = "+ textBoxId.Text +""
                //comandoMySql.CommandText = "DELETE FROM filme WHERE idFilme = " + tbID.Text + "";
                comandoMySql.CommandText = "UPDATE cliente SET ativoCliente = 0 WHERE idCliente = " + tbId.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limpar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dgPetshop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPetshop.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgPetshop.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbCliente.Text = dgPetshop.Rows[e.RowIndex].Cells["colCliente"].FormattedValue.ToString();
                tbCpf.Text = dgPetshop.Rows[e.RowIndex].Cells["colCpf"].FormattedValue.ToString();
                tbEspecie.Text = dgPetshop.Rows[e.RowIndex].Cells["colEspecie"].FormattedValue.ToString();
                tbPet.Text = dgPetshop.Rows[e.RowIndex].Cells["colPet"].FormattedValue.ToString();
                tbCep.Text = dgPetshop.Rows[e.RowIndex].Cells["colCep"].FormattedValue.ToString();
            }
        }

        private void btalterar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE cliente SET nomeCliente = '" + tbCliente.Text + "', " +
                    "cpfCliente = '" + tbCpf.Text + "', " +
                    "especiepetCliente = '" + tbEspecie.Text + "', " +
                    "nomepetCliente = '" + tbPet.Text + "', " +
                    "cepCliente = '" + tbCep.Text + "', " +
                    " WHERE idCliente = " + tbId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limpar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
