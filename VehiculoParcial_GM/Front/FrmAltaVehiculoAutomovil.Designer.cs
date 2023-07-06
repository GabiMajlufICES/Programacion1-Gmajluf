namespace Front
{
    partial class FrmAltaVehiculoAutomovil
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
            this.textPatente = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNroPuertas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNroAsientos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente";
            // 
            // textPatente
            // 
            this.textPatente.Location = new System.Drawing.Point(223, 37);
            this.textPatente.Name = "textPatente";
            this.textPatente.Size = new System.Drawing.Size(245, 26);
            this.textPatente.TabIndex = 1;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(223, 252);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(245, 26);
            this.textPrecio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio por dia";
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(223, 176);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(245, 26);
            this.textModelo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(223, 101);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(245, 26);
            this.textMarca.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca";
            // 
            // textNroPuertas
            // 
            this.textNroPuertas.Location = new System.Drawing.Point(223, 327);
            this.textNroPuertas.Name = "textNroPuertas";
            this.textNroPuertas.Size = new System.Drawing.Size(245, 26);
            this.textNroPuertas.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero de puertas";
            // 
            // textNroAsientos
            // 
            this.textNroAsientos.Location = new System.Drawing.Point(223, 403);
            this.textNroAsientos.Name = "textNroAsientos";
            this.textNroAsientos.Size = new System.Drawing.Size(245, 26);
            this.textNroAsientos.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Numero de asientos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(961, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 59);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(591, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(500, 404);
            this.listBox1.TabIndex = 14;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(642, 494);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(135, 64);
            this.btn_Eliminar.TabIndex = 15;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(807, 494);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(135, 64);
            this.btn_Modificar.TabIndex = 16;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // FrmAltaVehiculoAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 602);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNroPuertas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNroAsientos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPatente);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltaVehiculoAutomovil";
            this.Text = "FrmAltaVehiculoAutomovil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPatente;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNroPuertas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNroAsientos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
    }
}