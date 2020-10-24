using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5_v2
{
    class Fila
    {

        public int cantLlegadas = 0;
        public string evento;
        public float reloj;

        //Evento llegada Pedido
        public double rndLlegadaPedido;
        public double tiempoLlegadaPedido;
        public double proximaLlegadaPedidoo;

        public int mediaLlegadaPedido;


        //TipoPedido
        public double rndTipoPedido;
        public string tipoPedidoPedido;
       


        //Evento Preparacion Pedido
        public double rndPreparacionPedido;
        public double tiempoPreparacionPedido;
        public double proximaFinPreparacionPedidoE1;
        public double proximaFinPreparacionPedidoE2;
        public double proximaFinPreparacionPedidoE3;

        //ENTREGA
        public double rndEntregaPedido;
        public double tiempoEntregaPedido;
        public double proximaFinEntregaPedido;

        //Colas

        public Queue<Pedido> colaLlegadaPedido;
        public Queue<Pedido> colaEntregaPedido;
      

        //Objetos permanentes
        public string estadoEmpleado1;
        public string estadoEmpleado2;
        public string estadoEmpleado3;
       
        public Pedido enPreparacionE1;
        
        public Pedido enPreparacionE2;
        public Pedido enPreparacionE3;
        
        public string estadoEmpleadoDelivery;
        public Pedido enDelivery;

        public Tuple<Pedido> EnPreparacion;

        public Pedido EnColaLlegadaPedido;

        public Pedido EnColaDelivery;




        public int limiteA_Prep_Pizza ;

        public int limiteB_Prep_Pizza;

        public int mediaPrepSandwichNormal ;
        public int desvPrepSandwichNormal;


        public int mediaTiempoEntrega ;

        public float costo_pizza ;

        public float costo_sandwich ;
        public float costo_empanadas ;
        public float costo_hamburguesa;
        public float costo_lomito;



        public Fila(int mediaLlegadaPedido, int limiteA_Prep_Pizza, int limiteB_Prep_Pizza, int mediaPrepSandwichNormal,int desvPrepSandwichNormal, int mediaTiempoEntrega , string evento, float reloj, double rndLlegadaPedido, float rndTipoPedido, float rndPreparacionPedido,double rndEntregaPedido,
            Queue<Pedido> colaEntregaPedido, Queue<Pedido> colaLlegadaPedido,string estadoEmpleado1, string estadoEmpleado2, string estadoEmpleado3, string estadoEmpleadoDelivery)
        {
            this.evento = evento;
           
            this.reloj = reloj;


            this.mediaLlegadaPedido = mediaLlegadaPedido;
            this.limiteA_Prep_Pizza =  limiteA_Prep_Pizza;
            this.limiteB_Prep_Pizza = limiteB_Prep_Pizza;
            this.mediaPrepSandwichNormal = mediaPrepSandwichNormal;

            this.rndLlegadaPedido = rndLlegadaPedido;
            this.rndPreparacionPedido = rndPreparacionPedido;
            this.rndEntregaPedido = rndEntregaPedido;
            this.rndTipoPedido = rndTipoPedido;

            this.rndEntregaPedido = rndEntregaPedido;
            this.mediaTiempoEntrega = mediaTiempoEntrega;


            //Estados de los empleados 
            this.estadoEmpleado1 = estadoEmpleado1;
            this.estadoEmpleado2 = estadoEmpleado2;
            this.estadoEmpleado3 = estadoEmpleado3;
            this.estadoEmpleadoDelivery = estadoEmpleadoDelivery;


            //Estados Colas 
            this.colaEntregaPedido = colaEntregaPedido;
            this.colaLlegadaPedido = colaLlegadaPedido;
            


            //Calculo de la entrega
            double nro = rndEntregaPedido;//random del lenguaje
            double lambda = 1 / mediaPrepSandwichNormal;
            double log = Math.Log(1 - nro);

            this.tiempoEntregaPedido = this.rndPreparacionPedido != 0 ? (-1 / lambda) * log : 0;
            this.proximaFinEntregaPedido = this.tiempoEntregaPedido != 0 ? this.tiempoEntregaPedido + this.reloj : 0;


        }


        public void proximaLlegadaPedido(double rnd)
        {
            
            double a = Math.Pow((Math.E), Convert.ToDouble(-mediaLlegadaPedido));
            double b = 1;

            double i = -1;

            double xi = rnd;
            b = b * xi;
            do
            {
                xi = rnd;
                b = b * xi;
                i = i + 1; /////ver

            } while (b > a);

            this.rndLlegadaPedido = rnd;
            this.tiempoLlegadaPedido = i;

            this.proximaLlegadaPedidoo = this.reloj + this.tiempoLlegadaPedido;
        }

        public string generarTipoDePedido(double rnd)
        {
            string tipoPedidoPedido = "";
            if (rnd > 0 && rnd < 0.20)
            {
                tipoPedidoPedido = "Sandwich";

            }

            else if (rnd >= 0.20 && rnd < 0.60)
            {
                tipoPedidoPedido = "Pizza";

            }

            else if (rnd >= 0.60 && rnd < 0.90)
            {
                tipoPedidoPedido = "Empanadas";

            }

            else
            {
                tipoPedidoPedido = "Lomito";
            }
            return tipoPedidoPedido;
        }

        public double GenerartiempoPreparacion(double rnd, string tipo)
        {
            double time = 0;
            if (tipo == "Pizza")
            {
                time = (float)(limiteA_Prep_Pizza + (this.rndPreparacionPedido * (limiteB_Prep_Pizza - limiteA_Prep_Pizza)));

            }
            else if (tipo == "Sandwich")
            {
                double suma = 0;
                for (int j = 0; j < 12; j++)
                {

                    double aleat = this.rndPreparacionPedido;
                    suma = suma + aleat;
                }
                double z = ((suma - 6) * desvPrepSandwichNormal) + mediaPrepSandwichNormal;

                time =  (z) ;

            }

            else if (tipo == "Lomito")
            {
                time =  5 ;

            }

            else
            {

                time =  15 ;
            }

            return time;

        }

        public double GenerartiempoEntrega(double rnd)
        {
            double time = 0;
           
            //Calculo de la entrega
            double nro = rnd; //random del lenguaje
            double lambda = 1 / (this.mediaTiempoEntrega);
            double log = Math.Log(1 - nro);

           time =  (-1 / lambda) * log;


            return time; 


        }

            public void proximoEvento()
            {
                string proxEvento = "llegada_Pedido";
                double min = this.proximaLlegadaPedidoo;

                if (min > this.proximaFinPreparacionPedidoE1 && this.proximaFinPreparacionPedidoE1 != 0)
                {
                    min = this.proximaFinPreparacionPedidoE1;
                    proxEvento = "fin_PreparacionPedido E1";
                }

                if (min > this.proximaFinPreparacionPedidoE2 && this.proximaFinPreparacionPedidoE2 != 0)
                {
                    min = this.proximaFinPreparacionPedidoE2;
                    proxEvento = "fin_PreparacionPedido E2";
                }

                if (min > this.proximaFinPreparacionPedidoE3 && this.proximaFinPreparacionPedidoE3 != 0)
                {
                    min = this.proximaFinPreparacionPedidoE3;
                    proxEvento = "fin_PreparacionPedido E3";
                }

          
                if (min > this.proximaFinEntregaPedido && this.proximaFinEntregaPedido != 0)
                {
                    min = this.proximaFinEntregaPedido;
                    proxEvento = "fin_EntregaDelivery";
                }
      

                this.reloj = (float)min;
                this.evento = proxEvento;
            }


      



        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
