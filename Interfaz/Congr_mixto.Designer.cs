namespace Simulacion_TP1.Interfaz
{
    partial class Congr_mixto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_constanteA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_constanteC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_divisorM = new System.Windows.Forms.TextBox();
            this.btn_Ejecutar_mixto = new System.Windows.Forms.Button();
            this.btn_nuevo_mixto = new System.Windows.Forms.Button();
            this.btn_SerieContinua_mixto = new System.Windows.Forms.Button();
            this.listViewNumeros = new System.Windows.Forms.ListView();
            this.Numeros = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmb_Metodos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metodo Congruencial";
            // 
            // txt_semilla
            // 
            this.txt_semilla.Enabled = false;
            this.txt_semilla.Location = new System.Drawing.Point(138, 80);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(167, 20);
            this.txt_semilla.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semilla (Xo)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Constante K";
            // 
            // txt_constanteA
            // 
            this.txt_constanteA.Enabled = false;
            this.txt_constanteA.Location = new System.Drawing.Point(138, 109);
            this.txt_constanteA.Name = "txt_constanteA";
            this.txt_constanteA.Size = new System.Drawing.Size(167, 20);
            this.txt_constanteA.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Constante C";
            // 
            // txt_constanteC
            // 
            this.txt_constanteC.Enabled = false;
            this.txt_constanteC.Location = new System.Drawing.Point(138, 135);
            this.txt_constanteC.Name = "txt_constanteC";
            this.txt_constanteC.Size = new System.Drawing.Size(167, 20);
            this.txt_constanteC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Exponente (G)";
            // 
            // txt_divisorM
            // 
            this.txt_divisorM.Enabled = false;
            this.txt_divisorM.Location = new System.Drawing.Point(138, 161);
            this.txt_divisorM.Name = "txt_divisorM";
            this.txt_divisorM.Size = new System.Drawing.Size(167, 20);
            this.txt_divisorM.TabIndex = 8;
            // 
            // btn_Ejecutar_mixto
            // 
            this.btn_Ejecutar_mixto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_Ejecutar_mixto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ejecutar_mixto.Location = new System.Drawing.Point(38, 246);
            this.btn_Ejecutar_mixto.Name = "btn_Ejecutar_mixto";
            this.btn_Ejecutar_mixto.Size = new System.Drawing.Size(141, 33);
            this.btn_Ejecutar_mixto.TabIndex = 10;
            this.btn_Ejecutar_mixto.Text = "Ejecutar";
            this.btn_Ejecutar_mixto.UseVisualStyleBackColor = true;
            this.btn_Ejecutar_mixto.Click += new System.EventHandler(this.btn_Ejecutar_mixto_Click);
            // 
            // btn_nuevo_mixto
            // 
            this.btn_nuevo_mixto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_nuevo_mixto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_mixto.Location = new System.Drawing.Point(185, 246);
            this.btn_nuevo_mixto.Name = "btn_nuevo_mixto";
            this.btn_nuevo_mixto.Size = new System.Drawing.Size(120, 33);
            this.btn_nuevo_mixto.TabIndex = 11;
            this.btn_nuevo_mixto.Text = "Nuevo";
            this.btn_nuevo_mixto.UseVisualStyleBackColor = true;
            this.btn_nuevo_mixto.Click += new System.EventHandler(this.btn_nuevo_mixto_Click);
            // 
            // btn_SerieContinua_mixto
            // 
            this.btn_SerieContinua_mixto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_SerieContinua_mixto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SerieContinua_mixto.Location = new System.Drawing.Point(38, 285);
            this.btn_SerieContinua_mixto.Name = "btn_SerieContinua_mixto";
            this.btn_SerieContinua_mixto.Size = new System.Drawing.Size(141, 33);
            this.btn_SerieContinua_mixto.TabIndex = 12;
            this.btn_SerieContinua_mixto.Text = "Continuar Serie";
            this.btn_SerieContinua_mixto.UseVisualStyleBackColor = true;
            this.btn_SerieContinua_mixto.Click += new System.EventHandler(this.btn_SerieContinua_mixto_Click);
            // 
            // listViewNumeros
            // 
            this.listViewNumeros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numeros});
            this.listViewNumeros.HideSelection = false;
            this.listViewNumeros.Location = new System.Drawing.Point(331, 53);
            this.listViewNumeros.Name = "listViewNumeros";
            this.listViewNumeros.Size = new System.Drawing.Size(154, 265);
            this.listViewNumeros.TabIndex = 14;
            this.listViewNumeros.UseCompatibleStateImageBehavior = false;
            this.listViewNumeros.View = System.Windows.Forms.View.Details;
            // 
            // Numeros
            // 
            this.Numeros.Text = "Numeros";
            this.Numeros.Width = 89;
            // 
            // cmb_Metodos
            // 
            this.cmb_Metodos.FormattingEnabled = true;
            this.cmb_Metodos.Items.AddRange(new object[] {
            "Mixto",
            "Multiplicativo"});
            this.cmb_Metodos.Location = new System.Drawing.Point(240, 7);
            this.cmb_Metodos.Name = "cmb_Metodos";
            this.cmb_Metodos.Size = new System.Drawing.Size(198, 21);
            this.cmb_Metodos.TabIndex = 15;
            this.cmb_Metodos.SelectedIndexChanged += new System.EventHandler(this.cmb_Metodos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "a";
            // 
            // txt_a
            // 
            this.txt_a.Enabled = false;
            this.txt_a.Location = new System.Drawing.Point(138, 187);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(167, 20);
            this.txt_a.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "m";
            // 
            // txt_m
            // 
            this.txt_m.Enabled = false;
            this.txt_m.Location = new System.Drawing.Point(138, 213);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(167, 20);
            this.txt_m.TabIndex = 18;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(138, 53);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(167, 20);
            this.txt_cantidad.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "N";
            // 
            // Congr_mixto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(521, 337);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_m);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.cmb_Metodos);
            this.Controls.Add(this.listViewNumeros);
            this.Controls.Add(this.btn_SerieContinua_mixto);
            this.Controls.Add(this.btn_nuevo_mixto);
            this.Controls.Add(this.btn_Ejecutar_mixto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_divisorM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_constanteC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_constanteA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_semilla);
            this.Controls.Add(this.label1);
            this.Name = "Congr_mixto";
            this.Text = "Congr_mixto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_constanteA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_constanteC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_divisorM;
        private System.Windows.Forms.Button btn_Ejecutar_mixto;
        private System.Windows.Forms.Button btn_nuevo_mixto;
        private System.Windows.Forms.Button btn_SerieContinua_mixto;
        private System.Windows.Forms.ListView listViewNumeros;
        private System.Windows.Forms.ColumnHeader Numeros;
        private System.Windows.Forms.ComboBox cmb_Metodos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label8;
    }
}