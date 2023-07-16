using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void botaoFaturacao_Click(object sender, EventArgs e)
        {
            Indisponivel indisponivel = new Indisponivel();
            this.Hide();
            indisponivel.Show();
        }

        private void botaoClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.Show();
        }

        private void botaoViaturas_Click(object sender, EventArgs e)
        {
            Viaturas viaturas = new Viaturas();
            this.Hide();
            viaturas.Show();
        }

        private void botaoTrabalhos_Click(object sender, EventArgs e)
        {
            Indisponivel indisponivel = new Indisponivel();
            this.Hide();
            indisponivel.Show();
        }

        private void botaoFuncionarios_Click(object sender, EventArgs e)
        {
            Indisponivel indisponivel = new Indisponivel();
            this.Hide();
            indisponivel.Show();
        }
    }
}
