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

namespace OficinaMecanica
{
    public partial class Viaturas : Form
    {
        private string viaturaSelecionada;

        public Viaturas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoVoltarViaturas_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void botaoAdicionarViatura_Click(object sender, EventArgs e)
        {
            AdicionarViatura adicionarViatura = new AdicionarViatura();
            this.Hide();
            adicionarViatura.Show();
        }

        private void listaViaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Viaturas_Load(object sender, EventArgs e)
        {
           LoadListaViaturas();
        }

        private bool LoadListaViaturas()
        {
            bool resultado = false;
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    string sql = "SELECT Viatura.ViaturaID, Marca.DescMarca, Modelo.DescModelo, Viatura.Matricula, Viatura.DataMatricula, Cliente.NomeCliente FROM Cliente JOIN Viatura on Cliente.ClienteID = Viatura.ClienteID JOIN Modelo on Viatura.ModeloID = Modelo.ModeloID JOIN Marca on Modelo.MarcaID = Marca.MarcaID ORDER BY Viatura.ViaturaID";
                    


                    SqlCommand cmd = new SqlCommand(sql, ligacao.Connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "teste");
                    

                    DataTable dataTable = dataSet.Tables["teste"];
                    int i;
                    for (i = 0; i < dataTable.Rows.Count; i++)
                    {
                        listaViaturas.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
                        listaViaturas.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                        listaViaturas.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[2].ToString());
                        listaViaturas.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[3].ToString());
                        listaViaturas.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[4].ToString());
                        listaViaturas.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[5].ToString());
                    }


                    if (cmd.ExecuteNonQuery() > 0)
                        resultado = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
            }
            return resultado;
        }

        private void RefreshListaClientes()
        {
            listaViaturas.Items.Clear();
            LoadListaViaturas();
        }

        private bool EliminaViatura()
        {
            bool resultado = false;
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    string sql = "DELETE FROM Viatura WHERE ViaturaID = " + viaturaSelecionada + "";

                    SqlCommand cmd = new SqlCommand(sql, ligacao.Connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.DeleteCommand = ligacao.Connection.CreateCommand();
                    dataAdapter.DeleteCommand.CommandText = sql;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Apagada");
                        resultado = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
            }
            RefreshListaClientes();
            return resultado;
        }

        private void listaViaturas_MouseClick(object sender, MouseEventArgs e)
        {
            idViatura.Text = listaViaturas.SelectedItems[0].SubItems[3].Text;
            viaturaSelecionada = listaViaturas.SelectedItems[0].SubItems[0].Text;
        }

        private void botaoRemoverViatura_Click(object sender, EventArgs e)
        {
            EliminaViatura();
        }
    }
}
