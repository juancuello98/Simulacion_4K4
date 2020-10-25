using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_5_v2
{
    public partial class Form1 : Form
    {
        List<Pedido> objetos = new List<Pedido>(); 

        Fila actual;
        Fila anterior;
        Random rnd = new Random();
        DataTable tabla = new DataTable();
        float desde;
        float hasta;
        float tiempoQA;//sacar esto

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            desde = float.Parse(this.txtMinDesde.Text.Trim());
            hasta = float.Parse(this.txtMinHasta.Text.Trim());
            int cantIteraciones = int.Parse(this.txtMinSimulacion.Text.Trim());

            //Limpiar tabla
            this.dataGridView.DataSource = null;
            this.dataGridView.Rows.Clear();

            this.tabla.Clear();
            this.tabla.Columns.Clear();

            //Tomamos los datos de los inputs
            int mediaLlegadaPedido = int.Parse(this.txtMediaLlegadaPedido.Text.Trim());

            int limiteA_Prep_Pizza = int.Parse(this.txtLimiteA_PrepPizza.Text.Trim());
            int limiteB_Prep_Pizza = int.Parse(this.txtLimiteB_PrepPizza.Text.Trim());

            int mediaPrepSandwichNormal = int.Parse(this.txtMediaPreparacionSandwich.Text.Trim());
            int desvPrepSandwichNormal = int.Parse(this.txtDesvSandwich.Text.Trim());

            int mediaTiempoEntrega = int.Parse(this.txtMediaTiempoDeEntrega.Text.Trim());


            float costo_pizza = int.Parse(this.TxtCostoPizza.Text.Trim());

            float costo_sandwich = int.Parse(this.TxtCostoSandwich.Text.Trim());
            float costo_empanadas = int.Parse(this.TxtCostoEmpanada.Text.Trim());
            float costo_hamburguesa = int.Parse(this.TxtCostoHamburguesa.Text.Trim()); ;
            float costo_lomito = int.Parse(this.TxtCostoLomito.Text.Trim()); ;

            float i = 0;
            
            tabla.Columns.Add("Reloj");
            tabla.Columns.Add("Evento");
            tabla.Columns.Add("Pedido N°");
            tabla.Columns.Add("Proximo N°");

            // Pedido
            tabla.Columns.Add("RND Llegada Pedido");
            tabla.Columns.Add("Tiempo Llegada Pedido");
            tabla.Columns.Add("Proxima Llegada Pedido");
            tabla.Columns.Add("RND Tipo Pedido");
            tabla.Columns.Add("Tipo Pedido");
            tabla.Columns.Add("Empleado Asignado");

            //Empleados
            //Empleado 1
            tabla.Columns.Add("EstadoEmpleado1");
            tabla.Columns.Add("Pedido1");
            tabla.Columns.Add("Tipo Pedido At");
            tabla.Columns.Add("RND Tiempo prep");
            tabla.Columns.Add("Tiempo preparacion");
            tabla.Columns.Add("Proximo Fin Prep 1");
            tabla.Columns.Add("Cola Emp 1");
            tabla.Columns.Add("Proximo N Pedido");
            tabla.Columns.Add("Proximo Tipo pedido");
            //Emplado 2
            tabla.Columns.Add("EstadoEmpleado2");
            tabla.Columns.Add("Pedido2");
            tabla.Columns.Add("Tipo Pedido2");
            tabla.Columns.Add("RND Tiempo prep2");
            tabla.Columns.Add("Tiempo preparacion2");
            tabla.Columns.Add("Proximo Fin Prep 2");
            tabla.Columns.Add("Cola Emp 2");
            tabla.Columns.Add("Proximo N Pedido2");
            tabla.Columns.Add("Proximo Tipo pedido2");
            //Empleado 3
            tabla.Columns.Add("EstadoEmpleado3");
            tabla.Columns.Add("Pedido3");
            tabla.Columns.Add("Tipo Pedido3");
            tabla.Columns.Add("RND Tiempo prep3");
            tabla.Columns.Add("Tiempo preparacion3");
            tabla.Columns.Add("Proximo Fin Prep 3");
            tabla.Columns.Add("Cola Emp 3");
            tabla.Columns.Add("Proximo N Pedido3");
            tabla.Columns.Add("Proximo Tipo pedido3");

            //Delivery
            tabla.Columns.Add("Cola Delivery");
            tabla.Columns.Add("RND Delivery");
            tabla.Columns.Add("Tiempo Entrega");
            tabla.Columns.Add("Fin Entrega");

            //Inicializamos las filas
            actual = new Fila(mediaLlegadaPedido, limiteA_Prep_Pizza, limiteB_Prep_Pizza, mediaPrepSandwichNormal, desvPrepSandwichNormal, mediaTiempoEntrega, "Inicializacion", 0, (Math.Truncate(rnd.NextDouble() * 100) / 100), 0, 0, 0, new Queue<Pedido>(), new Queue<Pedido>(), "Libre", "Libre", "Libre", "Libre");

            anterior = (Fila)actual.Clone();
            this.vaciarRNDS();

            while (i < cantIteraciones)

            {

                if (this.actual.reloj <= hasta && this.actual.reloj >= desde)
                {
                    this.agregarDato(this.actual);
                }

                actual.proximoEvento();

                i = this.actual.reloj;


                if (i < cantIteraciones)
                {

                    //Anterior por actual
                    anterior = (Fila)actual.Clone();
                    //Cambios segun evento
                    switch (actual.evento)
                    {
                        case "llegada_Pedido":
                            this.llegadaPedido();
                            break;
                        case "fin_PreparacionPedido E1":
                            this.FinPreparacionPedido(1);
                            break;

                        case "fin_PreparacionPedido E2":
                            this.FinPreparacionPedido(2);
                            break;

                        case "fin_PreparacionPedido E3":
                            this.FinPreparacionPedido(3);
                            break;

                        //case "fin_EntregaDelivery":
                        //   this.FinEntregaPedido();
                        //   break;

                    }



                }
                else
                {
                    this.actual.evento = "Finalización";
                    this.actual.reloj = cantIteraciones;
                    this.agregarDato(this.anterior);
                    this.agregarDato(this.actual);

                }

                this.dataGridView.DataSource = this.tabla;

            }
        }




        public void llegadaPedido()
        {
            this.actual.cantLlegadas++;
            this.actual.evento += " " + this.actual.cantLlegadas.ToString();

            this.actual.proximaLlegadaPedido((Math.Truncate(rnd.NextDouble() * 100) / 100));

           

            //Verifico si hay Hay chefs listos
            if (this.actual.estadoEmpleado1 == "Ocupado" && this.actual.estadoEmpleado2 == "Ocupado" && this.actual.estadoEmpleado3 == "Ocupado")
            {
                Pedido Pedido_A_Cola = new Pedido(this.actual.reloj, "En Cola Preparacion");

                this.actual.colaLlegadaPedido.Enqueue(Pedido_A_Cola);
                this.objetos.Add(Pedido_A_Cola);
                this.tabla.Columns.Add("Pedido " + this.objetos.Count);



            }
            else
                {
                //Calculo el tiempo preparacion
                string tipo = this.actual.generarTipoDePedido((Math.Truncate(rnd.NextDouble() * 100) / 100));

                this.actual.tipoPedidoPedido = tipo;

                this.actual.rndPreparacionPedido = (Math.Truncate(rnd.NextDouble() * 100) / 100); 

                this.actual.tiempoPreparacionPedido=  this.actual.GenerartiempoPreparacion((Math.Truncate(rnd.NextDouble() * 100) / 100), tipo);

                 if (this.actual.estadoEmpleado1 == "Libre")
                 {
                    this.actual.estadoEmpleado1 = "Ocupado";
                    this.actual.enPreparacionE1 = new Pedido(this.actual.reloj, "EPE1");

                    this.actual.proximaFinPreparacionPedidoE1 = this.actual.tiempoPreparacionPedido + this.actual.reloj;
                 }

                else if (this.actual.estadoEmpleado2 == "Libre")
                {
                    this.actual.estadoEmpleado2 = "Ocupado";
                    this.actual.enPreparacionE2 = new Pedido(this.actual.reloj, "EPE2");

                    this.actual.proximaFinPreparacionPedidoE2 = this.actual.tiempoPreparacionPedido + this.actual.reloj;

                }

                else if(this.actual.estadoEmpleado3 == "Libre")
                {
                    this.actual.estadoEmpleado3 = "Ocupado";
                    this.actual.enPreparacionE3 = new Pedido(this.actual.reloj, "EPE3");

                    this.actual.proximaFinPreparacionPedidoE3 = this.actual.tiempoPreparacionPedido + this.actual.reloj;

                }

            }
        }

        public void FinPreparacionPedido(int i)
        {
            int j = 0;
            if (i == 1)
            {
                if(this.actual.colaLlegadaPedido.Count > 0)
                {
                   

                    this.actual.enPreparacionE1 = this.actual.colaLlegadaPedido.Dequeue();

                    string tipo = this.actual.generarTipoDePedido((Math.Truncate(rnd.NextDouble() * 100) / 100));

                    this.actual.tipoPedidoPedido = tipo;

                    this.actual.rndPreparacionPedido = (Math.Truncate(rnd.NextDouble() * 100) / 100);

                    this.actual.tiempoPreparacionPedido = this.actual.GenerartiempoPreparacion((Math.Truncate(rnd.NextDouble() * 100) / 100), tipo);

                    this.actual.enPreparacionE1.estado = "EPE1";
                    this.actual.enPreparacionE1.id = this.actual.reloj;

                    this.actual.proximaFinPreparacionPedidoE1 = this.actual.tiempoPreparacionPedido + this.actual.reloj;

                }
                else
                {
                    this.actual.estadoEmpleado1 = "Libre";
                    this.actual.proximaFinPreparacionPedidoE1 = 0;
                    this.actual.enPreparacionE1 = new Pedido();
                }

                return;
            }
            else if (i == 2)
            {
                if (this.actual.colaLlegadaPedido.Count > 0)
                {


                    this.actual.enPreparacionE2 = this.actual.colaLlegadaPedido.Dequeue();

                    string tipo = this.actual.generarTipoDePedido((Math.Truncate(rnd.NextDouble() * 100) / 100));

                    this.actual.tipoPedidoPedido = tipo;

                    this.actual.rndPreparacionPedido = (Math.Truncate(rnd.NextDouble() * 100) / 100);

                    this.actual.tiempoPreparacionPedido = this.actual.GenerartiempoPreparacion((Math.Truncate(rnd.NextDouble() * 100) / 100), tipo);

                    this.actual.enPreparacionE2.estado = "EPE2";
                    this.actual.enPreparacionE2.id = this.actual.reloj;

                    this.actual.proximaFinPreparacionPedidoE2 = this.actual.tiempoPreparacionPedido + this.actual.reloj;

                }
                else
                {
                    this.actual.estadoEmpleado2 = "Libre";
                    this.actual.proximaFinPreparacionPedidoE2 = 0;

                    this.actual.enPreparacionE2 = new Pedido();
                }

               
            }
            else if (i == 3)
            {
                if (this.actual.colaLlegadaPedido.Count > 0)
                {
                    this.actual.enPreparacionE3 = this.actual.colaLlegadaPedido.Dequeue();

                    string tipo = this.actual.generarTipoDePedido((Math.Truncate(rnd.NextDouble() * 100) / 100));

                    this.actual.tipoPedidoPedido = tipo;

                    this.actual.rndPreparacionPedido = (Math.Truncate(rnd.NextDouble() * 100) / 100);

                    this.actual.tiempoPreparacionPedido = this.actual.GenerartiempoPreparacion((Math.Truncate(rnd.NextDouble() * 100) / 100), tipo);

                    this.actual.enPreparacionE3.estado = "EPE1";
                    this.actual.enPreparacionE3.id = this.actual.reloj;

                    this.actual.proximaFinPreparacionPedidoE3 = this.actual.tiempoPreparacionPedido + this.actual.reloj;


                }
                else
                {
                    this.actual.estadoEmpleado3 = "Libre";
                    this.actual.proximaFinPreparacionPedidoE3 = 0;

                    this.actual.enPreparacionE3 = new Pedido();

                }

                
            }


            if (this.actual.estadoEmpleadoDelivery == "Ocupado")
            {
                Pedido Pedido_enCola_Delivery = new Pedido(this.actual.reloj, "Esperando Entrega");

                this.actual.colaEntregaPedido.Enqueue(Pedido_enCola_Delivery);
                this.objetos.Add(Pedido_enCola_Delivery);
                this.tabla.Columns.Add("Pedido " + this.objetos.Count);


            }
            else
            {
                this.actual.rndEntregaPedido = (Math.Truncate(rnd.NextDouble() * 100) / 100);
                this.actual.tiempoEntregaPedido = this.actual.GenerartiempoEntrega(this.actual.rndEntregaPedido);

                this.actual.proximaFinEntregaPedido = this.actual.tiempoEntregaPedido + this.actual.reloj;

                this.actual.estadoEmpleadoDelivery = "Ocupado";
            }

           
        }

        public void FinEntregaPedido()
        {
            if (this.actual.colaLlegadaPedido.Count > 0)
            {
                this.actual.EnColaDelivery = this.actual.colaEntregaPedido.Dequeue();

                this.actual.rndEntregaPedido = (Math.Truncate(rnd.NextDouble() * 100) / 100);
                this.actual.tiempoEntregaPedido = this.actual.GenerartiempoEntrega(this.actual.rndEntregaPedido);

                this.actual.proximaFinEntregaPedido = this.actual.tiempoEntregaPedido + this.actual.reloj;

                this.actual.EnColaDelivery.estado = "ED";
                this.actual.EnColaDelivery.id = this.actual.reloj;


            }
            else
            {
                this.actual.estadoEmpleadoDelivery = "Libre";

               
                this.actual.proximaFinEntregaPedido = 0;

                this.actual.enDelivery = new Pedido();

            }




        }




        private void agregarDato(Fila fila)
            {
                tabla.Rows.Add(
                fila.reloj.ToString(),
                fila.evento,
                fila.rndLlegadaPedido == 0 ? "" : fila.rndLlegadaPedido.ToString(),
                fila.tiempoLlegadaPedido == 0 ? "" : fila.tiempoLlegadaPedido.ToString(),
                fila.proximaLlegadaPedidoo == 0 ? "" : fila.proximaLlegadaPedidoo.ToString(),
                fila.rndTipoPedido == 0 ? "" : fila.rndTipoPedido.ToString(),
                fila.tipoPedidoPedido is null ? "" : fila.tipoPedidoPedido.ToString(),

                fila.colaLlegadaPedido.Count.ToString(),
                fila.rndPreparacionPedido == 0 ? "" : fila.rndPreparacionPedido.ToString(),
                fila.tiempoPreparacionPedido == 0 ? "" : fila.tiempoPreparacionPedido.ToString(),
                0,
                
                fila.estadoEmpleado1,
                fila.estadoEmpleado2,
                fila.estadoEmpleado3,
                fila.colaEntregaPedido.Count.ToString(),
                fila.rndEntregaPedido == 0 ? "" : fila.rndEntregaPedido.ToString(),
                fila.tiempoEntregaPedido == 0 ? "" : fila.tiempoEntregaPedido.ToString(),
                fila.proximaFinEntregaPedido == 0 ? "" : fila.proximaFinEntregaPedido.ToString()

                );

            int i = 0;
            foreach (var cliente in this.objetos)
            {
                i++;
                this.tabla.Rows[this.tabla.Rows.Count - 1]["Pedido " + i] = cliente.estado;
               
            }


        }

        public void vaciarRNDS()
        {
            this.actual.rndEntregaPedido = 0;
            this.actual.rndLlegadaPedido = 0;
            this.actual.rndPreparacionPedido = 0;
            this.actual.rndTipoPedido = 0;

            this.actual.tiempoPreparacionPedido = 0;
            this.actual.tiempoEntregaPedido = 0;
            this.actual.proximaFinPreparacionPedidoE1 = 0;
            this.actual.proximaFinPreparacionPedidoE2 = 0;
            this.actual.proximaFinPreparacionPedidoE3 = 0;
           
        }

        private void btnCargarEjemplo_Click(object sender, EventArgs e)
        {
            // Carga de los parametros de elaboracion de los productos en el pedido

            this.txtMediaPreparacionSandwich.Text = "10";
            this.txtDesvSandwich.Text = "5";
            this.txtPrepLomitos.Text = "8";
            this.txtPrepEmpanadas.Text = "3";
            this.txtLimiteA_PrepPizza.Text = "15";
            this.txtLimiteB_PrepPizza.Text = "18";
            this.txtPrepHamburguesa.Text = "8";
            this.txtPrepLomitos.Text = "8";

            //Carga de parametros de los precios de los pedidos

            this.TxtCostoEmpanada.Text = "25"; // el precio es por unidad
            this.TxtCostoHamburguesa.Text = "400";
            this.TxtCostoLomito.Text = "450";
            this.TxtCostoPizza.Text = "250";
            this.TxtCostoSandwich.Text = "500";

            //Carga de los parametros del pedido

            this.txtMediaLlegadaPedido.Text = "12"; // en minutos , no en unidades
            this.txtMediaTiempoDeEntrega.Text = "3";
            this.txtTiempoTolerancia.Text = "60";
            this.txtTiempoEntregaGratis.Text = "25";

            //Carga de los parametros de la simulacion

            this.txtMinDesde.Text = "0";
            this.txtMinHasta.Text = "60";
            this.txtDuracionTurno.Text = "6"; //En horas.
            this.txtMinSimulacion.Text = "500"; //Son minutos






        }
    }
}
