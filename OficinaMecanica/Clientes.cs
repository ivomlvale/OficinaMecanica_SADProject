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
    public partial class Clientes : Form
    {
        private string clienteSelecionado;

        public Clientes()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void botaoAdicionarCliente_Click(object sender, EventArgs e)
        {
            AdicionarCliente adicionarCliente = new AdicionarCliente();
            this.Hide();
            adicionarCliente.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoVoltarClientes_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            LoadListaClientes();
        }

        private bool LoadListaClientes()
        {
            bool resultado = false;
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    string sql = "SELECT Cliente.Nif, Cliente.NomeCliente, Cliente.Morada, Contacto.Numero, Cliente.Email, Cliente.DataNascimento, Cliente.IdadeCliente FROM Cliente JOIN Contacto on Cliente.ClienteID = Contacto.ClienteClienteID ORDER BY Cliente.ClienteID";
                        
                    SqlCommand cmd = new SqlCommand(sql, ligacao.Connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "teste");


                    DataTable dataTable = dataSet.Tables["teste"];
                    int i;
                    for (i = 0; i < dataTable.Rows.Count; i++)
                    {
                        listaClientes.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
                        listaClientes.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                        listaClientes.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[2].ToString());
                        listaClientes.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[3].ToString());
                        listaClientes.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[4].ToString());
                        listaClientes.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[5].ToString());
                        listaClientes.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[6].ToString());
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
        

        private void listaClientes_MouseClick(object sender, MouseEventArgs e)
        {
            idTabela.Text = listaClientes.SelectedItems[0].SubItems[0].Text;
            clienteSelecionado = listaClientes.SelectedItems[0].SubItems[0].Text;
        }

        private void RefreshListaClientes()
        {
            listaClientes.Items.Clear();
            LoadListaClientes();
        }


        private bool EliminaCliente() 
        {
            bool resultado = false;
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    string sql = "DELETE FROM Contacto WHERE ClienteClienteID = " + clienteSelecionado + ";\n DELETE FROM Cliente WHERE ClienteID = " + clienteSelecionado + "";

                    SqlCommand cmd = new SqlCommand(sql, ligacao.Connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.DeleteCommand = ligacao.Connection.CreateCommand();
                    dataAdapter.DeleteCommand.CommandText = sql;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Apagado");
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

        private void botaoApagarCliente_Click(object sender, EventArgs e)
        {
            EliminaCliente();
        }

        private void botaoAtualizarCliente_Click(object sender, EventArgs e)
        {
            AtualizarCliente atualizarCliente = new AtualizarCliente();
            this.Hide();
            atualizarCliente.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Shown(object sender, EventArgs e)
        {

        }
    }
}
