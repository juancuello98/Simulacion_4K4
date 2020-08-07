using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulacion_TP1.Clases;

namespace Simulacion_TP1.Interfaz
{
    public partial class Congr_mixto : Form
    {
        //Declara a congruencial con el tipo Congr_Mixto
        CongruencialMixto congruencial;
        public Congr_mixto()
        {
            InitializeComponent();
        }

        /*Este metodo lo que hace es cargar el ListView con la lista de numeros
        generada en la clase CongruencialMixto*/

        private void btn_Ejecutar_mixto_Click(object sender, EventArgs e)
        {
            /*se le asigna a congruencial una instancia de la clase 
            congr_mixto, y se le pasan los parametros para su constructor
            cuyos valores son los que se encuentren en los textBox del formulario
            */
            congruencial = new CongruencialMixto(int.Parse((this.txt_semilla.Text).Trim()),
                                           int.Parse((this.txt_constanteA.Text).Trim()),
                                           int.Parse((this.txt_constanteC.Text).Trim()),
                                           int.Parse((this.txt_divisorM.Text).Trim()));
            this.txt_m.Text = congruencial.get_divisor_m();
            this.txt_a.Text = congruencial.get_constante_a();

            /*Como el constructor espera que se le pasen valores de tipo entero
            los parseamos con el int.Parse , y utilizamos el Trim() para
            poder borrar espacios en blancos que sean ingresados antes o despues
            del valor*/

            //se declara una variable de tipo List y se le asigna una instancia, que va a

            List<float> lista_de_numeros = new List<float>();
            lista_de_numeros = congruencial.lista_numerica(int.Parse((this.txt_cantidad.Text).Trim()));

            /*Se carga el componente List View con los valores uno por uno de la lista*/

            for (int i = 0; i < lista_de_numeros.Count(); i++)
            {
                this.listViewNumeros.Items.Add(lista_de_numeros[i].ToString());
            }
            
        }

        

        private void cmb_Metodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_Metodos.SelectedIndex == 1)
            {
                this.txt_constanteA.Enabled = true;
                this.txt_constanteC.Enabled = true;
                this.txt_divisorM.Enabled = true;
                this.txt_semilla.Enabled = true;
                this.txt_constanteC.Text = "0";
            }
            else if (this.cmb_Metodos.SelectedIndex == 0) 
            {
                this.txt_constanteA.Enabled = true;
                this.txt_constanteC.Enabled = true;
                this.txt_divisorM.Enabled = true;
                this.txt_semilla.Enabled = true;
                this.txt_constanteC.Text = "";
            }
        }

        private void btn_nuevo_mixto_Click(object sender, EventArgs e)
        {
            this.txt_semilla.Text = "";
            this.txt_constanteA.Text = "";
            this.txt_constanteC.Text = "";
            this.txt_divisorM.Text = "";
            this.txt_m.Text = "";
            this.txt_a.Text = "";
            this.txt_semilla.Focus();
            this.listViewNumeros.Clear();
        }

        private void btn_SerieContinua_mixto_Click(object sender, EventArgs e)
        {
            this.listViewNumeros.Items.Add(congruencial.get_numerox1().ToString());
        }
    }
}
