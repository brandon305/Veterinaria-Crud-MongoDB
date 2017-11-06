namespace CRUD_MongoDB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.MostrarDueños = new System.Windows.Forms.Button();
            this.lblsexo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eliminarDueño = new System.Windows.Forms.Button();
            this.actualizarDueño = new System.Windows.Forms.Button();
            this.AgregarDueño = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MostrarMascotas = new System.Windows.Forms.Button();
            this.lbledad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbldueño = new System.Windows.Forms.TextBox();
            this.lblraza = new System.Windows.Forms.TextBox();
            this.lblnombremascota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eliminarMascota = new System.Windows.Forms.Button();
            this.actualizarMascota = new System.Windows.Forms.Button();
            this.AgregarMascota = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MostrarDueños);
            this.panel1.Controls.Add(this.lblsexo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbldireccion);
            this.panel1.Controls.Add(this.lblnumero);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.eliminarDueño);
            this.panel1.Controls.Add(this.actualizarDueño);
            this.panel1.Controls.Add(this.AgregarDueño);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 287);
            this.panel1.TabIndex = 0;
            // 
            // MostrarDueños
            // 
            this.MostrarDueños.Location = new System.Drawing.Point(172, 248);
            this.MostrarDueños.Name = "MostrarDueños";
            this.MostrarDueños.Size = new System.Drawing.Size(75, 23);
            this.MostrarDueños.TabIndex = 13;
            this.MostrarDueños.Text = "VISTA D.";
            this.MostrarDueños.UseVisualStyleBackColor = true;
            this.MostrarDueños.Click += new System.EventHandler(this.MostrarDueños_Click);
            // 
            // lblsexo
            // 
            this.lblsexo.Location = new System.Drawing.Point(111, 156);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(100, 20);
            this.lblsexo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sexo";
            // 
            // lbldireccion
            // 
            this.lbldireccion.Location = new System.Drawing.Point(111, 124);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(100, 20);
            this.lbldireccion.TabIndex = 10;
            // 
            // lblnumero
            // 
            this.lblnumero.Location = new System.Drawing.Point(111, 95);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(100, 20);
            this.lblnumero.TabIndex = 9;
            // 
            // lblnombre
            // 
            this.lblnombre.Location = new System.Drawing.Point(111, 65);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(100, 20);
            this.lblnombre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DUEÑO DE MASCOTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número";
            // 
            // eliminarDueño
            // 
            this.eliminarDueño.Location = new System.Drawing.Point(36, 248);
            this.eliminarDueño.Name = "eliminarDueño";
            this.eliminarDueño.Size = new System.Drawing.Size(75, 23);
            this.eliminarDueño.TabIndex = 4;
            this.eliminarDueño.Text = "ELIMINAR";
            this.eliminarDueño.UseVisualStyleBackColor = true;
            this.eliminarDueño.Click += new System.EventHandler(this.eliminarDueño_Click);
            // 
            // actualizarDueño
            // 
            this.actualizarDueño.Location = new System.Drawing.Point(172, 201);
            this.actualizarDueño.Name = "actualizarDueño";
            this.actualizarDueño.Size = new System.Drawing.Size(75, 23);
            this.actualizarDueño.TabIndex = 3;
            this.actualizarDueño.Text = "ACTUALIZAR";
            this.actualizarDueño.UseVisualStyleBackColor = true;
            this.actualizarDueño.Click += new System.EventHandler(this.actualizarDueño_Click);
            // 
            // AgregarDueño
            // 
            this.AgregarDueño.Location = new System.Drawing.Point(36, 201);
            this.AgregarDueño.Name = "AgregarDueño";
            this.AgregarDueño.Size = new System.Drawing.Size(75, 23);
            this.AgregarDueño.TabIndex = 1;
            this.AgregarDueño.Text = "AGREGAR";
            this.AgregarDueño.UseVisualStyleBackColor = true;
            this.AgregarDueño.Click += new System.EventHandler(this.AgregarDueño_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MostrarMascotas);
            this.panel2.Controls.Add(this.lbledad);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbldueño);
            this.panel2.Controls.Add(this.lblraza);
            this.panel2.Controls.Add(this.lblnombremascota);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.eliminarMascota);
            this.panel2.Controls.Add(this.actualizarMascota);
            this.panel2.Controls.Add(this.AgregarMascota);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(332, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 287);
            this.panel2.TabIndex = 1;
            // 
            // MostrarMascotas
            // 
            this.MostrarMascotas.Location = new System.Drawing.Point(172, 248);
            this.MostrarMascotas.Name = "MostrarMascotas";
            this.MostrarMascotas.Size = new System.Drawing.Size(75, 23);
            this.MostrarMascotas.TabIndex = 14;
            this.MostrarMascotas.Text = "VISTA M.";
            this.MostrarMascotas.UseVisualStyleBackColor = true;
            this.MostrarMascotas.Click += new System.EventHandler(this.MostrarMascotas_Click);
            // 
            // lbledad
            // 
            this.lbledad.Location = new System.Drawing.Point(111, 156);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(100, 20);
            this.lbledad.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Edad";
            // 
            // lbldueño
            // 
            this.lbldueño.Location = new System.Drawing.Point(111, 124);
            this.lbldueño.Name = "lbldueño";
            this.lbldueño.Size = new System.Drawing.Size(100, 20);
            this.lbldueño.TabIndex = 10;
            // 
            // lblraza
            // 
            this.lblraza.Location = new System.Drawing.Point(111, 95);
            this.lblraza.Name = "lblraza";
            this.lblraza.Size = new System.Drawing.Size(100, 20);
            this.lblraza.TabIndex = 9;
            // 
            // lblnombremascota
            // 
            this.lblnombremascota.Location = new System.Drawing.Point(111, 65);
            this.lblnombremascota.Name = "lblnombremascota";
            this.lblnombremascota.Size = new System.Drawing.Size(100, 20);
            this.lblnombremascota.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "MASCOTA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Dueño";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Raza";
            // 
            // eliminarMascota
            // 
            this.eliminarMascota.Location = new System.Drawing.Point(36, 248);
            this.eliminarMascota.Name = "eliminarMascota";
            this.eliminarMascota.Size = new System.Drawing.Size(75, 23);
            this.eliminarMascota.TabIndex = 4;
            this.eliminarMascota.Text = "ELIMINAR";
            this.eliminarMascota.UseVisualStyleBackColor = true;
            this.eliminarMascota.Click += new System.EventHandler(this.eliminarMascota_Click);
            // 
            // actualizarMascota
            // 
            this.actualizarMascota.Location = new System.Drawing.Point(172, 201);
            this.actualizarMascota.Name = "actualizarMascota";
            this.actualizarMascota.Size = new System.Drawing.Size(75, 23);
            this.actualizarMascota.TabIndex = 3;
            this.actualizarMascota.Text = "ACTUALIZAR";
            this.actualizarMascota.UseVisualStyleBackColor = true;
            this.actualizarMascota.Click += new System.EventHandler(this.actualizarMascota_Click);
            // 
            // AgregarMascota
            // 
            this.AgregarMascota.Location = new System.Drawing.Point(36, 201);
            this.AgregarMascota.Name = "AgregarMascota";
            this.AgregarMascota.Size = new System.Drawing.Size(75, 23);
            this.AgregarMascota.TabIndex = 1;
            this.AgregarMascota.Text = "AGREGAR";
            this.AgregarMascota.UseVisualStyleBackColor = true;
            this.AgregarMascota.Click += new System.EventHandler(this.AgregarMascota_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eliminarDueño;
        private System.Windows.Forms.Button actualizarDueño;
        private System.Windows.Forms.Button AgregarDueño;
        private System.Windows.Forms.TextBox lblsexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lbldireccion;
        private System.Windows.Forms.TextBox lblnumero;
        private System.Windows.Forms.TextBox lblnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox lbledad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lbldueño;
        private System.Windows.Forms.TextBox lblraza;
        private System.Windows.Forms.TextBox lblnombremascota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button eliminarMascota;
        private System.Windows.Forms.Button actualizarMascota;
        private System.Windows.Forms.Button AgregarMascota;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button MostrarDueños;
        private System.Windows.Forms.Button MostrarMascotas;
    }
}

