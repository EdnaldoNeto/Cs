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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_transpSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            // Obtendo os elementos selecionados do checklistbox
            foreach (string i in clb_transportes.CheckedItems)
            {
                txt += i + ", ";
            }

            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            // Limpando os itens da lista
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();

            // Adicionando items na lista
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            clb_transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_addNovoTransp_Click(object sender, EventArgs e)
        {
            if (tb_novoTransp.Text != "")
            {
                clb_transportes.Items.Add(tb_novoTransp.Text);
                tb_novoTransp.Clear();
                tb_novoTransp.Focus();
            }
        }
    }
}
