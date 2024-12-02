using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62___Componentes
{
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_selecionados_Click(object sender, EventArgs e)
        {
            if(cb_transportes.Text == "")
            {
                MessageBox.Show("Selecione um Item");
                return;
            }
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_limparElementos_Click(object sender, EventArgs e)
        {
            // Limpando elementos do ComboBox
            cb_transportes.Items.Clear();
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
            List<string> Elementos = new List<string>();

            Elementos.Add("Carro");
            Elementos.Add("Avião");
            Elementos.Add("Navio");
            Elementos.Add("Ônibus");
            Elementos.Add("Trem");

            cb_transportes.Items.AddRange(Elementos.ToArray());
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Transferindo dados de um ComboBox para o outro
            tb_novoTransporte.Text = cb_transportes.Text;
        }

        private void btn_addNovoTransp_Click(object sender, EventArgs e)
        {
            if (tb_novoTransporte.Text != "")
            {   
                // Verificando se o elemento qual queremos adicionar está ou não na lista
                if (cb_transportes.FindString(tb_novoTransporte.Text) == -1)
                {
                    cb_transportes.Items.Add(tb_novoTransporte.Text);
                    tb_novoTransporte.Clear();
                    cb_transportes.Focus();
                }
                else
                    MessageBox.Show("Item ja existente na lista");
            }
        }
    }
}
