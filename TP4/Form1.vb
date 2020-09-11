Public Class Form1

    Dim cant_dias As Integer
    Dim cant_frascos_compra As Integer
    Dim peso_frasco As Double
    Dim precio_compra_frasco As Double
    Dim precio_Venta_Frasco As Double
    Dim media_normal_mña As Double
    Dim desv_normal_mña As Double
    Dim media_exp_Tarde As Double
    Dim capacidadMaxima As Double
    Dim dia_falta_llegada_pedido As Double
    Dim cantVendida As Double
    Dim dias_llegadaPedido As Integer = 0
    Dim llegaPedido As Boolean = 0
    Dim dias_prox_pedido As Integer = 0
    Dim gr_llegaron As Double = 0
    Dim cant_Frascos As Double = 0
    Dim stock_inicio_dia As Double = 0
    Dim stock_disponible_dia As Double = 0
    Dim stockFinalDia As Double = 0
    Dim stockDiaAnterior As Double = 0
    Dim stockPromedioDiario As Double = 0
    Dim stockAcumulado As Double = 0
    Dim promedioCantidadCafeFaltante As Double = 0
    Dim promedioIngresoDiario As Double = 0
    Dim ingresoDiarioAcumulado As Double = 0
    Dim beneficioDiarioAcumulado As Double = 0
    Dim promedioBeneficioDiario As Double = 0
    Dim cantidadDiasConFaltante As Double = 0
    Dim cantidadDias2Frascos As Double = 0
    Dim cantidadDias2y5Frascos As Double = 0
    Dim cantidadDias5y8Frascos As Double = 0
    Dim cantidadDias8Frascos As Double = 0
    Dim xCongruencialAnterior As Double = 0
    Dim var_aleatoria_pedido As Double = 0
    Dim var_aleatoria_demanda_mña As Double = 0
    Dim var_aleatoria_demanda_Tarde As Double = 0
    Dim x1 As Double = 0
    Dim semilla As Double = 0
    Dim c As Double = 0
    Dim a As Double = 0
    Dim m As Double = 0
    Dim sumaHorasFaltante As Double = 0
    Dim sumaDiasSinStockFinal As Double = 0
    Dim RNDPedido As New Random
    Dim random_Demanda_Mañana As New Random()
    Dim random_Demanda_Tarde As New Random()
    Dim random_pedido As New Random()
    Dim perdidaDiariaFaltante As Double = 0
    Dim valoresAnteriores(2) As Double

    Dim flagP As Integer = 0
    Dim flagIntervalos As Integer = 0

    ' Boton Generar onClick
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim tabla As New DataTable()
        Dim tablaSoporte As New DataTable()

        tabla.Columns.Add("Dia")
        tabla.Columns.Add("Stock al Inicio")
        tabla.Columns.Add("Llega Pedido")
        tabla.Columns.Add("Frascos Comprados")
        tabla.Columns.Add("Gr Comprados")
        tabla.Columns.Add("RND PEDIDO")
        tabla.Columns.Add("Dias Para Prox Pedido")
        tabla.Columns.Add("Dias para Llegada Pedido")
        tabla.Columns.Add("Stock del Dia")
        tabla.Columns.Add("RND Demanda Mañana")
        tabla.Columns.Add("Demanda Mañana")
        tabla.Columns.Add("RND Demanda Tarde")
        tabla.Columns.Add("Demanda Tarde")
        tabla.Columns.Add("Demanda Total")
        tabla.Columns.Add("Cantidad Vendida")
        tabla.Columns.Add("Faltante")
        tabla.Columns.Add("Stock Final Dia")
        tabla.Columns.Add("Stock Promedio Diario")
        tabla.Columns.Add("Promedio Gramos Faltante")
        tabla.Columns.Add("Ingreso Diario")
        tabla.Columns.Add("Perdida Diaria Faltante")
        tabla.Columns.Add("Promedio Diario Ingreso Diario")
        tabla.Columns.Add("Beneficio Diario")
        tabla.Columns.Add("Beneficio Diario Promedio")
        tabla.Columns.Add("Cantidad Frascos Almacenados")


        tablaSoporte.Columns.Add("Dia")
        tablaSoporte.Columns.Add("Stock al Inicio")
        tablaSoporte.Columns.Add("Llega Pedido")
        tablaSoporte.Columns.Add("Frascos Comprados")
        tablaSoporte.Columns.Add("Gr Comprados")
        tablaSoporte.Columns.Add("RND PEDIDO")
        tablaSoporte.Columns.Add("Dias Para Prox Pedido")
        tablaSoporte.Columns.Add("Dias para Llegada Pedido")
        tablaSoporte.Columns.Add("Stock del Dia")
        tablaSoporte.Columns.Add("RND Demanda Mañana")
        tablaSoporte.Columns.Add("Demanda Mañana")
        tablaSoporte.Columns.Add("RND Demanda Tarde")
        tablaSoporte.Columns.Add("Demanda Tarde")
        tablaSoporte.Columns.Add("Demanda Total")
        tablaSoporte.Columns.Add("Cantidad Vendida")
        tablaSoporte.Columns.Add("Faltante")
        tablaSoporte.Columns.Add("Stock Final Dia")
        tablaSoporte.Columns.Add("Stock Promedio Diario")
        tablaSoporte.Columns.Add("Promedio Gramos Faltante")
        tablaSoporte.Columns.Add("Ingreso Diario")
        tablaSoporte.Columns.Add("Perdida Diaria Faltante")
        tablaSoporte.Columns.Add("Promedio Diario Ingreso Diario")
        tablaSoporte.Columns.Add("Beneficio Diario")
        tablaSoporte.Columns.Add("Beneficio Diario Promedio")
        tablaSoporte.Columns.Add("Cantidad Frascos Almacenados")

        'Si todos los campos estan llenos, empieza el programa
        If validar_Campos() Then

            ' Tomamos los datos necesarios por parametro
            cant_dias = TxtCantDiaSimulacion.Text
            peso_frasco = txtPesoFrasco.Text
            precio_compra_frasco = TxtPrecioCompraFrasco.Text
            precio_Venta_Frasco = txtPrecioVentaFrasco.Text
            media_normal_mña = TxtMediaNormalMña.Text
            desv_normal_mña = TxtDesvNormalMedia.Text
            media_exp_Tarde = TxtMediaExpTarde.Text
            capacidadMaxima = txtCapacidadMaxima.Text
            ProgressBar1.Maximum = cant_dias
            flagP = cant_dias * 0.01
            ' La cantidad minima de dias es de DIEZ MIL, se usa 5 a modo de prueba, CAMBIAR!!
            If cant_dias >= 5 Then

                Dim puedeIniciar As Boolean = False
                Dim esAleatorio As Boolean = False

                ' Validamos que se selecciono la opcion de numeros aleatorios por sistema
                If rdbAleatorio.Checked = True Then
                    puedeIniciar = True
                    esAleatorio = True
                Else
                    ' Si no, que valide si se selecciono la opcion Congruencial
                    If RdbCongruencial.Checked = True Then
                        If validarCamposCongruencial() = True Then
                            puedeIniciar = True
                            esAleatorio = False
                            semilla = txtSemilla.Text
                            c = Double.Parse(txtC.Text)
                            a = Double.Parse(txtA.Text)
                            m = Double.Parse(txtM.Text)
                            x1 = Double.Parse(semilla)
                        Else
                            puedeIniciar = False
                            MsgBox("Por favor, ingrese los parámetros del generador")
                        End If
                    End If
                End If

                For Each c As DataGridViewColumn In DgvMontecarlo.Columns
                    c.DataPropertyName = c.HeaderText
                Next

                For Each c As DataGridViewColumn In dgvSoporte.Columns
                    c.DataPropertyName = c.HeaderText
                Next



                ' Si podemos iniciar, empezamos el for que va a iterar todas las filas de la tabla
                If puedeIniciar = True Then
                    For i = 0 To cant_dias

                        If esAleatorio = True Then
                            ' Variables aleatorias Random
                            var_aleatoria_demanda_mña = random_Demanda_Mañana.NextDouble()
                            var_aleatoria_demanda_Tarde = random_Demanda_Tarde.NextDouble()
                            var_aleatoria_pedido = 0

                            ' Genero una variable aleatoria de pedido cuando tengo que hacer un pedido
                            If dias_prox_pedido = 0 Then
                                var_aleatoria_pedido = random_pedido.NextDouble()
                            End If
                        Else
                            ' Variables aleatorias congruenciales
                            var_aleatoria_demanda_mña = congruencial(x1)
                            var_aleatoria_demanda_Tarde = congruencial(x1)
                            var_aleatoria_pedido = 0

                            ' Genero una variable aleatoria de pedido cuando tengo que hacer un pedido
                            If dias_prox_pedido = 0 Then
                                var_aleatoria_pedido = congruencial(x1)
                            End If
                        End If

                        ' Declaro valores de las columnas de la tabla (empiezan en 0 por cada fila)
                        Dim DemandaMañana As Double = 0
                        Dim DemandaTarde As Double = 0
                        Dim DemandaTotal As Double = 0
                        Dim Cant_Vendida As Double = 0
                        Dim cant_Faltante As Double = 0
                        Dim cantidadFaltanteDiaAnterior As Double = 0
                        Dim Stock_Final As Double = 0
                        Dim stock_Promedio_Diario As Double = 0
                        Dim gramos_faltantes_prom As Double = 0
                        Dim cant_dias_pedido As Double = 0
                        Dim ingresoDiario As Double = 0
                        Dim ingresoDiarioDiaAnterior As Double = 0
                        Dim beneficioDiario = 0
                        Dim cantidadFrascosAlmacenados As Double = 0

                        ' Si es la primera iteracion o el dia 0 seteo las variables iniciales
                        If i = 0 Then
                            stock_inicio_dia = 0
                            stock_disponible_dia = 0
                            llegaPedido = False
                            dia_falta_llegada_pedido = 1
                            stockFinalDia = 0
                            dias_prox_pedido = 2
                            cantidadFaltanteDiaAnterior = 0
                            ingresoDiarioDiaAnterior = 0
                            beneficioDiario = 0
                        Else
                            ' Si es cualquier otro dia, modifico los valores
                            stock_inicio_dia = stockFinalDia

                            If dia_falta_llegada_pedido = 1 Then
                                llegaPedido = True
                                dia_falta_llegada_pedido = 0
                            ElseIf dia_falta_llegada_pedido = 0 Then
                                dia_falta_llegada_pedido = 0
                                llegaPedido = False
                            Else
                                dia_falta_llegada_pedido = dia_falta_llegada_pedido - 1
                                llegaPedido = False
                            End If

                            ' La mitad de las veces el pedido llega al instante. El resto, el 25% tarda 1 dia, y el otro
                            ' 25% tarda 2 días
                            If dias_prox_pedido = 0 Then

                                If var_aleatoria_pedido < 0.5 Then
                                    dia_falta_llegada_pedido = 0
                                    llegaPedido = True

                                ElseIf var_aleatoria_pedido < 0.74 And var_aleatoria_pedido >= 0.5 Then

                                    dia_falta_llegada_pedido = 1

                                Else
                                    dia_falta_llegada_pedido = 2

                                End If

                                dias_prox_pedido = 2
                            Else
                                dias_prox_pedido = dias_prox_pedido - 1
                            End If


                            ' Si llega un pedido, se actualizan las variables en base a la llegada del mismo
                            If llegaPedido Then
                                cant_frascos_compra = txtCantFrascos.Text

                                stock_disponible_dia = cant_frascos_compra * peso_frasco + stock_inicio_dia

                                ' Si supero el limite de frascos almacenados, regalo el excedente y el stock es el maximo
                                If (stock_disponible_dia / peso_frasco) > capacidadMaxima Then
                                    stock_disponible_dia = capacidadMaxima * peso_frasco
                                End If
                            Else
                                ' Si no llega un pedido ese dia, solo se toma el stock del dia enterior
                                cant_frascos_compra = 0
                                stock_disponible_dia = cant_frascos_compra * peso_frasco + stock_inicio_dia

                                ' Si supero el limite de frascos almacenados, regalo el excedente y el stock es el maximo
                                If (stock_disponible_dia / peso_frasco) > capacidadMaxima Then
                                    stock_disponible_dia = capacidadMaxima * peso_frasco
                                End If
                            End If

                            ' La mitad de las veces durante la mañana, la demanda es uniforme de 50g
                            If var_aleatoria_demanda_mña < 0.5 Then

                                DemandaMañana = 50

                            Else
                                ' La otra mitad de las veces, la demanda se comporta como una Dist Normal
                                Dim suma As Double

                                For j = 0 To 12

                                    suma = suma + var_aleatoria_demanda_mña

                                Next

                                DemandaMañana = ((suma - 6) * desv_normal_mña) + media_normal_mña
                                suma = 0
                            End If

                            ' Durante la tarde el consumo sigue una distribucion exponencial
                            Dim lambda As Double = 1 / media_exp_Tarde
                            Dim log As Double = Math.Log(1 - var_aleatoria_demanda_Tarde)

                            DemandaTarde = (-1 / lambda) * log

                            DemandaTotal = DemandaMañana + DemandaTarde

                            stockDiaAnterior = stockFinalDia

                            If tabla.Rows.Count > 0 Then
                                cantidadFaltanteDiaAnterior = valoresAnteriores(0)
                            Else
                                cantidadFaltanteDiaAnterior = 0
                            End If
                            ' Si la demanda es menor al stock que tengo disponible, se vende lo que se demanda y no falta nada
                            If stock_disponible_dia > DemandaTotal Then
                                cantVendida = DemandaTotal
                                cant_Faltante = 0
                                perdidaDiariaFaltante = 0
                                stockFinalDia = stock_disponible_dia - DemandaTotal
                            Else
                                ' Si la demanda es mayor a lo que tengo, puedo vender unicamente lo que tengo y me quedo sin stock
                                cantVendida = stock_disponible_dia
                                cant_Faltante = DemandaTotal - stock_disponible_dia
                                perdidaDiariaFaltante = (cant_Faltante * 100) / 100
                                stockFinalDia = 0
                            End If

                            If cant_Faltante <> 0 Then
                                cantidadDiasConFaltante += 1
                            End If

                            stockAcumulado += stockFinalDia
                            stockPromedioDiario = stockAcumulado / i
                            promedioCantidadCafeFaltante = ((cantidadFaltanteDiaAnterior * (i - 1)) + cant_Faltante) / i

                            If tabla.Rows.Count > 0 Then
                                ingresoDiarioDiaAnterior = valoresAnteriores(1)
                            Else
                                ingresoDiarioDiaAnterior = 0
                            End If
                            ingresoDiario = cantVendida * precio_Venta_Frasco / peso_frasco
                            ingresoDiarioAcumulado += ingresoDiario
                            promedioIngresoDiario = (ingresoDiarioAcumulado) / i

                            Dim costoDiario As Double = (cantVendida * precio_compra_frasco / peso_frasco)
                            beneficioDiario = ingresoDiario - costoDiario
                            beneficioDiarioAcumulado += beneficioDiario
                            promedioBeneficioDiario = beneficioDiarioAcumulado / i

                            cantidadFrascosAlmacenados = stockFinalDia / peso_frasco

                            If cantidadFrascosAlmacenados <= 2 Then
                                cantidadDias2Frascos += 1
                            End If
                            If (2 < cantidadFrascosAlmacenados And cantidadFrascosAlmacenados <= 5) Then
                                cantidadDias2y5Frascos += 1
                            End If
                            If 5 < cantidadFrascosAlmacenados And cantidadFrascosAlmacenados <= 8 Then
                                cantidadDias5y8Frascos += 1
                            End If
                            If 8 < cantidadFrascosAlmacenados Then
                                cantidadDias8Frascos += 1
                            End If

                            'Acumulo la relación de stock faltante para calcular cuantas horas no se pudo trabajar
                            If stock_disponible_dia = 0 Then
                                sumaHorasFaltante += (Double.Parse(txtCantidadHorasTurno.Text) * 2)
                            ElseIf stock_disponible_dia <= DemandaTotal And DemandaTotal > 0 Then
                                sumaHorasFaltante += ((Double.Parse(txtCantidadHorasTurno.Text) * 2) * (stock_disponible_dia / DemandaTotal))
                            End If

                            'Acumulo los días que acaban con stock igual a 0
                            If stockFinalDia = 0 Then
                                sumaDiasSinStockFinal += 1
                            End If

                        End If

                        If soloIntervalos.Checked = False Then

                            Dim fila As DataRow = tabla.NewRow()

                            fila("Dia") = i
                            fila("Stock al Inicio") = Math.Round(stock_inicio_dia, 4)
                            fila("Llega Pedido") = llegaPedido
                            fila("Frascos Comprados") = Math.Round(cant_frascos_compra, 4)
                            fila("Gr Comprados") = Math.Round(cant_frascos_compra * 170, 4)
                            fila("RND PEDIDO") = Math.Round(var_aleatoria_pedido, 4)
                            fila("Dias Para Prox Pedido") = dias_prox_pedido
                            fila("Dias para Llegada Pedido") = dia_falta_llegada_pedido
                            fila("Stock del Dia") = Math.Round(stock_disponible_dia, 4)
                            fila("RND Demanda Mañana") = Math.Round(var_aleatoria_demanda_mña, 4)
                            fila("Demanda Mañana") = Math.Round(DemandaMañana, 4)
                            fila("RND Demanda Tarde") = Math.Round(var_aleatoria_demanda_Tarde, 4)
                            fila("Demanda Tarde") = Math.Round(DemandaTarde, 4)
                            fila("Demanda Total") = Math.Round(DemandaTotal, 4)
                            fila("Cantidad Vendida") = Math.Round(cantVendida, 4)
                            fila("Faltante") = Math.Round(cant_Faltante, 4)
                            fila("Stock Final Dia") = Math.Round(stockFinalDia, 4)
                            fila("Stock Promedio Diario") = Math.Round(stockPromedioDiario, 4)
                            fila("Promedio Gramos Faltante") = Math.Round(promedioCantidadCafeFaltante, 4)
                            fila("Ingreso Diario") = Math.Round(ingresoDiario, 4)
                            fila("Perdida Diaria Faltante") = Math.Round(perdidaDiariaFaltante, 4)
                            fila("Promedio Diario Ingreso Diario") = Math.Round(promedioIngresoDiario, 4)
                            fila("Beneficio Diario") = Math.Round(beneficioDiario, 4)
                            fila("Beneficio Diario Promedio") = Math.Round(promedioBeneficioDiario, 4)
                            fila("Cantidad Frascos Almacenados") = Math.Round(cantidadFrascosAlmacenados, 4)

                            tabla.Rows.Add(fila)

                            valoresAnteriores(0) = cant_Faltante
                            valoresAnteriores(1) = ingresoDiario

                        Else
                            If flagIntervalos = 10000 Or flagIntervalos = 9999 Then
                                Dim fila As DataRow = tabla.NewRow()

                                fila("Dia") = i
                                fila("Stock al Inicio") = Math.Round(stock_inicio_dia, 4)
                                fila("Llega Pedido") = llegaPedido
                                fila("Frascos Comprados") = Math.Round(cant_frascos_compra, 4)
                                fila("Gr Comprados") = Math.Round(cant_frascos_compra * 170, 4)
                                fila("RND PEDIDO") = Math.Round(var_aleatoria_pedido, 4)
                                fila("Dias Para Prox Pedido") = dias_prox_pedido
                                fila("Dias para Llegada Pedido") = dia_falta_llegada_pedido
                                fila("Stock del Dia") = Math.Round(stock_disponible_dia, 4)
                                fila("RND Demanda Mañana") = Math.Round(var_aleatoria_demanda_mña, 4)
                                fila("Demanda Mañana") = Math.Round(DemandaMañana, 4)
                                fila("RND Demanda Tarde") = Math.Round(var_aleatoria_demanda_Tarde, 4)
                                fila("Demanda Tarde") = Math.Round(DemandaTarde, 4)
                                fila("Demanda Total") = Math.Round(DemandaTotal, 4)
                                fila("Cantidad Vendida") = Math.Round(cantVendida, 4)
                                fila("Faltante") = Math.Round(cant_Faltante, 4)
                                fila("Stock Final Dia") = Math.Round(stockFinalDia, 4)
                                fila("Stock Promedio Diario") = Math.Round(stockPromedioDiario, 4)
                                fila("Promedio Gramos Faltante") = Math.Round(promedioCantidadCafeFaltante, 4)
                                fila("Ingreso Diario") = Math.Round(ingresoDiario, 4)
                                fila("Perdida Diaria Faltante") = Math.Round(perdidaDiariaFaltante, 4)
                                fila("Promedio Diario Ingreso Diario") = Math.Round(promedioIngresoDiario, 4)
                                fila("Beneficio Diario") = Math.Round(beneficioDiario, 4)
                                fila("Beneficio Diario Promedio") = Math.Round(promedioBeneficioDiario, 4)
                                fila("Cantidad Frascos Almacenados") = Math.Round(cantidadFrascosAlmacenados, 4)

                                tabla.Rows.Add(fila)

                                valoresAnteriores(0) = cant_Faltante
                                valoresAnteriores(1) = ingresoDiario

                                If flagIntervalos = 10000 Then
                                    flagIntervalos = 0
                                End If
                            End If
                        End If


                        ' Creo una tabla que muestre desde un Día ingresado por parametro, hasta 50 dias mas
                        If (i >= Double.Parse(txtMostrarDesde.Text)) And (i <= (Double.Parse(txtMostrarDesde.Text) + 50)) Then



                            Dim fila2 As DataRow = tablaSoporte.NewRow()

                            fila2("Dia") = i
                            fila2("Stock al Inicio") = Math.Round(stock_inicio_dia, 4)
                            fila2("Llega Pedido") = llegaPedido
                            fila2("Frascos Comprados") = Math.Round(cant_frascos_compra, 4)
                            fila2("Gr Comprados") = Math.Round(cant_frascos_compra * 170, 4)
                            fila2("RND PEDIDO") = Math.Round(var_aleatoria_pedido, 4)
                            fila2("Dias Para Prox Pedido") = dias_prox_pedido
                            fila2("Dias para Llegada Pedido") = dia_falta_llegada_pedido
                            fila2("Stock del Dia") = Math.Round(stock_disponible_dia, 4)
                            fila2("RND Demanda Mañana") = Math.Round(var_aleatoria_demanda_mña, 4)
                            fila2("Demanda Mañana") = Math.Round(DemandaMañana, 4)
                            fila2("RND Demanda Tarde") = Math.Round(var_aleatoria_demanda_Tarde, 4)
                            fila2("Demanda Tarde") = Math.Round(DemandaTarde, 4)
                            fila2("Demanda Total") = Math.Round(DemandaTotal, 4)
                            fila2("Cantidad Vendida") = Math.Round(cantVendida, 4)
                            fila2("Faltante") = Math.Round(cant_Faltante, 4)
                            fila2("Stock Final Dia") = Math.Round(stockFinalDia, 4)
                            fila2("Stock Promedio Diario") = Math.Round(stockPromedioDiario, 4)
                            fila2("Promedio Gramos Faltante") = Math.Round(promedioCantidadCafeFaltante, 4)
                            fila2("Ingreso Diario") = Math.Round(ingresoDiario, 4)
                            fila2("Perdida Diaria Faltante") = Math.Round(perdidaDiariaFaltante, 4)
                            fila2("Promedio Diario Ingreso Diario") = Math.Round(promedioIngresoDiario, 4)
                            fila2("Beneficio Diario") = Math.Round(beneficioDiario, 4)
                            fila2("Beneficio Diario Promedio") = Math.Round(promedioBeneficioDiario, 4)
                            fila2("Cantidad Frascos Almacenados") = Math.Round(cantidadFrascosAlmacenados, 4)

                            tablaSoporte.Rows.Add(fila2)




                        End If
                        If i = flagP Then
                            ProgressBar1.Increment(flagP)
                            progreso.Text = ((ProgressBar1.Value * 100) / ProgressBar1.Maximum).ToString() + "%"
                            progreso.Refresh()
                            flagP = flagP + ProgressBar1.Maximum * 0.01
                        End If

                        flagIntervalos += 1
                    Next

                    DgvMontecarlo.DataSource = tabla
                    DgvMontecarlo.Refresh()

                    dgvSoporte.DataSource = tablaSoporte
                    dgvSoporte.Refresh()

                    Dim porcentaje As Double = Math.Round(cantidadDiasConFaltante * 100 / cant_dias, 2)
                    Dim porcentajeDias2Frascos As Double = Math.Round(cantidadDias2Frascos * 100 / cant_dias, 2)
                    Dim porcentajeDias2y5Frascos As Double = Math.Round(cantidadDias2y5Frascos * 100 / cant_dias, 2)
                    Dim porcentajeDias5y8Frascos As Double = Math.Round(cantidadDias5y8Frascos * 100 / cant_dias, 2)
                    Dim porcentajeDias8Frascos As Double = Math.Round(cantidadDias8Frascos * 100 / cant_dias, 2)
                    txtPorcentajeDiasFaltante.Text = porcentaje.ToString + " %"
                    txtPorcentaje2Frascos.Text = porcentajeDias2Frascos.ToString + " %"
                    txtPorcentaje2y5Frascos.Text = porcentajeDias2y5Frascos.ToString + " %"
                    txtPorcentaje5y8Frascos.Text = porcentajeDias5y8Frascos.ToString + " %"
                    txtPorcentaje8Frascos.Text = porcentajeDias8Frascos.ToString + " %"
                    txtPromedioHorasPerdidas.Text = Math.Round(sumaHorasFaltante / cant_dias, 2)
                    txtPromedioDiasSinStock.Text = (Math.Round(sumaDiasSinStockFinal * 100 / cant_dias, 2)).ToString + " %"

                    If ((sumaDiasSinStockFinal * 100 / cant_dias) > 10) Then
                        txtConclusionDiasSinStock.Text = "No se consigue que al menos el 90% de los días tenga stock al final del día"
                    Else
                        txtConclusionDiasSinStock.Text = "Se consigue que al menos el 90% de los días tenga stock al final del día"
                    End If

                Else
                        MsgBox("Por favor, ingrese los parámetros del método congruencial")
                End If

            Else
                MsgBox("La cantidad mínima de días para la Simulación es de 10.000")
            End If
        Else
            MsgBox("Por favor, ingrese todos los campos requeridos")
        End If
    End Sub

    Public Function ListaDemandaNormal(ByVal cant As Integer, ByVal media As Double, ByVal desv As Double) As List(Of Double)
        Dim lista As List(Of Double)
        Dim z As Double
        Dim suma As Double
        ' Genero una lista de numeros aleatorios que siguen una distribucion Normal
        For i = 0 To cant
            For j = 0 To 12
                suma = suma + Rnd()
            Next
            z = ((suma - 6) * desv) + media
            lista.Add(z)
        Next
        Return lista
    End Function

    Private Function validar_Campos() As Boolean
        Dim validacion As Boolean
        If (txtCantFrascos.Text = "" Or txtPesoFrasco.Text = "" Or TxtMediaNormalMña.Text = "" Or TxtDesvNormalMedia.Text = "" Or TxtMediaExpTarde.Text = "" Or TxtCantDiaSimulacion.Text = "" Or TxtPrecioCompraFrasco.Text = "" Or (rdbAleatorio.Checked = False And RdbCongruencial.Checked = False)) Then
            validacion = False
        Else
            validacion = True
        End If
        Return validacion
    End Function

    Private Function validarCamposCongruencial() As Boolean
        Dim validacion As Boolean
        If (txtSemilla.Text = "" Or txtA.Text = "" Or txtC.Text = "" Or txtM.Text = "") Then
            validacion = False
        Else
            validacion = True
        End If
        Return validacion
    End Function

    ' Evento LOAD del formulario, seteo variables por defecto
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarEjemplo()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCantFrascos.Text = ""
        txtPesoFrasco.Text = ""
        TxtMediaNormalMña.Text = ""
        TxtDesvNormalMedia.Text = ""
        TxtMediaExpTarde.Text = ""
        TxtCantDiaSimulacion.Text = ""
        txtMostrarDesde.Text = ""
        CType(DgvMontecarlo.DataSource, DataTable).Clear()
        CType(dgvSoporte.DataSource, DataTable).Clear()
        TxtPrecioCompraFrasco.Text = ""
        txtPrecioVentaFrasco.Text = ""
        txtCapacidadMaxima.Text = ""
        txtCantidadHorasTurno.Text = ""
        txtSemilla.Text = ""
        txtA.Text = ""
        txtC.Text = ""
        txtM.Text = ""
        sumaDiasSinStockFinal = 0
        sumaHorasFaltante = 0
        cantidadDias2Frascos = 0
        cantidadDias2y5Frascos = 0
        cantidadDias5y8Frascos = 0
        cantidadDiasConFaltante = 0
        flagP = 0
        ProgressBar1.Value = 0
        progreso.Text = "0%"
        flagIntervalos = 0

    End Sub

    Private Sub RdbCongruencial_CheckedChanged(sender As Object, e As EventArgs) Handles RdbCongruencial.CheckedChanged
        If RdbCongruencial.Checked = True Then
            grbCongruencial.Visible = True
        Else
            grbCongruencial.Visible = False
        End If
    End Sub

    Private Function congruencial(number As Double) As Double
        x1 = (c + a * number) Mod m
        'x1 = (x1 / (m - 1))
        Return (x1 / (m - 1))
    End Function

    Private Function cargarEjemplo()
        txtCantFrascos.Text = 2
        txtPesoFrasco.Text = 170
        TxtPrecioCompraFrasco.Text = 250
        txtPrecioVentaFrasco.Text = 255
        TxtMediaNormalMña.Text = 75
        TxtDesvNormalMedia.Text = 15
        TxtMediaExpTarde.Text = 70
        TxtCantDiaSimulacion.Text = 10000
        txtCapacidadMaxima.Text = 10
        grbCongruencial.Visible = False
        txtCantidadHorasTurno.Text = 8
        txtMostrarDesde.Text = 0
        txtSemilla.Text = 37
        txtC.Text = 43
        txtA.Text = 13
        txtM.Text = 101
        rdbAleatorio.Checked = True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cargarEjemplo()
    End Sub

    Private Sub DgvMontecarlo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMontecarlo.CellContentClick

    End Sub
End Class