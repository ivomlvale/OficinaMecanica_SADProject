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
    public partial class AtualizarCliente : Form
    {
        public AtualizarCliente()
        {
            InitializeComponent();
        }

        private void AtualizarCliente_Load(object sender, EventArgs e)
        {
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    SqlCommand cmd = new SqlCommand("SELECT TipoContactoID, DescTipoContacto FROM TipoContacto", ligacao.Connection);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        comboboxAtualizaTipoContacto.Items.Add(dataReader["DescTipoContacto"]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textoAtualizaNome_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ProcuraCliente()
        {
            bool resultado = false;
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    string clienteAtualizar = textoAtualizaNif.Text;

                    string sql = "SELECT NomeCliente, Morada, CodigoPostalCP, IdadeCliente, Email, Numero FROM Cliente JOIN Contacto on Cliente.ClienteID=Contacto.CLienteClienteID WHERE Cliente.ClienteID = " + clienteAtualizar + " and Contacto.ClienteClienteID = " + clienteAtualizar + "";
                    SqlCommand cmd = new SqlCommand(sql, ligacao.Connection);
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        dataReader.Read();
                        textoAtualizaNome.Text = dataReader["NomeCliente"].ToString();
                        textoAtualizaMorada.Text = dataReader["Morada"].ToString();
                        textoAtualizaCodigoPostal.Text = dataReader["CodigoPostalCP"].ToString();
                        textoAtualizaIdade.Text = dataReader["IdadeCliente"].ToString();
                        textoAtualizaEmail.Text = dataReader["Email"].ToString();
                        textoAtualizaContacto.Text = dataReader["Numero"].ToString();
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

        private void botaoProcuraCliente_Click(object sender, EventArgs e)
        {
            textoAtualizaNome.Enabled = true;
            textoAtualizaMorada.Enabled = true;
            textoAtualizaCodigoPostal.Enabled = true;
            textoAtualizaIdade.Enabled = true;
            textoAtualizaEmail.Enabled = true;
            textoAtualizaContacto.Enabled = true;
            comboboxAtualizaTipoContacto.Enabled = true;
            botaoAtualizaCliente.Enabled = true;
            ProcuraCliente();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboboxAtualizaTipoContacto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textoAtualizaContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoAtualizaEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoAtualizaIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private bool AtualizaCliente()
        {
            bool resultado = false;
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    string sql = "BEGIN TRANSACTION \nUPDATE Contacto SET Numero = '" + textoAtualizaContacto.Text + "' WHERE Contacto.ClienteClienteID = '" + textoAtualizaNif.Text + "' UPDATE Cliente SET NomeCliente = '" + textoAtualizaNome.Text + "', Morada = '" + textoAtualizaMorada.Text +  "', CodigoPostalCP = '" + textoAtualizaCodigoPostal.Text + "', IdadeCliente = '" + textoAtualizaIdade.Text + "', Email = '" + textoAtualizaEmail.Text + "' WHERE Cliente.ClienteID = '" + textoAtualizaNif.Text + "' COMMIT";

                    SqlCommand cmd = new SqlCommand(sql, ligacao.Connection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.UpdateCommand = ligacao.Connection.CreateCommand();
                    dataAdapter.UpdateCommand.CommandText = sql;

                    if (dataAdapter.UpdateCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cliente Atualizado");
                        resultado = true;
                    }
                        
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
            }
            return resultado;
        }

        private void botaoAtualizaCliente_Click(object sender, EventArgs e)
        {
            AtualizaCliente();
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.Show(); 

        }

        private void botaoVoltarAtualizaCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.Show();
        }
    }
}
