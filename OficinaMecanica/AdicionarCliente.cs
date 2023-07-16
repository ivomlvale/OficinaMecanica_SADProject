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
    public partial class AdicionarCliente : Form
    {
        string idTC;

        public AdicionarCliente()
        {
            InitializeComponent();
        }


        private void botaoAdicionarCliente_Click(object sender, EventArgs e)
        {
            CriarCliente();
            MessageBox.Show("Adicionado");
            AdicionarViatura adicionarViatura = new AdicionarViatura();
            this.Hide();
            adicionarViatura.Show();
        }

        private bool CriarCliente()
        {
            bool resultado = false;
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    /*SqlCommand command = new SqlCommand("SELECT COUNT (ClienteID) FROM Cliente", ligacao.Connection);
                    int i = Convert.ToInt32(command.ExecuteScalar());
                    i++;*/

                    DateTime data = this.textoDataNascimento.Value;

                    string sql = "SET IDENTITY_INSERT Cliente ON \n INSERT INTO Cliente (ClienteID, NomeCliente, Morada, DataNascimento, IdadeCliente, Nif, Email, CodigoPostalCP)"
                        + "VALUES" +
                        "('" + this.textoNif.Text + "', '"
                        + this.textoNome.Text + "', '"
                        + this.textoMorada.Text + "', '"
                        + data.ToString("yyyy-MM-dd") + "', '"
                        + this.textoIdade.Text + "', '"
                        + this.textoNif.Text + "', '"
                        + this.textoEmail.Text + "', '"
                        + this.textoCodigoPostal.Text + "')" + "\n SET IDENTITY_INSERT Cliente OFF"
                        + "\n INSERT INTO Contacto (ClienteClienteID, Numero, TipoContactoID)"
                        + "VALUES" + "('" + this.textoNif.Text + "', '" + this.textoContacto.Text + "', '" + idTC + "')";



                    SqlCommand cmd = new SqlCommand(sql, ligacao.Connection);
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

        private void botaoVoltarAdicionarCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.Show();
        }

        private void AdicionarCliente_Load(object sender, EventArgs e)
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
                        comboboxTipoContacto.Items.Add(dataReader["DescTipoContacto"]);
                        comboboxTipoContacto.DisplayMember = (dataReader["DescTipoContacto"].ToString());
                        comboboxTipoContacto.ValueMember = (dataReader["TipoContactoID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
            }
        }

        private void comboboxTipoContacto_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboboxTipoContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT TipoContactoID FROM TipoContacto WHERE DescTipoContacto = '" + comboboxTipoContacto.SelectedItem + "'";

            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    SqlCommand cmd = new SqlCommand(sql, ligacao.Connection);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        idTC = dataReader[0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
            }
        }
    }
}
