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
    public partial class AdicionarViatura : Form
    {
        string idMarca, idModelo, idMarca2, idModelo2;

        public AdicionarViatura()
        {
            InitializeComponent();
        }


        private void botaoVoltarViaturas_Click(object sender, EventArgs e)
        {
            Viaturas viaturas = new Viaturas();
            this.Hide();
            viaturas.Show();
        }

        private bool CriarViatura()
        {
            bool resultado = false;
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    SqlCommand command = new SqlCommand("SELECT COUNT (ViaturaID) FROM Viatura", ligacao.Connection);
                    int i = Convert.ToInt32(command.ExecuteScalar());
                    i++;


                    DateTime data = this.textoDataMatricula.Value;

                    string sql = "SET IDENTITY_INSERT Viatura ON \n INSERT INTO Viatura (ViaturaID, Matricula, DataMatricula, NumeroChassi, ClienteID, ModeloID)"
                        + "VALUES" +
                        "('" + i + "', '"
                        + this.textoMatricula.Text + "', '"
                        + data.ToString("yyyy-MM-dd") + "', '"
                        + this.textoNumeroChassi.Text + "', '"
                        + this.textoViaturaCliente.Text + "', '"
                        + idModelo + "')" + "\n SET IDENTITY_INSERT Viatura OFF";

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

        private bool CriarViatura2()
        {
            bool resultado = false;
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    SqlCommand command = new SqlCommand("SELECT COUNT (ViaturaID) FROM Viatura", ligacao.Connection);
                    int i = Convert.ToInt32(command.ExecuteScalar());
                    i++;


                    DateTime data = this.textoDataMatricula2.Value;

                    string sql = "SET IDENTITY_INSERT Viatura ON \n INSERT INTO Viatura (ViaturaID, Matricula, DataMatricula, NumeroChassi, ClienteID, ModeloID)"
                        + "VALUES" +
                        "('" + i + "', '"
                        + this.textoMatricula2.Text + "', '"
                        + data.ToString("yyyy-MM-dd") + "', '"
                        + this.textoNumeroChassi2.Text + "', '"
                        + this.textoViaturaCliente2.Text + "', '"
                        + idModelo2 + "')" + "\n SET IDENTITY_INSERT Viatura OFF";


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


        private void botaoAdicionar2_Click(object sender, EventArgs e)
        {
            labelMatricula.Visible = true; textoMatricula2.Visible = true;
            labelChassi.Visible = true; textoNumeroChassi2.Visible = true;
            labelMarca.Visible = true; comboboxMarca2.Visible = true;
            labelModelo.Visible = true; comboboxModelo2.Visible = true;
            labelDataMatricula.Visible = true; textoDataMatricula2.Visible = true;
            labelCliente.Visible = true; textoViaturaCliente2.Visible = true;
            botaoAdicionar2.Visible = false;
            botaoRemover2.Visible = true;
        }

        private void comboboxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxModelo.Items.Clear();
           
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    //uso de STORED PROCEDURE
                    string sql = "EXEC dbo.SPCBOption '" + comboboxMarca.Text + "'";
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    SqlCommand cmd = new SqlCommand(sql, ligacao.Connection);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        comboboxModelo.Items.Add(dataReader["DescModelo"].ToString());
                        idMarca = dataReader[0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
            }
        }

        private void comboboxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uso de STORED PROCEDURE
            string sql = "EXEC dbo.SPCBOption2'" + comboboxModelo.SelectedItem + "'";

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
                        idModelo = dataReader[0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
            }
        }

        private void comboboxMarca2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxModelo2.Items.Clear();

            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    //uso de STORED PROCEDURE
                    string sql = "EXEC dbo.SPCBOption '" + comboboxMarca2.Text + "'";
                    Console.WriteLine("Connecting to SQL OficinaMecanica");

                    SqlCommand cmd = new SqlCommand(sql, ligacao.Connection);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        comboboxModelo2.Items.Add(dataReader["DescModelo"].ToString());
                        idMarca2 = dataReader[0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
            }
        }

        private void comboboxModelo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uso de STORED PROCEDURE
            string sql = "EXEC dbo.SPCBOption2'" + comboboxModelo2.SelectedItem + "'";

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
                        idModelo2 = dataReader[0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
            }
        }

        private void comboboxMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {   

        }

        

        private void botaoCriaViaturas_Click(object sender, EventArgs e)
        {
            //Possibilidade de criar uma ou duas viaturas
            CriarViatura();
            if (botaoRemover2.Visible == true)
            {
                CriarViatura2();
            }
            MessageBox.Show("Adicionado");
            Viaturas viaturas = new Viaturas();
            this.Hide();
            viaturas.Show();
        }

        private void AdicionarViatura_Load(object sender, EventArgs e)
        {
            
            LigacaoBaseDados ligacao = LigacaoBaseDados.Instance();
            if (ligacao.isConnected())
            {
                try
                {
                    Console.WriteLine("Connecting to SQL OficinaMecanica");
                    
                    //uso de STORED PROCEDURE
                    SqlCommand cmd = new SqlCommand("exec SPCBMarca", ligacao.Connection);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        comboboxMarca.Items.Add(dataReader["DescMarca"]);
                        comboboxMarca.DisplayMember = (dataReader["DescMarca"].ToString());
                        comboboxMarca.ValueMember = (dataReader["MarcaID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ligacao.Close();
                    LigacaoBaseDados ligacao2 = LigacaoBaseDados.Instance();
                    if (ligacao2.isConnected())
                    {
                        try
                        {
                            Console.WriteLine("Connecting to SQL OficinaMecanica");
                            //uso de STORED PROCEDURE
                            SqlCommand cmd2 = new SqlCommand("exec SPCBMarca", ligacao.Connection);
                            SqlDataReader dataReader2 = cmd2.ExecuteReader();
                            while (dataReader2.Read())
                            {
                                comboboxMarca2.Items.Add(dataReader2["DescMarca"]);
                                comboboxMarca2.DisplayMember = (dataReader2["DescMarca"].ToString());
                                comboboxMarca2.ValueMember = (dataReader2["MarcaID"].ToString());
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

        private void botaoRemover2_Click(object sender, EventArgs e)
        {
            labelMatricula.Visible = false; textoMatricula2.Visible = false;
            labelChassi.Visible = false; textoNumeroChassi2.Visible = false;
            labelMarca.Visible = false; comboboxMarca2.Visible = false;
            labelModelo.Visible = false; comboboxModelo2.Visible = false;
            labelDataMatricula.Visible = false; textoDataMatricula2.Visible = false;
            labelCliente.Visible = false; textoViaturaCliente2.Visible = false;
            botaoAdicionar2.Visible = true;
            botaoRemover2.Visible = false;
        }
    }
}
