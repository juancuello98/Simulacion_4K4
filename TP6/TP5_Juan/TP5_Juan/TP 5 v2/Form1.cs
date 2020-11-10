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
        Fila inicio;
        Fila anterior;
        Random rnd = new Random();
        DataTable tabla = new DataTable();
        double desde;
        double hasta;
        int controlTurno = 1;
        Boolean esOtroDia = false;
        string pedidosEntregando;
        bool estabaSiendoPreparado = false;
        bool calculoConEuler = false;
        double contador8a9 = 0;
        double contador9a10 = 0;
        double contador10a11 = 0;
        double contador11a12 = 0;
        double contador12a13 = 0;
        double contador13a14 = 0;
        double contadorDeTodasLosPedidos = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if(chk_calcularEuler.Checked == true)
            {
                calculoConEuler = true;
            }
            else
            {
                calculoConEuler = false;
            }

            desde = double.Parse(this.txtMinDesde.Text.Trim()); // esto tambien tienen que ser cantidad de eventos, ej mostrar del evento 0 al 5000
            hasta = double.Parse(this.txtMinHasta.Text.Trim());
          
            int cantIteraciones = int.Parse(this.txtMinSimulacion.Text.Trim());
            controlTurno = 1;

           

            //Tomamos los datos de los inputs de la preparacion de pedidos
            int mediaLlegadaPedido = int.Parse(this.txtMediaLlegadaPedido.Text.Trim());
            int limiteA_Prep_Pizza = int.Parse(this.txtLimiteA_PrepPizza.Text.Trim());
            int limiteB_Prep_Pizza = int.Parse(this.txtLimiteB_PrepPizza.Text.Trim());
            int mediaPrepSandwichNormal = int.Parse(this.txtMediaPreparacionSandwich.Text.Trim());
            int desvPrepSandwichNormal = int.Parse(this.txtDesvSandwich.Text.Trim());
            int mediaTiempoEntrega = int.Parse(this.txtMediaTiempoDeEntrega.Text.Trim());

            mediaLlegadaPedido = 60 / mediaLlegadaPedido;

            // tomamos lo datos de los inputs de los costos de los pedidos
            double costo_pizza = int.Parse(this.TxtCostoPizza.Text.Trim());
            double costo_sandwich = int.Parse(this.TxtCostoSandwich.Text.Trim());
            double costo_empanadas = int.Parse(this.TxtCostoEmpanada.Text.Trim());
            double costo_hamburguesa = int.Parse(this.TxtCostoHamburguesa.Text.Trim()); ;
            double costo_lomito = int.Parse(this.TxtCostoLomito.Text.Trim()); ;

            double preparacionEmpanadas = double.Parse(txtPrepEmpanadas.Text.Trim());
            double preparacionHamburguesa = double.Parse(txtPrepHamburguesa.Text.Trim());
            double preparacionLomito = double.Parse(txtPrepLomitos.Text.Trim());
            double minutosAIterar = double.Parse(txtMinSimulacion.Text.Trim()); // Son la cantidad de eventos que se muestran


            double i = 0;

            tabla.Columns.Add("Dia");
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
            tabla.Columns.Add("Cantidad empanadas");
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
            tabla.Columns.Add("Tiempo Libre E1");
            //tabla.Columns.Add("Ultimo pedido terminado E1");
            //Emplado 2
            tabla.Columns.Add("EstadoEmpleado2");
            tabla.Columns.Add("Pedido2");
            tabla.Columns.Add("Tipo Pedido2");
            tabla.Columns.Add("RND Tiempo prep2");
            tabla.Columns.Add("Tiempo preparacion2");
            tabla.Columns.Add("Proximo Fin Prep 2");
            tabla.Columns.Add("Cola Emp 2");
            tabla.Columns.Add("Tiempo Libre E2");
            //tabla.Columns.Add("Ultimo pedido terminado E2");
            //Empleado 3
            tabla.Columns.Add("EstadoEmpleado3");
            tabla.Columns.Add("Pedido3");
            tabla.Columns.Add("Tipo Pedido3");
            tabla.Columns.Add("RND Tiempo prep3");
            tabla.Columns.Add("Tiempo preparacion3");
            tabla.Columns.Add("Proximo Fin Prep 3");
            tabla.Columns.Add("Cola Emp 3");
            tabla.Columns.Add("Tiempo Libre E3");


            //Cancelacion del pedido
            tabla.Columns.Add("Cola proximos por cancelar");
            tabla.Columns.Add("Proxima cancelacion");
            //tabla.Columns.Add("Ultimo pedido terminado E3");
            tabla.Columns.Add("Cancelados");
            // Pendientes que fueron cancelados y estaban preparandose
            tabla.Columns.Add("Cancelados pero terminados");

            //Delivery
            tabla.Columns.Add("Estado Delivery");
            tabla.Columns.Add("Cola Delivery");
            tabla.Columns.Add("Mochila Delivery");
            tabla.Columns.Add("RND Delivery");
            tabla.Columns.Add("Tiempo Entrega");
            tabla.Columns.Add("Fin Entrega");
            tabla.Columns.Add("Pedidos en Entrega");
            //tabla.Columns.Add("Ultimo pedido entregado");

            //Local
            tabla.Columns.Add("Estado Local");
            tabla.Columns.Add("Proximo Cierre");
            tabla.Columns.Add("Inicio turno");
            //tabla.Columns.Add("Consignas para primer turno");
            //Acumulacion de los tiempos entre pedidos, y se divide al final por la cantidad de llegada de pedidos para sacar el promedio,
            //se hace para el primer turno. (para el rango en el que se elija mostrar???


            //tabla.Columns.Add("Tiempo entre pedidos");
            tabla.Columns.Add("Pedidos de 8 a 9");
            tabla.Columns.Add("Pedidos de 9 a 10");
            tabla.Columns.Add("Pedidos de 10 a 11");
            tabla.Columns.Add("Pedidos de 11 a 12");
            tabla.Columns.Add("Pedidos de 12 a 13");
            tabla.Columns.Add("Pedidos de 13 a 14");
            

            inicio = new Fila(1,1, 0, "Inicializacion", 960, mediaLlegadaPedido, 0.53, "-", 0,"Libre", 0, "-", 0, 0, 0, new Queue<Pedido>(), 480, "Libre", 0, "-", 0, 0, 0, new Queue<Pedido>(), 480, "Libre", 0, "-", 0, 0, 0, new Queue<Pedido>(), 480, "Libre", new Queue<Pedido>(), new Queue<Pedido>(), 0, 0, 0, limiteA_Prep_Pizza, limiteB_Prep_Pizza, mediaPrepSandwichNormal, desvPrepSandwichNormal, mediaTiempoEntrega, costo_pizza, costo_sandwich, costo_empanadas, costo_hamburguesa, costo_lomito, "Abierto", 1320, 480,preparacionEmpanadas,preparacionLomito,preparacionHamburguesa,new Queue<PedidoCancelado>(),0, new Queue<Pedido>(), new Queue<Pedido>());
            //Inicializamos las filas
            actual = new Fila(1, 1, 0, "Inicializacion", 480, mediaLlegadaPedido, 0.53, "-", 0, "Libre", 0, "-", 0, 0, 0, new Queue<Pedido>(), 480, "Libre", 0, "-", 0, 0, 0, new Queue<Pedido>(), 480, "Libre", 0, "-", 0, 0, 0, new Queue<Pedido>(), 480, "Libre", new Queue<Pedido>(), new Queue<Pedido>(), 0, 0, 0, limiteA_Prep_Pizza, limiteB_Prep_Pizza, mediaPrepSandwichNormal, desvPrepSandwichNormal, mediaTiempoEntrega, costo_pizza, costo_sandwich, costo_empanadas, costo_hamburguesa, costo_lomito, "Abierto", 840, 960, preparacionEmpanadas, preparacionLomito, preparacionHamburguesa, new Queue<PedidoCancelado>(), 0, new Queue<Pedido>(), new Queue<Pedido>());

            

            while (i < minutosAIterar) // cantidad de eventos a simular deberia ser. y que el i tome el valor del reloj en minutos.?????

            {
                if (i == 0) {
                   
                    actual.proximaLlegadaPedido(rnd);
                    this.agregarDato(this.actual);
                    anterior = (Fila)actual.Clone();
                }

                anterior = (Fila)actual.Clone();
                actual.proximoEvento(controlTurno); // aca se setea el reloj en actual y el evento

              


                if (i < minutosAIterar)
                {

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
                        case "Cancelacion_Pedido":
                            this.CancelacionDePedido();
                            break;
                        case "Fin del turno":
                            this.finTurno();
                            break;
                        case "Fin_Entrega":
                            this.finEntregaPedido();
                            break;
                        case "Inicio de turno":
                            this.inicioTurno();
                            break;

                            //case "fin_EntregaDelivery":
                            //   this.FinEntregaPedido();
                            //   break;

                    }
                    // Seteo los tiempos libres de los empleados

                    //Empleado1
                    if (actual.estadoEmpleado1 == "Libre" && anterior.estadoEmpleado1 == "Libre")
                    {
                        actual.tiempoLibreE1 += (actual.reloj - anterior.reloj);
                    }
                    else if (actual.estadoEmpleado1 == "Ocupado" && anterior.estadoEmpleado1 == "Libre")
                    {
                        actual.tiempoLibreE1 += actual.reloj - anterior.tiempoLibreE1;
                    }
                    //Empleado 2
                    if (actual.estadoEmpleado2 == "Libre" && anterior.estadoEmpleado2 == "Libre")
                    {
                        actual.tiempoLibreE2 += (actual.reloj - anterior.reloj);
                    }
                    else if (actual.estadoEmpleado2 == "Ocupado" && anterior.estadoEmpleado2 == "Libre")
                    {
                        actual.tiempoLibreE2 += actual.reloj - anterior.tiempoLibreE2;
                    }
                    //Empleado 3
                    if (actual.estadoEmpleado3 == "Libre" && anterior.estadoEmpleado3 == "Libre")
                    {
                        actual.tiempoLibreE3 += (actual.reloj - anterior.reloj);
                    }
                    else if (actual.estadoEmpleado3 == "Ocupado" && anterior.estadoEmpleado3 == "Libre")
                    {
                        actual.tiempoLibreE3 += actual.reloj - anterior.tiempoLibreE3;
                    }

                    if (actual.tipoPedidoPedido != "Empanadas")
                    {
                        actual.cantidadEmpanadas = 0;
                    }

                    if (hasta > i && desde <= i)
                    {
                        contarPedidoEnHora(actual.reloj,actual.evento,actual.dia,anterior.dia);
                        this.agregarDato(actual);
                    }
                    


                }                

                
                i++;
            }
            this.dataGridView.DataSource = this.tabla;
            this.labelDeCarga.Text = "Simulacion finalizada con exito";
            this.labelDeCarga.ForeColor = Color.LimeGreen;
            this.pictureBox1.Visible = true;
            this.setearResultados();
        }




        public void llegadaPedido()
        {
            this.actual.numeroPedido = this.actual.proximoNumeroPedido;
            this.actual.proximoNumeroPedido++;
            this.actual.proximaLlegadaPedido(rnd);
            this.actual.rndTipoPedido = Math.Truncate(rnd.NextDouble() * 100) / 100;
            this.actual.generarTipoDePedido(this.actual.rndTipoPedido);
            if (this.actual.tipoPedidoPedido == "Empanadas") 
            {
                this.actual.cantidadEmpanadas = generarCantEmpanadas();
            } 
 
            
            Pedido pedidoActual = new Pedido(this.actual.numeroPedido, this.actual.tipoPedidoPedido);

            if (existeUnPedidoTerminado(pedidoActual.tipoPedido)) //Si existe un pedido terminado entonces pasa al delivery y se saca de los canceladosTerminados
            {
                sacarPedidoDeColaTerminados(pedidoActual.tipoPedido); //Saco un pedido que sea del mismo tipo, el primero que encuentre.
                pasarPedidoAColaDelivery(pedidoActual.id,pedidoActual.tipoPedido);// el nuevo pedido que me habia llegado toma el terminado cancelado y pasa a delivery
                
            }
            else
            {
                //Asigno el pedido a un empleado

                this.actual.empleadoDesignado = designarEmpleado(this.actual.numeroPedido);

                //Creo el objeto actual

                //Agrega el pedido a la cola de cancelamiento y setea el tiempo cancelacion del primer elemento de la cola

                double tiempoCancelacion = this.actual.reloj + 60;
                PedidoCancelado pedidoAcancelar = new PedidoCancelado(this.actual.numeroPedido, this.actual.tipoPedidoPedido, tiempoCancelacion, this.actual.empleadoDesignado);

                this.actual.ColaPedidosAcancelar.Enqueue(pedidoAcancelar);

                this.setearProximaCancelacion();

                //Calculo los tiempos de preparacion de los pedidos y si estan ocupado el servidor designado va a la cola

                switch (actual.empleadoDesignado)
                {
                    case "Empleado 1":
                        if (anterior.estadoEmpleado1 == "Libre")
                        {
                            this.actual.estadoEmpleado1 = "Ocupado";
                            this.actual.rndPreparacionPedidoE1 = Math.Truncate(rnd.NextDouble() * 100) / 100;
                            double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE1, pedidoActual.tipoPedido,calculoConEuler);
                            this.actual.tiempoPreparacionPedidoE1 = tiempoPreparacion;
                            this.actual.proximaFinPreparacionPedidoE1 = this.actual.reloj + this.actual.tiempoPreparacionPedidoE1;
                            this.actual.numeroPedidoEnPreparacion = pedidoActual.id;
                            this.actual.tipoPedidoEnPreparacion = pedidoActual.tipoPedido;

                            //Console.WriteLine("Random: " + this.actual.rndPreparacionPedidoE1 + "  Tiempo preparacion: " + this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE1, pedidoActual.tipoPedido) + "  Pedido: "+ pedidoActual.tipoPedido);


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
                            double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE2, this.actual.tipoPedidoPedido, calculoConEuler);
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
                            double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE3, this.actual.tipoPedidoPedido, calculoConEuler);
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



        }

        public void FinPreparacionPedido(int i)
        {
            
            this.actual.rndLlegadaPedido = 0;
            this.actual.tiempoLlegadaPedido = 0;
            this.actual.empleadoDesignado = "X";
            this.actual.rndTipoPedido = 0;
            this.actual.tipoPedidoPedido = "X";


            Pedido pedidoParaEntrega;
            if ( i == 1)
            {
                this.actual.numeroPedido = (int)this.anterior.numeroPedidoEnPreparacion;
                this.actual.proximoNumeroPedido = this.anterior.proximoNumeroPedido;

               
                // Tomo los datos del pedido que pasa a cola del delivery

                pedidoParaEntrega = new Pedido(this.actual.numeroPedido, this.anterior.tipoPedidoEnPreparacion);

                

                if ( anterior.ColaEmpleado1.Count() > 0)
                {
                    actual.estadoEmpleado1 = "Ocupado";
                    Pedido proximoPedido = anterior.ColaEmpleado1.Dequeue();
                    this.actual.numeroPedidoEnPreparacion = proximoPedido.id;
                    this.actual.tipoPedidoEnPreparacion = proximoPedido.tipoPedido;

                    this.actual.rndPreparacionPedidoE1 = Math.Truncate(rnd.NextDouble() * 100) / 100;
                    double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE1, this.actual.tipoPedidoEnPreparacion, calculoConEuler);
                    this.actual.tiempoPreparacionPedidoE1 = tiempoPreparacion;
                    this.actual.proximaFinPreparacionPedidoE1 = this.actual.reloj + this.actual.tiempoPreparacionPedidoE1;
                    
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

              
                // Tomo los datos del pedido que pasa a cola del delivery

                pedidoParaEntrega = new Pedido(this.actual.numeroPedido, this.anterior.tipoPedidoEnPreparacionE2);


                if (anterior.ColaEmpleado2.Count() > 0)
                {
                    actual.estadoEmpleado2 = "Ocupado";
                    this.actual.rndPreparacionPedidoE2 = Math.Truncate(rnd.NextDouble() * 100) / 100;
                    double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE2, this.actual.tipoPedidoPedido, calculoConEuler);
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

                
                // Tomo los datos del pedido que pasa a cola del delivery
                pedidoParaEntrega = new Pedido(this.actual.numeroPedido, this.anterior.tipoPedidoEnPreparacionE3);

                //pregunto si el delivery tiene lugar en la mochila va a la mochila, si no, a la cola de pre entrega
               

                if (anterior.ColaEmpleado3.Count() > 0)
                {
                    actual.estadoEmpleado3 = "Ocupado";
                    this.actual.rndPreparacionPedidoE3 = Math.Truncate(rnd.NextDouble() * 100) / 100;
                    double tiempoPreparacion = this.actual.GenerartiempoPreparacion(this.actual.rndPreparacionPedidoE3, this.actual.tipoPedidoPedido, calculoConEuler);
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

            //lo busco y lo elimino de la cola de cancelacion
            buscarEnColaPorIdyEliminar(pedidoParaEntrega.id);
            setearProximaCancelacion();


            //Cada vez que hay un fin de preparacion dispara que se pregunte en el delivery si esta ocupado
            // Si esta ocupado con mas de 3 pedidos en mochila, se va a la cola de listo para entrega, si no, va a la mochila y genera
            // un random y un tiempo de entrega, cuando llega un pedido para entregar y hay lugar en la mochila no se genera un nuevo tiempo
            // de entrega.

            //Si el pedido que acaba de terminar, estaba en la cola de los ya cancelados, va a la cola de canceladosPeroTerminados
            if (estaEnPedidosCancelados(pedidoParaEntrega.id))
            {
                this.actual.colaCanceladosTerminados.Enqueue(pedidoParaEntrega);
            }
            else// Si no, hago todo el procedimiento a la mochila o cola del delivery.
            {
                if (anterior.estadoDelivery == "Libre" || anterior.estadoDelivery == "En espera") // si estaba libre o en espera 
                {
                    if (anterior.MochilaDelivery.Count() == 2)
                    {
                        actual.MochilaDelivery.Enqueue(pedidoParaEntrega);
                        this.actual.estadoDelivery = "Ocupado"; // cambia su estado a ocupado cuando se llena su mochila es decir que salio a repartir y genera los tiempos
                        this.actual.rndEntregaPedido = Math.Truncate(rnd.NextDouble() * 100) / 100; // se genera un numero aleatorio
                        double tiempoPreparacion = this.actual.GenerartiempoEntrega(this.actual.rndEntregaPedido); // se genera el tiempo entre entregas
                        this.actual.tiempoEntregaPedido = tiempoPreparacion;
                        this.actual.proximaFinEntregaPedido = this.actual.reloj + this.actual.tiempoEntregaPedido; // se setea el proximo fin entrega
                        pedidosEntregando = "";
                        foreach (Pedido pedidoEnMochila in actual.MochilaDelivery)  // se setean los pedidos que se estan entregando
                        {
                            pedidosEntregando += pedidoEnMochila.id + "_";
                        }
                        actual.MochilaDelivery.Clear();


                    }
                    else
                    {
                        actual.MochilaDelivery.Enqueue(pedidoParaEntrega);
                        actual.rndEntregaPedido = 0;
                        actual.tiempoEntregaPedido = 0;
                    }




                }
                else if (anterior.estadoDelivery == "Ocupado")
                {
                    if (anterior.MochilaDelivery.Count() < 3)
                    {
                        actual.MochilaDelivery.Enqueue(pedidoParaEntrega);
                    }
                    else
                    {
                        actual.ColaDelivery.Enqueue(pedidoParaEntrega);
                    }
                    actual.rndEntregaPedido = 0;
                    actual.tiempoEntregaPedido = 0;

                }

            }



        }




        private void agregarDato(Fila fila)
        {
            TimeSpan reloj = TimeSpan.FromMinutes(0);
            TimeSpan tiempoCierre = TimeSpan.FromMinutes(0);
            TimeSpan tiempoInicioTurno = TimeSpan.FromMinutes(0);

            TimeSpan tiempoLlegadaPedido = TimeSpan.FromMinutes(0);
            TimeSpan proximaLlegadaPedido = TimeSpan.FromMinutes(0);


            TimeSpan tiempoPreparacionPedidoE1 = TimeSpan.FromMinutes(0);
            TimeSpan proximoPreparacionPedidoE1 = TimeSpan.FromMinutes(0);
            TimeSpan tiempoLibreE1 = TimeSpan.FromMinutes(0);

            TimeSpan tiempoPreparacionPedidoE2 = TimeSpan.FromMinutes(0);
            TimeSpan proximoPreparacionPedidoE2 = TimeSpan.FromMinutes(0);
            TimeSpan tiempoLibreE2 = TimeSpan.FromMinutes(0);

            TimeSpan tiempoPreparacionPedidoE3 = TimeSpan.FromMinutes(0);
            TimeSpan proximoPreparacionPedidoE3 = TimeSpan.FromMinutes(0);
            TimeSpan tiempoLibreE3 = TimeSpan.FromMinutes(0);

            TimeSpan proximoEntregaPedido = TimeSpan.FromMinutes(0);
            TimeSpan tiempoEntregaPedido = TimeSpan.FromMinutes(0);
            TimeSpan minutosIniciales = TimeSpan.FromMinutes(0);
            TimeSpan proximaCancelacionPedido = TimeSpan.FromMinutes(0);

            reloj = TimeSpan.FromMinutes(fila.reloj);
            tiempoCierre = TimeSpan.FromMinutes(fila.tiempoCierre);
            tiempoInicioTurno = TimeSpan.FromMinutes(fila.tiempoApertura);

            tiempoLlegadaPedido = TimeSpan.FromMinutes(fila.tiempoLlegadaPedido);
            proximaLlegadaPedido = TimeSpan.FromMinutes(fila.proximaLlegadaPedidoo);


            tiempoPreparacionPedidoE1 = TimeSpan.FromMinutes(fila.tiempoPreparacionPedidoE1);
            proximoPreparacionPedidoE1 = TimeSpan.FromMinutes(fila.proximaFinPreparacionPedidoE1);
            tiempoLibreE1 = TimeSpan.FromMinutes(fila.tiempoLibreE1);

            tiempoPreparacionPedidoE2 = TimeSpan.FromMinutes(fila.tiempoPreparacionPedidoE2);
            proximoPreparacionPedidoE2 = TimeSpan.FromMinutes(fila.proximaFinPreparacionPedidoE2);
            tiempoLibreE2 = TimeSpan.FromMinutes(fila.tiempoLibreE2);

            tiempoPreparacionPedidoE3 = TimeSpan.FromMinutes(fila.tiempoPreparacionPedidoE3);
            proximoPreparacionPedidoE3 = TimeSpan.FromMinutes(fila.proximaFinPreparacionPedidoE3);
            tiempoLibreE3 = TimeSpan.FromMinutes(fila.tiempoLibreE3);

            proximoEntregaPedido = TimeSpan.FromMinutes(fila.proximaFinEntregaPedido);
            tiempoEntregaPedido = TimeSpan.FromMinutes(fila.tiempoEntregaPedido);
            minutosIniciales = TimeSpan.FromMinutes(480);
            proximaCancelacionPedido = TimeSpan.FromMinutes(fila.proximoCancelacionPedido);

            //TimeSpan proximoFinEntrega = TimeSpan.FromMinutes(fila.proximaFinEntregaPedido);

           tiempoLibreE1 -= minutosIniciales;
            tiempoLibreE2 -= minutosIniciales;
            tiempoLibreE3 -= minutosIniciales;

            tabla.Rows.Add(fila.dia,
            reloj.ToString("hh':'mm':'ss"),
            fila.evento,
            fila.numeroPedido,
            fila.proximoNumeroPedido,
            fila.rndLlegadaPedido == 0 ? "X" : fila.rndLlegadaPedido.ToString(),
            fila.tiempoLlegadaPedido == 0 ? "X" : tiempoLlegadaPedido.ToString("hh':'mm':'ss"),
            fila.proximaLlegadaPedidoo == 0 ? "X" : proximaLlegadaPedido.ToString("hh':'mm':'ss"),
            fila.rndTipoPedido == 0 ? "X" : fila.rndTipoPedido.ToString(),
            fila.tipoPedidoPedido,
            fila.cantidadEmpanadas == 0 ? "X" : fila.cantidadEmpanadas.ToString(),
            fila.empleadoDesignado,
            fila.estadoEmpleado1,
            fila.numeroPedidoEnPreparacion == 0 ? "X" : fila.numeroPedidoEnPreparacion.ToString(),
            fila.tipoPedidoEnPreparacion,
            fila.rndPreparacionPedidoE1 == 0 ? "X" : fila.rndPreparacionPedidoE1.ToString(),
            fila.tiempoPreparacionPedidoE1 == 0 ? "X" : tiempoPreparacionPedidoE1.ToString("hh':'mm':'ss"),
            proximoPreparacionPedidoE1.ToString("hh':'mm':'ss"),
            fila.ColaEmpleado1.Count(),
            tiempoLibreE1.ToString("hh':'mm':'ss"),

            fila.estadoEmpleado2,
            fila.numeroPedidoEnPreparacionE2 == 0 ? "X" : fila.numeroPedidoEnPreparacionE2.ToString(),
            fila.tipoPedidoEnPreparacionE2,
            fila.rndPreparacionPedidoE2 == 0 ? "X" : fila.rndPreparacionPedidoE2.ToString(),
            fila.tiempoPreparacionPedidoE2 == 0 ? "X" : tiempoPreparacionPedidoE2.ToString("hh':'mm':'ss"),
            proximoPreparacionPedidoE2.ToString("hh':'mm':'ss"),
            fila.ColaEmpleado2.Count(),
            tiempoLibreE2.ToString("hh':'mm':'ss"),

            fila.estadoEmpleado3,
            fila.numeroPedidoEnPreparacionE3 == 0 ? "X" : fila.numeroPedidoEnPreparacionE3.ToString(),
            fila.tipoPedidoEnPreparacionE3,
            fila.rndPreparacionPedidoE3 == 0 ? "X" : fila.rndPreparacionPedidoE3.ToString(),
            fila.tiempoPreparacionPedidoE3 == 0 ? "X" : tiempoPreparacionPedidoE3.ToString("hh':'mm':'ss"),
            proximoPreparacionPedidoE3.ToString("hh':'mm':'ss"),
            fila.ColaEmpleado3.Count(),
            tiempoLibreE3.ToString("hh':'mm':'ss"),
            //Cancelacion pedidos

            fila.ColaPedidosAcancelar.Count(),
            proximaCancelacionPedido.ToString("hh':'mm':'ss"),
            fila.colaCancelados.Count(),
            fila.colaCanceladosTerminados.Count(),

            // Delivery
            fila.estadoDelivery,
            fila.ColaDelivery.Count(),
            fila.MochilaDelivery.Count(),
            fila.rndEntregaPedido == 0 ? "X" : fila.rndEntregaPedido.ToString(),
            fila.tiempoEntregaPedido == 0 ? "X" : tiempoEntregaPedido.ToString("hh':'mm':'ss"),
            proximoEntregaPedido.ToString("hh':'mm':'ss"),
            pedidosEntregando,

            fila.estadoLocal,
            tiempoCierre.ToString("hh':'mm':'ss"),
            tiempoInicioTurno.ToString("hh':'mm':'ss"),
            contador8a9,
            contador9a10,
            contador10a11,
            contador11a12,
            contador12a13,
            contador13a14


            );
            


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

            this.txtMediaLlegadaPedido.Text = "5"; //  en unidades x hora
            this.txtMediaTiempoDeEntrega.Text = "3";
            this.txtTiempoTolerancia.Text = "60";
            this.txtTiempoEntregaGratis.Text = "25";

            //Carga de los parametros de la simulacion

            this.txtMinDesde.Text = "0";
            this.txtMinHasta.Text = "60";
            
            this.txtMinSimulacion.Text = "500"; //Son minutos






        }

        public string designarEmpleado(int numeroPedido)
        {
            string empleado = "Empleado 1";
            double randomAsignacion = Math.Truncate(rnd.NextDouble() * 100) / 100;
            double maximo = Math.Max(anterior.tiempoLibreE1, anterior.tiempoLibreE2);

            if (numeroPedido <= 3)
            {
                switch (numeroPedido)
                {
                    case 1:
                        empleado = "Empleado 1";
                        break;
                    case 2:
                        empleado = "Empleado 2";
                        break;
                    case 3:
                        empleado = "Empleado 3";
                        break;
                }
            }
            else
            {

                if (anterior.tiempoLibreE1 == anterior.tiempoLibreE2 && anterior.tiempoLibreE2 == anterior.tiempoLibreE3)
                {

                    if (randomAsignacion < 0.33)
                    {
                        empleado = "Empleado 1";
                    }
                    else if (randomAsignacion > 0.33 && randomAsignacion < 0.66)
                    {
                        empleado = "Empleado 2";
                    }
                    else
                    {
                        empleado = "Empleado 3";
                    }
                }
                else
                {
                    if (maximo < anterior.tiempoLibreE3)
                    {
                        maximo = anterior.tiempoLibreE3;
                        empleado = "Empleado 3";
                    }
                    else if (maximo == anterior.tiempoLibreE1)
                    {
                        empleado = "Empleado 1";
                    }
                    else
                    {
                        empleado = "Empleado 2";
                    }
                }

            }
            return empleado;
        }
        
        public void finTurno()
        {
            if (controlTurno == 1)
            {
                actual.proximoNumeroPedido = 0;
                actual.proximaLlegadaPedidoo = 0;
                actual.rndLlegadaPedido = 0;
                actual.tiempoLlegadaPedido = 0;
                actual.rndTipoPedido = 0;
                actual.empleadoDesignado = "X";
                actual.estadoLocal = "Cerrado";
                actual.tiempoCierre = 1320;
                controlTurno++;
                //Seteo las condiciones de inicio del proximo inicio de turno de la tarde

                inicio.reloj = actual.tiempoApertura;
                inicio.tiempoCierre = actual.tiempoCierre;
                inicio.tiempoApertura = 960;

            }
            else if (controlTurno == 2)
            {
                Console.WriteLine("Aca termina el ultimo turno del dia");
                actual.proximoNumeroPedido = 0;
                actual.proximaLlegadaPedidoo = 0;
                actual.rndLlegadaPedido = 0;
                actual.tiempoLlegadaPedido = 0;
                actual.rndTipoPedido = 0;
                actual.empleadoDesignado = "X";
                actual.estadoLocal = "Cerrado";
                actual.tiempoApertura = 480;

                //Seteo las condiciones de inicio del proximo inicio de turno del otro dia

                inicio.reloj = 480;
                inicio.tiempoCierre = 840;
                controlTurno++;
                esOtroDia = true;
               

            }




        }

        public void inicioTurno()
        {
            pedidosEntregando = "";

            if (esOtroDia)
            {
                //inicio.reloj = 480;
                inicio.dia += 1;
                inicio.tiempoApertura = 960;
                //inicio.tiempoCierre = 840;   
                controlTurno = 1;
                esOtroDia = false;
            }
            


         

            anterior = (Fila)actual.Clone();
            actual = (Fila)inicio.Clone();
            actual.proximaLlegadaPedido(rnd);
            
        }

        public int generarCantEmpanadas()
        {
            
            int n = 0;
            Random random = new Random();

           
            double valorPoisson = Math.Exp(- this.actual.preparacionEmpanadas); //-mediaLlegadaPedido * (Math.Log(1 - random1));
            double random2 = random.NextDouble();
            for (n = 0; random2 > valorPoisson; n++) 
            {
                random2 *= random.NextDouble();
            }

            if (n > 3)
            {
                n = 3;
            }
            return n;
        }

        public void finEntregaPedido()
        {

            Pedido pedidoTraspaso;


            if (anterior.estadoDelivery == "Ocupado" && anterior.ColaDelivery.Count() == 0 && anterior.MochilaDelivery.Count() == 0)
            {
                actual.estadoDelivery = "Libre";
                actual.rndEntregaPedido = 0;
                actual.tiempoEntregaPedido = 0;
                actual.proximaFinEntregaPedido = 0;
            }
            else if (anterior.estadoDelivery == "Ocupado" && anterior.MochilaDelivery.Count() < 3)
            {
                actual.estadoDelivery = "En espera";
                actual.rndEntregaPedido = 0;
                actual.tiempoEntregaPedido = 0;
                actual.proximaFinEntregaPedido = 0;
            }
            else if (anterior.estadoDelivery == "Ocupado" && anterior.MochilaDelivery.Count() == 3)
            {
                this.actual.estadoDelivery = "Ocupado"; // cambia su estado a ocupado cuando se llena su mochila es decir que salio a repartir y genera los tiempos
                this.actual.rndEntregaPedido = Math.Truncate(rnd.NextDouble() * 100) / 100; // se genera un numero aleatorio
                double tiempoPreparacion = this.actual.GenerartiempoEntrega(this.actual.rndEntregaPedido); // se genera el tiempo entre entregas
                this.actual.tiempoEntregaPedido = tiempoPreparacion;
                this.actual.proximaFinEntregaPedido = this.actual.reloj + this.actual.tiempoEntregaPedido; // se setea el proximo fin entrega
                pedidosEntregando = "";
                foreach (Pedido pedidoEnMochila in actual.MochilaDelivery)  // se setean los pedidos que se estan entregando
                {
                    pedidosEntregando += pedidoEnMochila.id + "_";
                }
                actual.MochilaDelivery.Clear();
                if (anterior.ColaDelivery.Count() != 0)
                {
                    for (int i = anterior.ColaDelivery.Count(); i > 0; i--)
                    {
                        pedidoTraspaso = anterior.ColaDelivery.Dequeue();
                        actual.MochilaDelivery.Enqueue(pedidoTraspaso);
                    }
                }
            }


        }   

        public void setearProximaCancelacion()
        {
            PedidoCancelado proximoPedido;
            if (this.actual.ColaPedidosAcancelar.Count() == 0)
            {
                this.actual.proximoCancelacionPedido = 0;
            }
            else
            {
                proximoPedido = this.actual.ColaPedidosAcancelar.Peek();
                this.actual.proximoCancelacionPedido = proximoPedido.proximoTiempoCancelacion;
            }
        }

        public void buscarEnColaPorIdyEliminar(int numeroPedido)
        {
          Queue<PedidoCancelado> nuevaCola = new Queue<PedidoCancelado>();
          foreach (PedidoCancelado pedido in this.anterior.ColaPedidosAcancelar)
          {
                if ( pedido.id != numeroPedido)
                {
                    nuevaCola.Enqueue(pedido);
                }
          }
          
          int i = 0;
          this.actual.ColaPedidosAcancelar.Clear();
          while (i < nuevaCola.Count())
          {
                this.actual.ColaPedidosAcancelar.Enqueue(nuevaCola.Dequeue());
                i++;
          }
            
        }
        public void CancelacionDePedido()
        {
            
            this.actual.rndLlegadaPedido = 0;
            this.actual.tiempoLlegadaPedido = 0;
            this.actual.empleadoDesignado = "X";
            this.actual.rndTipoPedido = 0;
            this.actual.tipoPedidoPedido = "X";
            Pedido pedidoAguardar;
            PedidoCancelado pedidoCancelado; 
            pedidoCancelado = this.anterior.ColaPedidosAcancelar.Dequeue(); 
            this.actual.numeroPedido = pedidoCancelado.id;
            
            if (pedidoCancelado.empleadoDesignado == "Empleado 1")
            {
                if (pedidoCancelado.id == this.anterior.numeroPedidoEnPreparacion)
                {
                    pedidoAguardar = new Pedido(pedidoCancelado.id, pedidoCancelado.tipoPedidoCancelado);
                    this.actual.colaCancelados.Enqueue(pedidoAguardar);
                    estabaSiendoPreparado = true;
                    
                }
                
            }
            else if (pedidoCancelado.empleadoDesignado == "Empleado 2")
            {
                if (this.actual.numeroPedido == this.anterior.numeroPedidoEnPreparacionE2)
                {
                    pedidoAguardar = new Pedido(pedidoCancelado.id, pedidoCancelado.tipoPedidoCancelado);
                    this.actual.colaCancelados.Enqueue(pedidoAguardar);
                    estabaSiendoPreparado = true;

                }
            }
            else
            {
                if (this.actual.numeroPedido == this.anterior.numeroPedidoEnPreparacionE3)
                {
                    pedidoAguardar = new Pedido(pedidoCancelado.id, pedidoCancelado.tipoPedidoCancelado);
                    this.actual.colaCancelados.Enqueue(pedidoAguardar);
                    estabaSiendoPreparado = true;
                }
            }
            if (estabaSiendoPreparado == false)
            {
                eliminarDeColaPreparacion(pedidoCancelado.id, pedidoCancelado.tipoPedidoCancelado, pedidoCancelado.empleadoDesignado);
            }

            setearProximaCancelacion();
           
            
            
                        
        }

       

        public void eliminarDeColaPreparacion(int id, string tipoPedidoCancelado, string empleadoDesignado)
        {
            Queue<Pedido> nuevaCola = new Queue<Pedido>();
            if( empleadoDesignado == "Empleado 1")
            {
                foreach (Pedido pedido in this.anterior.ColaEmpleado1)
                {
                    if (pedido.id != id)
                    {
                        nuevaCola.Enqueue(pedido);
                    }
                }
                this.actual.ColaEmpleado1.Clear();
                int i = 0;
                while (i < nuevaCola.Count())
                {
                    this.actual.ColaEmpleado1.Enqueue(nuevaCola.Dequeue());
                    i++;
                }
            }
            else if (empleadoDesignado == "Empleado 2")
            {
                foreach (Pedido pedido in this.anterior.ColaEmpleado2)
                {
                    if (pedido.id != id)
                    {
                        nuevaCola.Enqueue(pedido);
                    }
                }
                this.actual.ColaEmpleado2.Clear();
                int i = 0;
                while (i < nuevaCola.Count())
                {
                    this.actual.ColaEmpleado2.Enqueue(nuevaCola.Dequeue());
                    i++;
                }
            }
            else
            {
                foreach (Pedido pedido in this.anterior.ColaEmpleado3)
                {
                    if (pedido.id != id)
                    {
                        nuevaCola.Enqueue(pedido);
                    }
                }
                this.actual.ColaEmpleado3.Clear();
                int i = 0;
                while (i < nuevaCola.Count())
                {
                    this.actual.ColaEmpleado3.Enqueue(nuevaCola.Dequeue());
                    i++;
                }
            }

            nuevaCola.Clear();
        }

        public bool estaEnPedidosCancelados(int numeroPedido)
        {
            bool encontrado = false;
            foreach(Pedido pedido in anterior.colaCancelados)
            {
                if ( pedido.id == numeroPedido)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public bool existeUnPedidoTerminado(string ptipoPedido)
        {
            bool encontrado = false;
            foreach( Pedido item in this.actual.colaCanceladosTerminados)
            {
                if (item.tipoPedido == ptipoPedido)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }

        public void sacarPedidoDeColaTerminados(string tipoPedido) 
        {
            int idDelPedidoAsacar = 0;
            foreach (Pedido item in this.actual.colaCanceladosTerminados)
            {
                if(item.tipoPedido == tipoPedido)
                {
                    idDelPedidoAsacar = item.id;
                    break;
                }
            }
            eliminarDeColaCanceladosTerminados(idDelPedidoAsacar);
        }

        public void eliminarDeColaCanceladosTerminados(int idDelPedidoAsacar)
        {
            Queue<Pedido> nuevaCola = new Queue<Pedido>();
            
                foreach (Pedido pedido in this.anterior.colaCanceladosTerminados)
                {
                    if (pedido.id != idDelPedidoAsacar)
                    {
                        nuevaCola.Enqueue(pedido);
                    }
                }
                this.actual.colaCanceladosTerminados.Clear();
                int i = 0;
                while (i < nuevaCola.Count())
                {
                    this.actual.colaCanceladosTerminados.Enqueue(nuevaCola.Dequeue());
                    i++;
                }
        }
        public void pasarPedidoAColaDelivery(int id, string tipoPedido)
        {
            Pedido pedidoParaEntrega = new Pedido(id, tipoPedido);
            if (anterior.estadoDelivery == "Libre" || anterior.estadoDelivery == "En espera") // si estaba libre o en espera 
            {
                if (anterior.MochilaDelivery.Count() == 2)
                {
                    actual.MochilaDelivery.Enqueue(pedidoParaEntrega);
                    this.actual.estadoDelivery = "Ocupado"; // cambia su estado a ocupado cuando se llena su mochila es decir que salio a repartir y genera los tiempos
                    this.actual.rndEntregaPedido = Math.Truncate(rnd.NextDouble() * 100) / 100; // se genera un numero aleatorio
                    double tiempoPreparacion = this.actual.GenerartiempoEntrega(this.actual.rndEntregaPedido); // se genera el tiempo entre entregas
                    this.actual.tiempoEntregaPedido = tiempoPreparacion;
                    this.actual.proximaFinEntregaPedido = this.actual.reloj + this.actual.tiempoEntregaPedido; // se setea el proximo fin entrega
                    pedidosEntregando = "";
                    foreach (Pedido pedidoEnMochila in actual.MochilaDelivery)  // se setean los pedidos que se estan entregando
                    {
                        pedidosEntregando += pedidoEnMochila.id + "_";
                    }
                    actual.MochilaDelivery.Clear();


                }
                else
                {
                    actual.MochilaDelivery.Enqueue(pedidoParaEntrega);
                    actual.rndEntregaPedido = 0;
                    actual.tiempoEntregaPedido = 0;
                }




            }
            else if (anterior.estadoDelivery == "Ocupado")
            {
                if (anterior.MochilaDelivery.Count() < 3)
                {
                    actual.MochilaDelivery.Enqueue(pedidoParaEntrega);
                }
                else
                {
                    actual.ColaDelivery.Enqueue(pedidoParaEntrega);
                }
                actual.rndEntregaPedido = 0;
                actual.tiempoEntregaPedido = 0;

            }
        }

        public void contarPedidoEnHora(double reloj, string evento, int diaActual,int diaAnterior)
        {
            if (evento == "llegada_Pedido" && reloj <= 840 && diaActual == diaAnterior )
            {
                contadorDeTodasLosPedidos += 1;

                if(reloj >= 480 && reloj < 540)
                {
                    contador8a9 += 1;
                }
                if (reloj >= 540 && reloj < 600)
                {
                    contador9a10 += 1;
                }
                if (reloj >= 600 && reloj < 660)
                {
                    contador10a11 += 1;
                }
                if (reloj >= 660 && reloj < 720)
                {
                    contador11a12 += 1;
                }
                if (reloj >= 720 && reloj < 780)
                {
                    contador12a13 += 1;
                }
                if (reloj >= 780 && reloj < 840)
                {
                    contador13a14 += 1;
                }
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            //Limpiar tabla
            this.dataGridView.DataSource = null;
            this.dataGridView.Rows.Clear();
            this.tabla.Clear();
            this.tabla.Columns.Clear();
            this.pedidosEntregando = "";
            this.labelDeCarga.Text = "Cargando...";
            this.labelDeCarga.ForeColor = Color.Black;
            this.pictureBox1.Visible = false;
        }

        public void setearResultados()
        {
            this.txt8a9.Text = (Math.Round((contador8a9 / contadorDeTodasLosPedidos)*100,2)).ToString()+" %";
            this.txt9a10.Text = (Math.Round((contador9a10 / contadorDeTodasLosPedidos) * 100, 2)).ToString() + " %";
            this.txt10a11.Text = (Math.Round((contador10a11 / contadorDeTodasLosPedidos) * 100, 2)).ToString() + " %";
            this.txt11a12.Text = (Math.Round((contador11a12 / contadorDeTodasLosPedidos) * 100, 2)).ToString() + " %";
            this.txt12a13.Text = (Math.Round((contador12a13 / contadorDeTodasLosPedidos) * 100, 2)).ToString() + " %";
            this.txt13a14.Text = (Math.Round((contador13a14 / contadorDeTodasLosPedidos) * 100, 2)).ToString() + " %";
        }

        private void chk_calcularEuler_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_calcularEuler.Checked == true)
            {
                h.Visible = true;
                txtPasoH.Visible = true;
                txtPasoH.Text = "0.05";
                txtLimiteA_PrepPizza.Enabled = false;
                txtLimiteB_PrepPizza.Enabled = false;
            }
            else
            {
                h.Visible = false;
                txtPasoH.Visible = false;
                txtPasoH.Text = "";
                txtLimiteA_PrepPizza.Enabled = true;
                txtLimiteB_PrepPizza.Enabled = true;
            }
        }
    }
    
}
