using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula60
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_texto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            // Atribuido o valor da caixa de texto para o label
            lb_texto.Text = tb_texto.Text;
        }
        
        private void lb_texto_Click(object sender, EventArgs e)
        {

        }
    }
}
