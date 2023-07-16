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
    public partial class Trabalhos : Form
    {
        public Trabalhos()
        {
            InitializeComponent();
        }

        private void botaoVoltarTrabalhos_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void botaoCriaTrabalho_Click(object sender, EventArgs e)
        {
           
        }
    }
}
