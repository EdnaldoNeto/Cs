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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> Transp = new List<CheckBox>();

        public F_CheckBox()
        {
            InitializeComponent();
            Transp.Add(cb_carro);
            Transp.Add(cb_aviao);
            Transp.Add(cb_navio);
            Transp.Add(cb_onibus);
        }

        private void btn_TransportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";

            // Verificando se as checkbox estão marcadas
            /*if (cb_carro.Checked)
            {
                txt += cb_carro.Text + ", ";
            }

            if (cb_aviao.Checked)
            {
                txt += cb_aviao.Text + ", ";
            }

            if (cb_navio.Checked)
            {
                txt += cb_navio.Text + ", ";
            }

            if (cb_onibus.Checked)
            {
                txt += cb_onibus.Text + ", ";
            }*/

            foreach (CheckBox v in Transp)
            {
                if (v.Checked)
                {
                    txt += v.Text + ", ";
                }
            }

            MessageBox.Show(txt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_filhoCheckBox f_FilhoCheckBox = new F_filhoCheckBox();

            f_FilhoCheckBox.ShowDialog();
        }
    }
}
