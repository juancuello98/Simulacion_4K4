using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulacion_TP1.Interfaz;

namespace Simulacion_TP1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dicsysADataSet.InsumoBis' table. You can move, or remove it, as needed.
            this.insumoBisTableAdapter.Fill(this.dicsysADataSet.InsumoBis);

        }

        private void btn_congruencialMixto_Click(object sender, EventArgs e)
        {
            Congr_mixto frm = new Congr_mixto();
            frm.Show();
        }

        private void btn_congruencialMultiplicativo_Click(object sender, EventArgs e)
        {
            Congr_multiplicativo frm = new Congr_multiplicativo();
            frm.Show();
        }
    }
}
