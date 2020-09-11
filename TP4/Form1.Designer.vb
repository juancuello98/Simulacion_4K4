<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grbCongruencial = New System.Windows.Forms.GroupBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSemilla = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtCantidadHorasTurno = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCantDiaSimulacion = New System.Windows.Forms.TextBox()
        Me.txtMostrarDesde = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RdbCongruencial = New System.Windows.Forms.RadioButton()
        Me.rdbAleatorio = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtMediaExpTarde = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtDesvNormalMedia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMediaNormalMña = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCapacidadMaxima = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPrecioVentaFrasco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecioCompraFrasco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPesoFrasco = New System.Windows.Forms.TextBox()
        Me.txtCantFrascos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DgvMontecarlo = New System.Windows.Forms.DataGridView()
        Me.Dia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Llega_Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frascos_Comprados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gr_Comprados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rnd_Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Falta_Prox_Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dias_Llegada_Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Dia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rnd_Demanda_Mañana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Demanda_Mña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RND_Demanda_Tarde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Demanda_Tarde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Demanda_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_Vendida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_Faltante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Final_Dia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Promedio_Diario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gramos_Falantes_Promedio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresoDiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perdida_Diaria_Faltante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromedioDiarioIngresoDiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeneficioDiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeneficioDiarioPromedio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadFrascosAlmacenados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPromedioDiasSinStock = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtPromedioHorasPerdidas = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPorcentajeDiasFaltante = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtConclusionDiasSinStock = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje8Frascos = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje5y8Frascos = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje2y5Frascos = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje2Frascos = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvSoporte = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.progreso = New System.Windows.Forms.Label()
        Me.soloIntervalos = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.grbCongruencial.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvMontecarlo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.grbCongruencial)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1288, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros"
        '
        'grbCongruencial
        '
        Me.grbCongruencial.Controls.Add(Me.txtA)
        Me.grbCongruencial.Controls.Add(Me.Label27)
        Me.grbCongruencial.Controls.Add(Me.txtM)
        Me.grbCongruencial.Controls.Add(Me.Label26)
        Me.grbCongruencial.Controls.Add(Me.txtC)
        Me.grbCongruencial.Controls.Add(Me.Label25)
        Me.grbCongruencial.Controls.Add(Me.txtSemilla)
        Me.grbCongruencial.Controls.Add(Me.Label24)
        Me.grbCongruencial.Location = New System.Drawing.Point(243, 105)
        Me.grbCongruencial.Name = "grbCongruencial"
        Me.grbCongruencial.Size = New System.Drawing.Size(238, 81)
        Me.grbCongruencial.TabIndex = 18
        Me.grbCongruencial.TabStop = False
        Me.grbCongruencial.Text = "Variables Método Congruencial"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(158, 50)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(62, 20)
        Me.txtA.TabIndex = 21
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(138, 53)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 13)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "A"
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(158, 21)
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(62, 20)
        Me.txtM.TabIndex = 19
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(138, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(16, 13)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "M"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(54, 50)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(62, 20)
        Me.txtC.TabIndex = 17
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(34, 53)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "C"
        '
        'txtSemilla
        '
        Me.txtSemilla.Location = New System.Drawing.Point(54, 21)
        Me.txtSemilla.Name = "txtSemilla"
        Me.txtSemilla.Size = New System.Drawing.Size(62, 20)
        Me.txtSemilla.TabIndex = 15
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Semilla"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtCantidadHorasTurno)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.TxtCantDiaSimulacion)
        Me.GroupBox8.Controls.Add(Me.txtMostrarDesde)
        Me.GroupBox8.Location = New System.Drawing.Point(706, 20)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(256, 113)
        Me.GroupBox8.TabIndex = 17
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Simulación"
        '
        'txtCantidadHorasTurno
        '
        Me.txtCantidadHorasTurno.Location = New System.Drawing.Point(156, 74)
        Me.txtCantidadHorasTurno.Name = "txtCantidadHorasTurno"
        Me.txtCantidadHorasTurno.Size = New System.Drawing.Size(84, 20)
        Me.txtCantidadHorasTurno.TabIndex = 13
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(57, 74)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(93, 26)
        Me.Label29.TabIndex = 12
        Me.Label29.Text = "Cantidad de horas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de cada turno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad de Dias a simular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Mostrar a partir del dia"
        '
        'TxtCantDiaSimulacion
        '
        Me.TxtCantDiaSimulacion.Location = New System.Drawing.Point(156, 20)
        Me.TxtCantDiaSimulacion.Name = "TxtCantDiaSimulacion"
        Me.TxtCantDiaSimulacion.Size = New System.Drawing.Size(84, 20)
        Me.TxtCantDiaSimulacion.TabIndex = 9
        '
        'txtMostrarDesde
        '
        Me.txtMostrarDesde.Location = New System.Drawing.Point(156, 46)
        Me.txtMostrarDesde.Name = "txtMostrarDesde"
        Me.txtMostrarDesde.Size = New System.Drawing.Size(84, 20)
        Me.txtMostrarDesde.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(985, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(280, 28)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "CARGAR EJEMPLO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RdbCongruencial)
        Me.GroupBox6.Controls.Add(Me.rdbAleatorio)
        Me.GroupBox6.Location = New System.Drawing.Point(243, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(238, 80)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Metodo de Variable Aleatoria"
        '
        'RdbCongruencial
        '
        Me.RdbCongruencial.AutoSize = True
        Me.RdbCongruencial.Location = New System.Drawing.Point(21, 45)
        Me.RdbCongruencial.Name = "RdbCongruencial"
        Me.RdbCongruencial.Size = New System.Drawing.Size(126, 17)
        Me.RdbCongruencial.TabIndex = 1
        Me.RdbCongruencial.TabStop = True
        Me.RdbCongruencial.Text = "Metodo Congruencial"
        Me.RdbCongruencial.UseVisualStyleBackColor = True
        '
        'rdbAleatorio
        '
        Me.rdbAleatorio.AutoSize = True
        Me.rdbAleatorio.Location = New System.Drawing.Point(21, 20)
        Me.rdbAleatorio.Name = "rdbAleatorio"
        Me.rdbAleatorio.Size = New System.Drawing.Size(105, 17)
        Me.rdbAleatorio.TabIndex = 0
        Me.rdbAleatorio.TabStop = True
        Me.rdbAleatorio.Text = "Metodo Aleatorio"
        Me.rdbAleatorio.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtMediaExpTarde)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(487, 106)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(213, 80)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Distribución Exponencial -  Turno Tarde"
        '
        'TxtMediaExpTarde
        '
        Me.TxtMediaExpTarde.Location = New System.Drawing.Point(84, 34)
        Me.TxtMediaExpTarde.Name = "TxtMediaExpTarde"
        Me.TxtMediaExpTarde.Size = New System.Drawing.Size(84, 20)
        Me.TxtMediaExpTarde.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Media"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtDesvNormalMedia)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtMediaNormalMña)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(487, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(213, 79)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Distribución Normal - Turno Mañana"
        '
        'TxtDesvNormalMedia
        '
        Me.TxtDesvNormalMedia.Location = New System.Drawing.Point(84, 47)
        Me.TxtDesvNormalMedia.Name = "TxtDesvNormalMedia"
        Me.TxtDesvNormalMedia.Size = New System.Drawing.Size(84, 20)
        Me.TxtDesvNormalMedia.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Desviacion"
        '
        'TxtMediaNormalMña
        '
        Me.TxtMediaNormalMña.Location = New System.Drawing.Point(84, 20)
        Me.TxtMediaNormalMña.Name = "TxtMediaNormalMña"
        Me.TxtMediaNormalMña.Size = New System.Drawing.Size(84, 20)
        Me.TxtMediaNormalMña.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Media"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCapacidadMaxima)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtPrecioVentaFrasco)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioCompraFrasco)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtPesoFrasco)
        Me.GroupBox2.Controls.Add(Me.txtCantFrascos)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 167)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Frascos de café"
        '
        'txtCapacidadMaxima
        '
        Me.txtCapacidadMaxima.Location = New System.Drawing.Point(120, 124)
        Me.txtCapacidadMaxima.Name = "txtCapacidadMaxima"
        Me.txtCapacidadMaxima.Size = New System.Drawing.Size(84, 20)
        Me.txtCapacidadMaxima.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(18, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Capacidad máxima"
        '
        'txtPrecioVentaFrasco
        '
        Me.txtPrecioVentaFrasco.Location = New System.Drawing.Point(120, 98)
        Me.txtPrecioVentaFrasco.Name = "txtPrecioVentaFrasco"
        Me.txtPrecioVentaFrasco.Size = New System.Drawing.Size(84, 20)
        Me.txtPrecioVentaFrasco.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio de Venta"
        '
        'TxtPrecioCompraFrasco
        '
        Me.TxtPrecioCompraFrasco.Location = New System.Drawing.Point(120, 72)
        Me.TxtPrecioCompraFrasco.Name = "TxtPrecioCompraFrasco"
        Me.TxtPrecioCompraFrasco.Size = New System.Drawing.Size(84, 20)
        Me.TxtPrecioCompraFrasco.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio de Compra"
        '
        'txtPesoFrasco
        '
        Me.txtPesoFrasco.Location = New System.Drawing.Point(120, 46)
        Me.txtPesoFrasco.Name = "txtPesoFrasco"
        Me.txtPesoFrasco.Size = New System.Drawing.Size(84, 20)
        Me.txtPesoFrasco.TabIndex = 3
        '
        'txtCantFrascos
        '
        Me.txtCantFrascos.Location = New System.Drawing.Point(120, 20)
        Me.txtCantFrascos.Name = "txtCantFrascos"
        Me.txtCantFrascos.Size = New System.Drawing.Size(84, 20)
        Me.txtCantFrascos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Peso (gramos)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad a Comprar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(985, 105)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(280, 28)
        Me.btnLimpiar.TabIndex = 16
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(985, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(280, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "GENERAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DgvMontecarlo
        '
        Me.DgvMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMontecarlo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dia, Me.Stock_Inicio, Me.Llega_Pedido, Me.Frascos_Comprados, Me.Gr_Comprados, Me.Rnd_Pedido, Me.Falta_Prox_Pedido, Me.Dias_Llegada_Pedido, Me.Stock_Dia, Me.Rnd_Demanda_Mañana, Me.Demanda_Mña, Me.RND_Demanda_Tarde, Me.Demanda_Tarde, Me.Demanda_Total, Me.Cantidad_Vendida, Me.Cantidad_Faltante, Me.Stock_Final_Dia, Me.Stock_Promedio_Diario, Me.Gramos_Falantes_Promedio, Me.IngresoDiario, Me.Perdida_Diaria_Faltante, Me.PromedioDiarioIngresoDiario, Me.BeneficioDiario, Me.BeneficioDiarioPromedio, Me.CantidadFrascosAlmacenados})
        Me.DgvMontecarlo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvMontecarlo.Location = New System.Drawing.Point(3, 3)
        Me.DgvMontecarlo.Name = "DgvMontecarlo"
        Me.DgvMontecarlo.Size = New System.Drawing.Size(1275, 441)
        Me.DgvMontecarlo.TabIndex = 17
        '
        'Dia
        '
        Me.Dia.HeaderText = "Dia"
        Me.Dia.Name = "Dia"
        Me.Dia.ReadOnly = True
        '
        'Stock_Inicio
        '
        Me.Stock_Inicio.HeaderText = "Stock al Inicio"
        Me.Stock_Inicio.Name = "Stock_Inicio"
        Me.Stock_Inicio.ReadOnly = True
        '
        'Llega_Pedido
        '
        Me.Llega_Pedido.HeaderText = "Llega Pedido"
        Me.Llega_Pedido.Name = "Llega_Pedido"
        Me.Llega_Pedido.ReadOnly = True
        '
        'Frascos_Comprados
        '
        Me.Frascos_Comprados.HeaderText = "Frascos Comprados"
        Me.Frascos_Comprados.Name = "Frascos_Comprados"
        Me.Frascos_Comprados.ReadOnly = True
        '
        'Gr_Comprados
        '
        Me.Gr_Comprados.HeaderText = "Gr Comprados"
        Me.Gr_Comprados.Name = "Gr_Comprados"
        Me.Gr_Comprados.ReadOnly = True
        '
        'Rnd_Pedido
        '
        Me.Rnd_Pedido.HeaderText = "RND PEDIDO"
        Me.Rnd_Pedido.Name = "Rnd_Pedido"
        Me.Rnd_Pedido.ReadOnly = True
        '
        'Falta_Prox_Pedido
        '
        Me.Falta_Prox_Pedido.HeaderText = "Dias Para Prox Pedido"
        Me.Falta_Prox_Pedido.Name = "Falta_Prox_Pedido"
        Me.Falta_Prox_Pedido.ReadOnly = True
        '
        'Dias_Llegada_Pedido
        '
        Me.Dias_Llegada_Pedido.HeaderText = "Dias para Llegada Pedido"
        Me.Dias_Llegada_Pedido.Name = "Dias_Llegada_Pedido"
        '
        'Stock_Dia
        '
        Me.Stock_Dia.HeaderText = "Stock del Dia"
        Me.Stock_Dia.Name = "Stock_Dia"
        Me.Stock_Dia.ReadOnly = True
        '
        'Rnd_Demanda_Mañana
        '
        Me.Rnd_Demanda_Mañana.HeaderText = "RND Demanda Mañana"
        Me.Rnd_Demanda_Mañana.Name = "Rnd_Demanda_Mañana"
        Me.Rnd_Demanda_Mañana.ReadOnly = True
        '
        'Demanda_Mña
        '
        Me.Demanda_Mña.HeaderText = "Demanda Mañana"
        Me.Demanda_Mña.Name = "Demanda_Mña"
        Me.Demanda_Mña.ReadOnly = True
        '
        'RND_Demanda_Tarde
        '
        Me.RND_Demanda_Tarde.HeaderText = "RND Demanda Tarde"
        Me.RND_Demanda_Tarde.Name = "RND_Demanda_Tarde"
        Me.RND_Demanda_Tarde.ReadOnly = True
        '
        'Demanda_Tarde
        '
        Me.Demanda_Tarde.HeaderText = "Demanda Tarde"
        Me.Demanda_Tarde.Name = "Demanda_Tarde"
        Me.Demanda_Tarde.ReadOnly = True
        '
        'Demanda_Total
        '
        Me.Demanda_Total.HeaderText = "Demanda Total"
        Me.Demanda_Total.Name = "Demanda_Total"
        Me.Demanda_Total.ReadOnly = True
        '
        'Cantidad_Vendida
        '
        Me.Cantidad_Vendida.HeaderText = "Cantidad Vendida"
        Me.Cantidad_Vendida.Name = "Cantidad_Vendida"
        Me.Cantidad_Vendida.ReadOnly = True
        '
        'Cantidad_Faltante
        '
        Me.Cantidad_Faltante.HeaderText = "Faltante"
        Me.Cantidad_Faltante.Name = "Cantidad_Faltante"
        Me.Cantidad_Faltante.ReadOnly = True
        '
        'Stock_Final_Dia
        '
        Me.Stock_Final_Dia.HeaderText = "Stock Final Dia"
        Me.Stock_Final_Dia.Name = "Stock_Final_Dia"
        Me.Stock_Final_Dia.ReadOnly = True
        '
        'Stock_Promedio_Diario
        '
        Me.Stock_Promedio_Diario.HeaderText = "Stock Promedio Diario"
        Me.Stock_Promedio_Diario.Name = "Stock_Promedio_Diario"
        Me.Stock_Promedio_Diario.ReadOnly = True
        '
        'Gramos_Falantes_Promedio
        '
        Me.Gramos_Falantes_Promedio.HeaderText = "Promedio Gramos Faltante"
        Me.Gramos_Falantes_Promedio.Name = "Gramos_Falantes_Promedio"
        Me.Gramos_Falantes_Promedio.ReadOnly = True
        '
        'IngresoDiario
        '
        Me.IngresoDiario.HeaderText = "Ingreso Diario"
        Me.IngresoDiario.Name = "IngresoDiario"
        '
        'Perdida_Diaria_Faltante
        '
        Me.Perdida_Diaria_Faltante.HeaderText = "Perdida Diaria Faltante"
        Me.Perdida_Diaria_Faltante.Name = "Perdida_Diaria_Faltante"
        Me.Perdida_Diaria_Faltante.ReadOnly = True
        '
        'PromedioDiarioIngresoDiario
        '
        Me.PromedioDiarioIngresoDiario.HeaderText = "Promedio Diario Ingreso Diario"
        Me.PromedioDiarioIngresoDiario.Name = "PromedioDiarioIngresoDiario"
        '
        'BeneficioDiario
        '
        Me.BeneficioDiario.HeaderText = "Beneficio Diario"
        Me.BeneficioDiario.Name = "BeneficioDiario"
        '
        'BeneficioDiarioPromedio
        '
        Me.BeneficioDiarioPromedio.HeaderText = "Beneficio Diario Promedio"
        Me.BeneficioDiarioPromedio.Name = "BeneficioDiarioPromedio"
        '
        'CantidadFrascosAlmacenados
        '
        Me.CantidadFrascosAlmacenados.HeaderText = "Cantidad Frascos Almacenados"
        Me.CantidadFrascosAlmacenados.Name = "CantidadFrascosAlmacenados"
        '
        'txtPromedioDiasSinStock
        '
        Me.txtPromedioDiasSinStock.Location = New System.Drawing.Point(302, 81)
        Me.txtPromedioDiasSinStock.Name = "txtPromedioDiasSinStock"
        Me.txtPromedioDiasSinStock.Size = New System.Drawing.Size(84, 20)
        Me.txtPromedioDiasSinStock.TabIndex = 11
        Me.txtPromedioDiasSinStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(84, 84)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(175, 13)
        Me.Label28.TabIndex = 10
        Me.Label28.Text = "Porcentaje de Dias sin stock al final"
        '
        'txtPromedioHorasPerdidas
        '
        Me.txtPromedioHorasPerdidas.Location = New System.Drawing.Point(302, 55)
        Me.txtPromedioHorasPerdidas.Name = "txtPromedioHorasPerdidas"
        Me.txtPromedioHorasPerdidas.Size = New System.Drawing.Size(84, 20)
        Me.txtPromedioHorasPerdidas.TabIndex = 9
        Me.txtPromedioHorasPerdidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(118, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Promedio de Horas Perdidas"
        '
        'txtPorcentajeDiasFaltante
        '
        Me.txtPorcentajeDiasFaltante.Location = New System.Drawing.Point(302, 29)
        Me.txtPorcentajeDiasFaltante.Name = "txtPorcentajeDiasFaltante"
        Me.txtPorcentajeDiasFaltante.Size = New System.Drawing.Size(84, 20)
        Me.txtPorcentajeDiasFaltante.TabIndex = 3
        Me.txtPorcentajeDiasFaltante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(69, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Porcentaje de Dias Que Hubo Faltante"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(341, 35)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Simulación Montecarlo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(229, 26)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Simulación de stocks"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(18, 273)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1289, 473)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvMontecarlo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1281, 447)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tabla"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtConclusionDiasSinStock)
        Me.TabPage2.Controls.Add(Me.txtPromedioDiasSinStock)
        Me.TabPage2.Controls.Add(Me.txtPorcentaje8Frascos)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.txtPorcentaje5y8Frascos)
        Me.TabPage2.Controls.Add(Me.txtPromedioHorasPerdidas)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtPorcentaje2y5Frascos)
        Me.TabPage2.Controls.Add(Me.txtPorcentaje2Frascos)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.txtPorcentajeDiasFaltante)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1281, 447)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resultados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtConclusionDiasSinStock
        '
        Me.txtConclusionDiasSinStock.Location = New System.Drawing.Point(397, 81)
        Me.txtConclusionDiasSinStock.Name = "txtConclusionDiasSinStock"
        Me.txtConclusionDiasSinStock.Size = New System.Drawing.Size(365, 20)
        Me.txtConclusionDiasSinStock.TabIndex = 14
        Me.txtConclusionDiasSinStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPorcentaje8Frascos
        '
        Me.txtPorcentaje8Frascos.Location = New System.Drawing.Point(302, 209)
        Me.txtPorcentaje8Frascos.Name = "txtPorcentaje8Frascos"
        Me.txtPorcentaje8Frascos.Size = New System.Drawing.Size(84, 20)
        Me.txtPorcentaje8Frascos.TabIndex = 13
        Me.txtPorcentaje8Frascos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPorcentaje5y8Frascos
        '
        Me.txtPorcentaje5y8Frascos.Location = New System.Drawing.Point(302, 183)
        Me.txtPorcentaje5y8Frascos.Name = "txtPorcentaje5y8Frascos"
        Me.txtPorcentaje5y8Frascos.Size = New System.Drawing.Size(84, 20)
        Me.txtPorcentaje5y8Frascos.TabIndex = 12
        Me.txtPorcentaje5y8Frascos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPorcentaje2y5Frascos
        '
        Me.txtPorcentaje2y5Frascos.Location = New System.Drawing.Point(302, 157)
        Me.txtPorcentaje2y5Frascos.Name = "txtPorcentaje2y5Frascos"
        Me.txtPorcentaje2y5Frascos.Size = New System.Drawing.Size(84, 20)
        Me.txtPorcentaje2y5Frascos.TabIndex = 11
        Me.txtPorcentaje2y5Frascos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPorcentaje2Frascos
        '
        Me.txtPorcentaje2Frascos.Location = New System.Drawing.Point(302, 131)
        Me.txtPorcentaje2Frascos.Name = "txtPorcentaje2Frascos"
        Me.txtPorcentaje2Frascos.Size = New System.Drawing.Size(84, 20)
        Me.txtPorcentaje2Frascos.TabIndex = 10
        Me.txtPorcentaje2Frascos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(392, 212)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 13)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "x > 8"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(392, 186)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "5 < x <= 8"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(392, 160)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "2 < x <= 5"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(392, 134)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "x <= 2"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(23, 131)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(235, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Porcentaje de días con frascos almacenados (x)"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvSoporte)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1281, 447)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tabla a partir de X dia"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvSoporte
        '
        Me.dgvSoporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSoporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.dgvSoporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSoporte.Location = New System.Drawing.Point(0, 0)
        Me.dgvSoporte.Name = "dgvSoporte"
        Me.dgvSoporte.Size = New System.Drawing.Size(1281, 447)
        Me.dgvSoporte.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Dia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Stock al Inicio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Llega Pedido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Frascos Comprados"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gr Comprados"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "RND PEDIDO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Dias Para Prox Pedido"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Dias para Llegada Pedido"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Stock del Dia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "RND Demanda Mañana"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Demanda Mañana"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "RND Demanda Tarde"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Demanda Tarde"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Demanda Total"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cantidad Vendida"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Faltante"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Stock Final Dia"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Stock Promedio Diario"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Promedio Gramos Faltante"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Ingreso Diario"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Promedio Diario Ingreso Diario"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Beneficio Diario"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Beneficio Diario Promedio"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "Cantidad Frascos Almacenados"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 749)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(410, 26)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Barth - Cuello - Loza - Micheletti - Soaje"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1190, 749)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 26)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "4K4 - 2020"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(890, 752)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(294, 23)
        Me.ProgressBar1.TabIndex = 21
        '
        'progreso
        '
        Me.progreso.BackColor = System.Drawing.Color.Transparent
        Me.progreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.progreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progreso.Location = New System.Drawing.Point(830, 752)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(54, 23)
        Me.progreso.TabIndex = 22
        Me.progreso.Text = "0%"
        '
        'soloIntervalos
        '
        Me.soloIntervalos.AutoSize = True
        Me.soloIntervalos.Location = New System.Drawing.Point(21, 15)
        Me.soloIntervalos.Name = "soloIntervalos"
        Me.soloIntervalos.Size = New System.Drawing.Size(185, 30)
        Me.soloIntervalos.TabIndex = 22
        Me.soloIntervalos.Text = "Mostrar solo el vector de estados " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cada 10000 dias"
        Me.soloIntervalos.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.soloIntervalos)
        Me.GroupBox5.Location = New System.Drawing.Point(706, 137)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(256, 49)
        Me.GroupBox5.TabIndex = 23
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Generación"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 781)
        Me.Controls.Add(Me.progreso)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trabajo práctico N° 4"
        Me.GroupBox1.ResumeLayout(False)
        Me.grbCongruencial.ResumeLayout(False)
        Me.grbCongruencial.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvMontecarlo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtPrecioCompraFrasco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPesoFrasco As TextBox
    Friend WithEvents txtCantFrascos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtMediaExpTarde As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtDesvNormalMedia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMediaNormalMña As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCantDiaSimulacion As TextBox
    Friend WithEvents txtPrecioVentaFrasco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RdbCongruencial As RadioButton
    Friend WithEvents rdbAleatorio As RadioButton
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtMostrarDesde As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DgvMontecarlo As DataGridView
    Friend WithEvents txtPromedioHorasPerdidas As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPorcentajeDiasFaltante As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCapacidadMaxima As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPorcentaje8Frascos As TextBox
    Friend WithEvents txtPorcentaje5y8Frascos As TextBox
    Friend WithEvents txtPorcentaje2y5Frascos As TextBox
    Friend WithEvents txtPorcentaje2Frascos As TextBox
    Friend WithEvents grbCongruencial As GroupBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtM As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtSemilla As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtPromedioDiasSinStock As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvSoporte As DataGridView
    Friend WithEvents Label29 As Label
    Friend WithEvents txtCantidadHorasTurno As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents progreso As Label
    Friend WithEvents Dia As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Inicio As DataGridViewTextBoxColumn
    Friend WithEvents Llega_Pedido As DataGridViewTextBoxColumn
    Friend WithEvents Frascos_Comprados As DataGridViewTextBoxColumn
    Friend WithEvents Gr_Comprados As DataGridViewTextBoxColumn
    Friend WithEvents Rnd_Pedido As DataGridViewTextBoxColumn
    Friend WithEvents Falta_Prox_Pedido As DataGridViewTextBoxColumn
    Friend WithEvents Dias_Llegada_Pedido As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Dia As DataGridViewTextBoxColumn
    Friend WithEvents Rnd_Demanda_Mañana As DataGridViewTextBoxColumn
    Friend WithEvents Demanda_Mña As DataGridViewTextBoxColumn
    Friend WithEvents RND_Demanda_Tarde As DataGridViewTextBoxColumn
    Friend WithEvents Demanda_Tarde As DataGridViewTextBoxColumn
    Friend WithEvents Demanda_Total As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_Vendida As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_Faltante As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Final_Dia As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Promedio_Diario As DataGridViewTextBoxColumn
    Friend WithEvents Gramos_Falantes_Promedio As DataGridViewTextBoxColumn
    Friend WithEvents IngresoDiario As DataGridViewTextBoxColumn
    Friend WithEvents Perdida_Diaria_Faltante As DataGridViewTextBoxColumn
    Friend WithEvents PromedioDiarioIngresoDiario As DataGridViewTextBoxColumn
    Friend WithEvents BeneficioDiario As DataGridViewTextBoxColumn
    Friend WithEvents BeneficioDiarioPromedio As DataGridViewTextBoxColumn
    Friend WithEvents CantidadFrascosAlmacenados As DataGridViewTextBoxColumn
    Friend WithEvents txtConclusionDiasSinStock As TextBox
    Friend WithEvents soloIntervalos As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
End Class
