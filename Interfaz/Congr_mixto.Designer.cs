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
            this.dataNumerosList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_constAditiva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_K = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_G = new System.Windows.Forms.TextBox();
            this.btn_Ejecutar_mixto = new System.Windows.Forms.Button();
            this.btn_nuevo_mixto = new System.Windows.Forms.Button();
            this.btn_SerieContinua_mixto = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNumerosList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNumerosList
            // 
            this.dataNumerosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNumerosList.Location = new System.Drawing.Point(331, 61);
            this.dataNumerosList.Name = "dataNumerosList";
            this.dataNumerosList.Size = new System.Drawing.Size(240, 392);
            this.dataNumerosList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metodo Congruencial Mixto\r\n";
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(138, 61);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(167, 20);
            this.txt_semilla.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semilla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Constante aditiva";
            // 
            // txt_constAditiva
            // 
            this.txt_constAditiva.Location = new System.Drawing.Point(138, 90);
            this.txt_constAditiva.Name = "txt_constAditiva";
            this.txt_constAditiva.Size = new System.Drawing.Size(167, 20);
            this.txt_constAditiva.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "K";
            // 
            // txt_K
            // 
            this.txt_K.Location = new System.Drawing.Point(138, 116);
            this.txt_K.Name = "txt_K";
            this.txt_K.Size = new System.Drawing.Size(167, 20);
            this.txt_K.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "G";
            // 
            // txt_G
            // 
            this.txt_G.Location = new System.Drawing.Point(138, 142);
            this.txt_G.Name = "txt_G";
            this.txt_G.Size = new System.Drawing.Size(167, 20);
            this.txt_G.TabIndex = 8;
            // 
            // btn_Ejecutar_mixto
            // 
            this.btn_Ejecutar_mixto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_Ejecutar_mixto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ejecutar_mixto.Location = new System.Drawing.Point(138, 199);
            this.btn_Ejecutar_mixto.Name = "btn_Ejecutar_mixto";
            this.btn_Ejecutar_mixto.Size = new System.Drawing.Size(167, 33);
            this.btn_Ejecutar_mixto.TabIndex = 10;
            this.btn_Ejecutar_mixto.Text = "Ejecutar";
            this.btn_Ejecutar_mixto.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_mixto
            // 
            this.btn_nuevo_mixto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_nuevo_mixto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_mixto.Location = new System.Drawing.Point(138, 238);
            this.btn_nuevo_mixto.Name = "btn_nuevo_mixto";
            this.btn_nuevo_mixto.Size = new System.Drawing.Size(167, 33);
            this.btn_nuevo_mixto.TabIndex = 11;
            this.btn_nuevo_mixto.Text = "Nuevo";
            this.btn_nuevo_mixto.UseVisualStyleBackColor = true;
            // 
            // btn_SerieContinua_mixto
            // 
            this.btn_SerieContinua_mixto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_SerieContinua_mixto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SerieContinua_mixto.Location = new System.Drawing.Point(138, 277);
            this.btn_SerieContinua_mixto.Name = "btn_SerieContinua_mixto";
            this.btn_SerieContinua_mixto.Size = new System.Drawing.Size(167, 33);
            this.btn_SerieContinua_mixto.TabIndex = 12;
            this.btn_SerieContinua_mixto.Text = "Continuar Serie";
            this.btn_SerieContinua_mixto.UseVisualStyleBackColor = true;
            // 
            // btn_atras
            // 
            this.btn_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Location = new System.Drawing.Point(138, 316);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(167, 33);
            this.btn_atras.TabIndex = 13;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            // 
            // Congr_mixto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(583, 477);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_SerieContinua_mixto);
            this.Controls.Add(this.btn_nuevo_mixto);
            this.Controls.Add(this.btn_Ejecutar_mixto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_G);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_K);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_constAditiva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_semilla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataNumerosList);
            this.Name = "Congr_mixto";
            this.Text = "Congr_mixto";
            ((System.ComponentModel.ISupportInitialize)(this.dataNumerosList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNumerosList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_constAditiva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_K;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_G;
        private System.Windows.Forms.Button btn_Ejecutar_mixto;
        private System.Windows.Forms.Button btn_nuevo_mixto;
        private System.Windows.Forms.Button btn_SerieContinua_mixto;
        private System.Windows.Forms.Button btn_atras;
    }
}