using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP1.Clases
{
    class CongruencialMixto
    {
        private float semilla;
        private float constante_a;
        private float constante_c;
        private float divisor_m;
        private float x1;

        public CongruencialMixto(int semi, int k, int c, int g)
        {
            // semilla
            this.semilla = semi;
            // constante multiplicativa
            this.constante_a = 3 + (8 * k);
            //constante aditiva
            this.constante_c = c;
            //magnitud del modulo
            this.divisor_m = (float)(Math.Pow(2, g));
            this.x1 = semi;
            //Periodo maximo que se logra si la semilla es un numero impar : N =k/4 = 2*g-2
        }

        public float numero_aleatorio(float numero)
        {
            /* El parametro va a ser la semilla x1, la cual tomara un nuevo valor en una iteracion para ser
             pasada como parametro en la proxima iteracion, asi se estaria trabajando siempre con el valor anterior*/
            this.x1 = (constante_a * numero + constante_c) % divisor_m;
            return (float)(Math.Round((x1 / (divisor_m - 1)),4)); 
            /* retorna el valor aleatorio */
        }

        public List<float> lista_numerica(int cantidad)
        {
            /*Se pasa por parametros la cantidad de numeros aleatorios a generar 
             se returna un objeto del tipo List */

            List<float> lista_numeros = new List<float>();
            for (int i = 0; i < cantidad; i++)
            {
                lista_numeros.Add(numero_aleatorio(x1));
            }
            return lista_numeros;
        }

        public string get_divisor_m ()
        {
            string divisor;
            divisor = this.divisor_m.ToString();
            return divisor;
        }
        public string get_constante_a()
        {
            return this.constante_a.ToString();
        }

        public float get_numerox1() 
        {
            return this.numero_aleatorio(x1); 
        }
    }
}
