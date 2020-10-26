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

            //Tomamos los datos de los inputs de la preparacion de pedidos
            int mediaLlegadaPedido = int.Parse(this.txtMediaLlegadaPedido.Text.Trim());
            int limiteA_Prep_Pizza = int.Parse(this.txtLimiteA_PrepPizza.Text.Trim());
            int limiteB_Prep_Pizza = int.Parse(this.txtLimiteB_PrepPizza.Text.Trim());
            int mediaPrepSandwichNormal = int.Parse(this.txtMediaPreparacionSandwich.Text.Trim());
            int desvPrepSandwichNormal = int.Parse(this.txtDesvSandwich.Text.Trim());
            int mediaTiempoEntrega = int.Parse(this.txtMediaTiempoDeEntrega.Text.Trim());

            // tomamos lo datos de los inputs de los costos de los pedidos
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
            //Emplado 2
            tabla.Columns.Add("EstadoEmpleado2");
            tabla.Columns.Add("Pedido2");
            tabla.Columns.Add("Tipo Pedido2");
            tabla.Columns.Add("RND Tiempo prep2");
            tabla.Columns.Add("Tiempo preparacion2");
            tabla.Columns.Add("Proximo Fin Prep 2");
            tabla.Columns.Add("Cola Emp 2");
            //Empleado 3
            tabla.Columns.Add("EstadoEmpleado3");
            tabla.Columns.Add("Pedido3");
            tabla.Columns.Add("Tipo Pedido3");
            tabla.Columns.Add("RND Tiempo prep3");
            tabla.Columns.Add("Tiempo preparacion3");
            tabla.Columns.Add("Proximo Fin Prep 3");
            tabla.Columns.Add("Cola Emp 3");

            //Delivery
            tabla.Columns.Add("Cola Delivery");
            tabla.Columns.Add("RND Delivery");
            tabla.Columns.Add("Tiempo Entrega");
            tabla.Columns.Add("Fin Entrega");

            //Inicializamos las filas
            //actual = new Fila(mediaLlegadaPedido, limiteA_Prep_Pizza, limiteB_Prep_Pizza, mediaPrepSandwichNormal, desvPrepSandwichNormal, mediaTiempoEntrega, "Inicializacion", 0, (Math.Truncate(rnd.NextDouble() * 100) / 100), 0, 0, 0, new Queue<Pedido>(), new Queue<Pedido>(), "Libre", "Libre", "Libre", "Libre");

            //anterior = (Fila)actual.Clone();
            
            while (i < cantIteraciones) //valor para controlar

            {
                if (i == 0) {
                    actual = new Fila(1, 0, "Inicializacion", 0, mediaLlegadaPedido, 0.53 , "-", "Libre", 0, "-", 0, 0, 0, new Queue<Pedido>(), "Libre", 0, "-", 0, 0, 0, new Queue<Pedido>(), "Libre", 0, "-", 0, 0, 0, new Queue<Pedido>(), "Libre", new Queue<Pedido>(), 0, 0, 0, limiteA_Prep_Pizza, limiteB_Prep_Pizza, mediaPrepSandwichNormal, desvPrepSandwichNormal, mediaTiempoEntrega, costo_pizza, costo_sandwich, costo_empanadas, costo_hamburguesa, costo_lomito);
                    actual.proximaLlegadaPedido(0.43);
                    this.agregarDato(this.actual);
                    anterior = (Fila)actual.Clone();
                }

                anterior = (Fila)actual.Clone();
                actual.proximoEvento(); // aca se setea el reloj en actual y el evento

                //i = this.actual.reloj;


                if (i < cantIteraciones)
                {

                    //Anterior por actual
                    //anterior = (Fila)actual.Clone();
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
                    this.agregarDato(actual);


                }                

                this.dataGridView.DataSource = this.tabla;
                i++;
            }
        }




        public void llegadaPedido()
        {
            this.actual.numeroPedido = this.actual.proximoNumeroPedido;
            this.actual.proximoNumeroPedido++;
            this.actual.proximaLlegadaPedido((Math.Truncate(rnd.NextDouble() * 100) / 100));
            this.actual.rndTipoPedido = Math.Truncate(rnd.NextDouble() * 100) / 100;
            this.actual.generarTipoDePedido(this.actual.rndTipoPedido);

            //Asigno el pedido a un empleado, esto cambiarlo despues
            double randomAsignacion = Math.Truncate(rnd.NextDouble() * 100) / 100;
            if (randomAsignacion < 0.33)
            {
                this.actual.empleadoDesignado = "Empleado 1";
            }
            else if (randomAsignacion > 0.33 && randomAsignacion < 0.66)
            {
                this.actual.empleadoDesignado = "Empleado 2";
            }
            else
            {
                this.actual.empleadoDesignado = "Empleado 3";
            }
            Pedido pedidoActual = new Pedido(this.actual.numeroPedido, this.actual.tipoPedidoPedido);
            switch (actual.empleadoDesignado)
            {
                case "Empleado 1":
                    if(anterior.estadoEmpleado1 == "Libre")
                    {
                        this.actual.estadoEmpleado1 = "Ocupado";
                        this.actual.rndPreparacionPedidoE1 = Math.Truncate(rnd.NextDouble() * 100) / 100;
                        double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE1, this.actual.tipoPedidoPedido);
                        this.actual.tiempoPreparacionPedidoE1 = tiempoPreparacion;
                        this.actual.proximaFinPreparacionPedidoE1 = this.actual.reloj + this.actual.tiempoPreparacionPedidoE1;
                        this.actual.numeroPedidoEnPreparacion = pedidoActual.id;
                        this.actual.tipoPedidoEnPreparacion = pedidoActual.tipoPedido;
                        break;

                    }
                    if (anterior.estadoEmpleado1 == "Ocupado")
                    {
                        this.actual.ColaEmpleado1.Enqueue(pedidoActual);
                        this.actual.rndPreparacionPedidoE1 = 0;
                        this.actual.tiempoPreparacionPedidoE1 = 0;
                    }

                    break;
                case "Empleado 2":
                    if (anterior.estadoEmpleado2 == "Libre")
                    {
                        this.actual.estadoEmpleado2 = "Ocupado";
                        this.actual.rndPreparacionPedidoE2 = Math.Truncate(rnd.NextDouble() * 100) / 100;
                        double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE2, this.actual.tipoPedidoPedido);
                        this.actual.tiempoPreparacionPedidoE2 = tiempoPreparacion;
                        this.actual.proximaFinPreparacionPedidoE2 = this.actual.reloj + this.actual.tiempoPreparacionPedidoE2;
                        this.actual.numeroPedidoEnPreparacionE2 = pedidoActual.id;
                        this.actual.tipoPedidoEnPreparacionE2 = pedidoActual.tipoPedido;
                        break;

                    }
                    if (anterior.estadoEmpleado2 == "Ocupado")
                    {
                        this.actual.ColaEmpleado2.Enqueue(pedidoActual);
                        this.actual.rndPreparacionPedidoE2 = 0;
                        this.actual.tiempoPreparacionPedidoE2 = 0;
                    }

                    break;
                case "Empleado 3":
                    if (anterior.estadoEmpleado3 == "Libre")
                    {
                        this.actual.estadoEmpleado3 = "Ocupado";
                        this.actual.rndPreparacionPedidoE3 = Math.Truncate(rnd.NextDouble() * 100) / 100;
                        double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE3, this.actual.tipoPedidoPedido);
                        this.actual.tiempoPreparacionPedidoE3 = tiempoPreparacion;
                        this.actual.proximaFinPreparacionPedidoE3 = this.actual.reloj + this.actual.tiempoPreparacionPedidoE3;
                        this.actual.numeroPedidoEnPreparacionE3 = pedidoActual.id;
                        this.actual.tipoPedidoEnPreparacionE3 = pedidoActual.tipoPedido;
                        break;

                    }
                    if (anterior.estadoEmpleado3 == "Ocupado")
                    {
                        this.actual.ColaEmpleado3.Enqueue(pedidoActual);
                        this.actual.rndPreparacionPedidoE3 = 0;
                        this.actual.tiempoPreparacionPedidoE3 = 0;
                    }

                    break;


            }
            
            

        }

        public void FinPreparacionPedido(int i)
        {
            this.actual.rndLlegadaPedido = 0;
            this.actual.tiempoLlegadaPedido = 0;
            this.actual.empleadoDesignado = "X";
            this.actual.rndTipoPedido = 0;
            this.actual.tipoPedidoPedido = "X";
            if ( i == 1)
            {
                this.actual.numeroPedido = (int)this.anterior.numeroPedidoEnPreparacion;
                this.actual.proximoNumeroPedido = this.anterior.proximoNumeroPedido;
                if ( anterior.ColaEmpleado1.Count() > 0)
                {
                    actual.estadoEmpleado1 = "Ocupado";
                    this.actual.rndPreparacionPedidoE1 = Math.Truncate(rnd.NextDouble() * 100) / 100;
                    double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE1, this.actual.tipoPedidoPedido);
                    this.actual.tiempoPreparacionPedidoE1 = tiempoPreparacion;
                    this.actual.proximaFinPreparacionPedidoE1 = this.actual.reloj + this.actual.tiempoPreparacionPedidoE1;
                    Pedido proximoPedido = anterior.ColaEmpleado1.Dequeue();
                    this.actual.numeroPedidoEnPreparacion = proximoPedido.id;
                    this.actual.tipoPedidoEnPreparacion = proximoPedido.tipoPedido;
                }
                else
                {
                    actual.estadoEmpleado1 = "Libre";
                    actual.rndPreparacionPedidoE1 = 0;
                    actual.tiempoPreparacionPedidoE1 = 0;
                    actual.proximaFinPreparacionPedidoE1 = 0;
                    actual.numeroPedidoEnPreparacion = 0;
                    actual.tipoPedidoEnPreparacion = "X";
                }
               
            }
            else if (i == 2)
            {
                this.actual.numeroPedido = (int)this.anterior.numeroPedidoEnPreparacionE2;
                this.actual.proximoNumeroPedido = this.anterior.proximoNumeroPedido;
                if (anterior.ColaEmpleado2.Count() > 0)
                {
                    actual.estadoEmpleado2 = "Ocupado";
                    this.actual.rndPreparacionPedidoE2 = Math.Truncate(rnd.NextDouble() * 100) / 100;
                    double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE2, this.actual.tipoPedidoPedido);
                    this.actual.tiempoPreparacionPedidoE2 = tiempoPreparacion;
                    this.actual.proximaFinPreparacionPedidoE2 = this.actual.reloj + this.actual.tiempoPreparacionPedidoE2;
                    Pedido proximoPedido = anterior.ColaEmpleado2.Dequeue();
                    this.actual.numeroPedidoEnPreparacionE2 = proximoPedido.id;
                    this.actual.tipoPedidoEnPreparacionE2 = proximoPedido.tipoPedido;
                }
                else
                {
                    actual.estadoEmpleado2 = "Libre";
                    actual.rndPreparacionPedidoE2 = 0;
                    actual.tiempoPreparacionPedidoE2 = 0;
                    actual.proximaFinPreparacionPedidoE2 = 0;
                    actual.numeroPedidoEnPreparacionE2 = 0;
                    actual.tipoPedidoEnPreparacionE2 = "X";
                }

            }
            else
            {
                this.actual.numeroPedido = (int)this.anterior.numeroPedidoEnPreparacionE3;
                this.actual.proximoNumeroPedido = this.anterior.proximoNumeroPedido;
                if (anterior.ColaEmpleado3.Count() > 0)
                {
                    actual.estadoEmpleado3 = "Ocupado";
                    this.actual.rndPreparacionPedidoE3 = Math.Truncate(rnd.NextDouble() * 100) / 100;
                    double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE3, this.actual.tipoPedidoPedido);
                    this.actual.tiempoPreparacionPedidoE3 = tiempoPreparacion;
                    this.actual.proximaFinPreparacionPedidoE3 = this.actual.reloj + this.actual.tiempoPreparacionPedidoE3;
                    Pedido proximoPedido = anterior.ColaEmpleado3.Dequeue();
                    this.actual.numeroPedidoEnPreparacionE3 = proximoPedido.id;
                    this.actual.tipoPedidoEnPreparacionE3 = proximoPedido.tipoPedido;
                }
                else
                {
                    actual.estadoEmpleado3 = "Libre";
                    actual.rndPreparacionPedidoE3 = 0;
                    actual.tiempoPreparacionPedidoE3 = 0;
                    actual.proximaFinPreparacionPedidoE3 = 0;
                    actual.numeroPedidoEnPreparacionE3 = 0;
                    actual.tipoPedidoEnPreparacionE3 = "X";
                }
            }

        }




        private void agregarDato(Fila fila)
            {
                tabla.Rows.Add(
                fila.reloj.ToString(),
                fila.evento,
                fila.numeroPedido,
                fila.proximoNumeroPedido,
                fila.rndLlegadaPedido == 0 ? "X" : fila.rndLlegadaPedido.ToString(),
                fila.tiempoLlegadaPedido == 0 ? "X" : fila.tiempoLlegadaPedido.ToString(),
                fila.proximaLlegadaPedidoo == 0 ? "X" : fila.proximaLlegadaPedidoo.ToString(),
                fila.rndTipoPedido == 0 ? "X" : fila.rndTipoPedido.ToString(),
                fila.tipoPedidoPedido,
                fila.empleadoDesignado,

                fila.estadoEmpleado1,
                fila.numeroPedidoEnPreparacion == 0 ? "X" : fila.numeroPedidoEnPreparacion.ToString(),
                fila.tipoPedidoEnPreparacion,
                fila.rndPreparacionPedidoE1 == 0 ? "X" : fila.rndPreparacionPedidoE1.ToString(),
                fila.tiempoPreparacionPedidoE1 == 0 ? "X" : fila.tiempoPreparacionPedidoE1.ToString(),
                fila.proximaFinPreparacionPedidoE1,
                fila.ColaEmpleado1.Count(),

                fila.estadoEmpleado2,
                fila.numeroPedidoEnPreparacionE2 == 0 ? "X" : fila.numeroPedidoEnPreparacionE2.ToString(),
                fila.tipoPedidoEnPreparacionE2,
                fila.rndPreparacionPedidoE2 == 0 ? "X" : fila.rndPreparacionPedidoE2.ToString(),
                fila.tiempoPreparacionPedidoE2 == 0 ? "X" : fila.tiempoPreparacionPedidoE2.ToString(),
                fila.proximaFinPreparacionPedidoE2,
                fila.ColaEmpleado2.Count(),

                fila.estadoEmpleado3,
                fila.numeroPedidoEnPreparacionE3 == 0 ? "X" : fila.numeroPedidoEnPreparacionE3.ToString(),
                fila.tipoPedidoEnPreparacionE3,
                fila.rndPreparacionPedidoE3 == 0 ? "X" : fila.rndPreparacionPedidoE3.ToString(),
                fila.tiempoPreparacionPedidoE3 == 0 ? "X" : fila.tiempoPreparacionPedidoE3.ToString(),
                fila.proximaFinPreparacionPedidoE3,
                fila.ColaEmpleado3.Count()

                );

            //int i = 0;
            //foreach (var cliente in this.objetos)
            //{
           //     i++;
             //   this.tabla.Rows[this.tabla.Rows.Count - 1]["Pedido " + i] = cliente.estado;
               
           // }


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
