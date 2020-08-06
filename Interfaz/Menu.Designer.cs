namespace Simulacion_TP1
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_congruencialMixto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_congruencialMultiplicativo = new System.Windows.Forms.Button();
            this.btn_chicuadrado = new System.Windows.Forms.Button();
            this.insumoBisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dicsysADataSet = new Simulacion_TP1.dicsysADataSet();
            this.dicsysADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insumoBisTableAdapter = new Simulacion_TP1.dicsysADataSetTableAdapters.InsumoBisTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicsysADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicsysADataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajo Practico - Simulacion";
            // 
            // btn_congruencialMixto
            // 
            this.btn_congruencialMixto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_congruencialMixto.FlatAppearance.BorderSize = 0;
            this.btn_congruencialMixto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_congruencialMixto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_congruencialMixto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_congruencialMixto.Location = new System.Drawing.Point(71, 135);
            this.btn_congruencialMixto.Name = "btn_congruencialMixto";
            this.btn_congruencialMixto.Size = new System.Drawing.Size(307, 37);
            this.btn_congruencialMixto.TabIndex = 1;
            this.btn_congruencialMixto.Text = "Congruencial Mixto\r\n";
            this.btn_congruencialMixto.UseVisualStyleBackColor = false;
            this.btn_congruencialMixto.Click += new System.EventHandler(this.btn_congruencialMixto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Generacion de numeros aleatorios";
            // 
            // btn_congruencialMultiplicativo
            // 
            this.btn_congruencialMultiplicativo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_congruencialMultiplicativo.FlatAppearance.BorderSize = 0;
            this.btn_congruencialMultiplicativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_congruencialMultiplicativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_congruencialMultiplicativo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_congruencialMultiplicativo.Location = new System.Drawing.Point(71, 178);
            this.btn_congruencialMultiplicativo.Name = "btn_congruencialMultiplicativo";
            this.btn_congruencialMultiplicativo.Size = new System.Drawing.Size(307, 37);
            this.btn_congruencialMultiplicativo.TabIndex = 3;
            this.btn_congruencialMultiplicativo.Text = "Congruencial Multiplicativo\r\n";
            this.btn_congruencialMultiplicativo.UseVisualStyleBackColor = false;
            this.btn_congruencialMultiplicativo.Click += new System.EventHandler(this.btn_congruencialMultiplicativo_Click);
            // 
            // btn_chicuadrado
            // 
            this.btn_chicuadrado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_chicuadrado.FlatAppearance.BorderSize = 0;
            this.btn_chicuadrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_chicuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chicuadrado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_chicuadrado.Location = new System.Drawing.Point(71, 221);
            this.btn_chicuadrado.Name = "btn_chicuadrado";
            this.btn_chicuadrado.Size = new System.Drawing.Size(307, 37);
            this.btn_chicuadrado.TabIndex = 4;
            this.btn_chicuadrado.Text = "Test de Chi Cuadrado\r\n";
            this.btn_chicuadrado.UseVisualStyleBackColor = false;
            // 
            // insumoBisBindingSource
            // 
            this.insumoBisBindingSource.DataMember = "InsumoBis";
            this.insumoBisBindingSource.DataSource = this.dicsysADataSet;
            // 
            // dicsysADataSet
            // 
            this.dicsysADataSet.DataSetName = "dicsysADataSet";
            this.dicsysADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dicsysADataSetBindingSource
            // 
            this.dicsysADataSetBindingSource.DataSource = this.dicsysADataSet;
            this.dicsysADataSetBindingSource.Position = 0;
            // 
            // insumoBisTableAdapter
            // 
            this.insumoBisTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Integrantes: Juan Carlos Barth, Luz Gonzalez, Agostina Mercado, Juan Cruz Cuello";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(462, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_chicuadrado);
            this.Controls.Add(this.btn_congruencialMultiplicativo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_congruencialMixto);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insumoBisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicsysADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicsysADataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_congruencialMixto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_congruencialMultiplicativo;
        private System.Windows.Forms.Button btn_chicuadrado;
        private System.Windows.Forms.BindingSource dicsysADataSetBindingSource;
        private dicsysADataSet dicsysADataSet;
        private System.Windows.Forms.BindingSource insumoBisBindingSource;
        private dicsysADataSetTableAdapters.InsumoBisTableAdapter insumoBisTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}

