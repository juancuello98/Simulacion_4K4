using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP_5_v2
{
    class Fila
    {
        //Pedido

        public int proximoNumeroPedido = 1;
        public int numeroPedido = 0;
        public string evento;
        public double reloj;

        //Evento llegada Pedido
        public double rndLlegadaPedido;
        public double tiempoLlegadaPedido;
        public double proximaLlegadaPedidoo;
        public int mediaLlegadaPedido;

        //TipoPedido
        public double rndTipoPedido;
        public string tipoPedidoPedido;

        // Asignacion del empleado
        public string empleadoDesignado;


        //Evento Preparacion Pedido
        //Empleado 1
        public string estadoEmpleado1;
        public double numeroPedidoEnPreparacion;
        public string tipoPedidoEnPreparacion;
        public double rndPreparacionPedidoE1;
        public double tiempoPreparacionPedidoE1;
        public double proximaFinPreparacionPedidoE1;
        public Queue<Pedido> ColaEmpleado1;
        public double tiempoLibreE1;

        //Empleado 2
        public string estadoEmpleado2;
        public double numeroPedidoEnPreparacionE2;
        public string tipoPedidoEnPreparacionE2;
        public double rndPreparacionPedidoE2;
        public double tiempoPreparacionPedidoE2;
        public double proximaFinPreparacionPedidoE2;
        public Queue<Pedido> ColaEmpleado2;
        public double tiempoLibreE2;

        //Empleado 3
        public string estadoEmpleado3;
        public double numeroPedidoEnPreparacionE3;
        public string tipoPedidoEnPreparacionE3;
        public double rndPreparacionPedidoE3;
        public double tiempoPreparacionPedidoE3;
        public double proximaFinPreparacionPedidoE3;
        public Queue<Pedido> ColaEmpleado3;
        public double tiempoLibreE3;

        ////Empleado Delivery
        public string estadoDelivery;
        public Queue<Pedido> ColaDelivery;
        public double rndEntregaPedido;
        public double tiempoEntregaPedido;
        public double proximaFinEntregaPedido;

        //Local
        public string estadoLocal;
        public double tiempoCierre;
        public double tiempoApertura;
        // Parametros de la prep de pedidos
        //Pizza
        public int limiteA_Prep_Pizza ;
        public int limiteB_Prep_Pizza;

        //sandwich
        public int mediaPrepSandwichNormal ;
        public int desvPrepSandwichNormal;
        //FALTA LO DE LAS EMPANADAS , LOMITOS Y HAMBURGUESAS
        //media de entrega de pedidos
        public int mediaTiempoEntrega ;

        // Parametros de precios de pedidos

        public double costo_pizza ;
        public double costo_sandwich ;
        public double costo_empanadas ;
        public double costo_hamburguesa;
        public double costo_lomito;

        public Fila(int proximoNumeroPedido, int numeroPedido, string evento, double reloj, int mediaLlegadaPedido, double rndTipoPedido, string empleadoDesignado, string estadoEmpleado1, double numeroPedidoEnPreparacion, string tipoPedidoEnPreparacion, double rndPreparacionPedidoE1, double tiempoPreparacionPedidoE1, double proximaFinPreparacionPedidoE1, Queue<Pedido> colaEmpleado1, double tiempoLibreE1, string estadoEmpleado2, double numeroPedidoEnPreparacionE2, string tipoPedidoEnPreparacionE2, double rndPreparacionPedidoE2, double tiempoPreparacionPedidoE2, double proximaFinPreparacionPedidoE2, Queue<Pedido> colaEmpleado2, double tiempoLibreE2, string estadoEmpleado3, double numeroPedidoEnPreparacionE3, string tipoPedidoEnPreparacionE3, double rndPreparacionPedidoE3, double tiempoPreparacionPedidoE3, double proximaFinPreparacionPedidoE3, Queue<Pedido> colaEmpleado3, double tiempoLibreE3, string estadoDelivery, Queue<Pedido> colaDelivery, double rndEntregaPedido, double tiempoEntregaPedido, double proximaFinEntregaPedido, int limiteA_Prep_Pizza, int limiteB_Prep_Pizza, int mediaPrepSandwichNormal, int desvPrepSandwichNormal, int mediaTiempoEntrega, double costo_pizza, double costo_sandwich, double costo_empanadas, double costo_hamburguesa, double costo_lomito, string estadoLocal, double tiempoCierre, double tiempoApertura)
        {
            this.proximoNumeroPedido = proximoNumeroPedido;
            this.numeroPedido = numeroPedido;
            this.evento = evento;
            this.reloj = reloj; 

            this.mediaLlegadaPedido = mediaLlegadaPedido;
            this.rndTipoPedido = rndTipoPedido;
            
            this.empleadoDesignado = empleadoDesignado;
            this.estadoEmpleado1 = estadoEmpleado1;
            this.numeroPedidoEnPreparacion = numeroPedidoEnPreparacion;
            this.tipoPedidoEnPreparacion = tipoPedidoEnPreparacion;
            this.rndPreparacionPedidoE1 = rndPreparacionPedidoE1;
            this.tiempoPreparacionPedidoE1 = tiempoPreparacionPedidoE1;
            this.proximaFinPreparacionPedidoE1 = proximaFinPreparacionPedidoE1;
            this.ColaEmpleado1 = colaEmpleado1;
            this.tiempoLibreE1 = tiempoLibreE1;

            this.estadoEmpleado2 = estadoEmpleado2;
            this.numeroPedidoEnPreparacionE2 = numeroPedidoEnPreparacionE2;
            this.tipoPedidoEnPreparacionE2 = tipoPedidoEnPreparacionE2;
            this.rndPreparacionPedidoE2 = rndPreparacionPedidoE2;
            this.tiempoPreparacionPedidoE2 = tiempoPreparacionPedidoE2;
            this.proximaFinPreparacionPedidoE2 = proximaFinPreparacionPedidoE2;
            this.ColaEmpleado2 = colaEmpleado2;
            this.tiempoLibreE2 = tiempoLibreE2;

            this.estadoEmpleado3 = estadoEmpleado3;
            this.numeroPedidoEnPreparacionE3 = numeroPedidoEnPreparacionE3;
            this.tipoPedidoEnPreparacionE3 = tipoPedidoEnPreparacionE3;
            this.rndPreparacionPedidoE3 = rndPreparacionPedidoE3;
            this.tiempoPreparacionPedidoE3 = tiempoPreparacionPedidoE3;
            this.proximaFinPreparacionPedidoE3 = proximaFinPreparacionPedidoE3;
            this.ColaEmpleado3 = colaEmpleado3;
            this.tiempoLibreE3 = tiempoLibreE3;

            this.estadoDelivery = estadoDelivery;
            this.ColaDelivery = colaDelivery;
            this.rndEntregaPedido = rndEntregaPedido;
            this.tiempoEntregaPedido = tiempoEntregaPedido;
            this.proximaFinEntregaPedido = proximaFinEntregaPedido;
            this.limiteA_Prep_Pizza = limiteA_Prep_Pizza;
            this.limiteB_Prep_Pizza = limiteB_Prep_Pizza;
            this.mediaPrepSandwichNormal = mediaPrepSandwichNormal;
            this.desvPrepSandwichNormal = desvPrepSandwichNormal;
            this.mediaTiempoEntrega = mediaTiempoEntrega;
            this.costo_pizza = costo_pizza;
            this.costo_sandwich = costo_sandwich;
            this.costo_empanadas = costo_empanadas;
            this.costo_hamburguesa = costo_hamburguesa;
            this.costo_lomito = costo_lomito;

            this.estadoLocal = estadoLocal;
            this.tiempoCierre = tiempoCierre;
            this.tiempoApertura = tiempoApertura;
        }

        public void proximaLlegadaPedido()
        {
            int n = 0;
            Random random = new Random();
            
            double random1 = random.NextDouble();
            double valorPoisson = Math.Exp(-mediaLlegadaPedido); //-mediaLlegadaPedido * (Math.Log(1 - random1));
            double random2 = random.NextDouble();
            for (n = 0; random2 > valorPoisson; n++)
            {
                random2 *= random.NextDouble();
            }
            

            this.rndLlegadaPedido = random2;
            this.tiempoLlegadaPedido = n;
            Console.WriteLine("N: " + n);

            this.proximaLlegadaPedidoo = this.reloj + this.tiempoLlegadaPedido;
            Console.WriteLine("Tiempo entre llegada: " + this.proximaLlegadaPedidoo);
            Console.WriteLine("Poisson: " + valorPoisson);
        }

        public void generarTipoDePedido(double rnd)
        {
            
            if (rnd > 0 && rnd < 0.20)
            {
                this.tipoPedidoPedido = "Sandwich";

            }

            else if (rnd >= 0.20 && rnd < 0.60)
            {
                this.tipoPedidoPedido = "Pizza";

            }

            else if (rnd >= 0.60 && rnd < 0.90)
            {
                this.tipoPedidoPedido = "Empanadas";

            }

            else
            {
                this.tipoPedidoPedido = "Lomito";
            }
        }

        public double GenerartiempoPreparacion(double rnd, string tipo)
        {
            double time = 0;
            if (tipo == "Pizza")
            {
                time = (limiteA_Prep_Pizza + (rnd * (limiteB_Prep_Pizza - limiteA_Prep_Pizza)));

            }
            else if (tipo == "Sandwich")
            {
                Random rnd1 = new Random();
                double random1 = Math.Truncate(rnd1.NextDouble() * 100) / 100;
                double random2 = Math.Truncate(rnd1.NextDouble() * 100) / 100;

                double z = Math.Sqrt(-2 * Math.Log(random1)) * Math.Cos(2 * Math.PI * random2);
                time = Math.Round(mediaPrepSandwichNormal + (z * desvPrepSandwichNormal), 3);
                if ( time < 0)
                {
                    time = 10;
                }

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

           time = (-1 / lambda) * log;
            

            return time; 


        }

        public void proximoEvento()
        {
            string proxEvento;
            double relojMinimo;

                if (proximoNumeroPedido == 0)
                {
                    proxEvento = "fin_PreparacionPedido E1";
                    relojMinimo = this.proximaFinPreparacionPedidoE1;
                }
                else
                {
                    proxEvento = "llegada_Pedido";
                    relojMinimo = proximaLlegadaPedidoo;
                }        
                if (relojMinimo > this.proximaFinPreparacionPedidoE1 && this.proximaFinPreparacionPedidoE1 != 0)
                {
                    relojMinimo = this.proximaFinPreparacionPedidoE1;
                    proxEvento = "fin_PreparacionPedido E1";
                }

                if (relojMinimo > this.proximaFinPreparacionPedidoE2 && this.proximaFinPreparacionPedidoE2 != 0)
                {
                    relojMinimo = this.proximaFinPreparacionPedidoE2;
                    proxEvento = "fin_PreparacionPedido E2";
                }

                if (relojMinimo > this.proximaFinPreparacionPedidoE3 && this.proximaFinPreparacionPedidoE3 != 0)
                {
                    relojMinimo = this.proximaFinPreparacionPedidoE3;
                    proxEvento = "fin_PreparacionPedido E3";
                }
          
                if (relojMinimo > this.proximaFinEntregaPedido && this.proximaFinEntregaPedido != 0)
                {
                    relojMinimo = this.proximaFinEntregaPedido;
                    proxEvento = "fin_EntregaDelivery";
                }
                if (relojMinimo > this.tiempoCierre && this.tiempoCierre != 0)
                {
                    relojMinimo = this.tiempoCierre;
                    proxEvento = "Fin del turno";
                }
                if (proximaLlegadaPedidoo == 0)
                {
                    
                }
            this.reloj = relojMinimo;
                this.evento = proxEvento;
        }
        


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
