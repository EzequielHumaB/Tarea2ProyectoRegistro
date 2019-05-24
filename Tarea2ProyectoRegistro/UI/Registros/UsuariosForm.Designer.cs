namespace Tarea2ProyectoRegistro.UI.Registros
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownUID = new System.Windows.Forms.NumericUpDown();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNivelUsuario = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.dateTimePickerFechaIngreso = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clave";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Ingreso";
            // 
            // numericUpDownUID
            // 
            this.numericUpDownUID.Location = new System.Drawing.Point(170, 40);
            this.numericUpDownUID.Name = "numericUpDownUID";
            this.numericUpDownUID.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownUID.TabIndex = 7;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(288, 39);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(119, 47);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(170, 76);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(170, 112);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxNivelUsuario
            // 
            this.textBoxNivelUsuario.Location = new System.Drawing.Point(170, 150);
            this.textBoxNivelUsuario.Name = "textBoxNivelUsuario";
            this.textBoxNivelUsuario.Size = new System.Drawing.Size(100, 22);
            this.textBoxNivelUsuario.TabIndex = 11;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(170, 188);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsuario.TabIndex = 12;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(170, 222);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(100, 22);
            this.textBoxClave.TabIndex = 13;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.Location = new System.Drawing.Point(279, 320);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(91, 100);
            this.buttonEliminar.TabIndex = 15;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.Location = new System.Drawing.Point(160, 322);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(96, 96);
            this.buttonGuardar.TabIndex = 16;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevo.Image")));
            this.buttonNuevo.Location = new System.Drawing.Point(56, 320);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(89, 91);
            this.buttonNuevo.TabIndex = 17;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dateTimePickerFechaIngreso
            // 
            this.dateTimePickerFechaIngreso.Location = new System.Drawing.Point(170, 264);
            this.dateTimePickerFechaIngreso.Name = "dateTimePickerFechaIngreso";
            this.dateTimePickerFechaIngreso.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechaIngreso.TabIndex = 18;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 448);
            this.Controls.Add(this.dateTimePickerFechaIngreso);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxNivelUsuario);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.numericUpDownUID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownUID;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNivelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaIngreso;
    }
}