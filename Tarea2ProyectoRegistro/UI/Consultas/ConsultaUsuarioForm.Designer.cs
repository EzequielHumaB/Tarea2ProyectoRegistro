namespace Tarea2ProyectoRegistro.UI.Consultas
{
    partial class ConsultaUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaUsuarioForm));
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.textBoxCristerio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(804, 372);
            this.dataGridViewData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Criterio";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
            this.buttonConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultar.Location = new System.Drawing.Point(661, 12);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(127, 37);
            this.buttonConsultar.TabIndex = 5;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.ButtonConsultar_Click);
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(12, 27);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(103, 22);
            this.dateTimePickerDesde.TabIndex = 6;
            this.dateTimePickerDesde.Value = new System.DateTime(2019, 5, 23, 18, 49, 38, 0);
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(121, 27);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(96, 22);
            this.dateTimePickerHasta.TabIndex = 7;
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(270, 29);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFiltro.TabIndex = 8;
            // 
            // textBoxCristerio
            // 
            this.textBoxCristerio.Location = new System.Drawing.Point(410, 29);
            this.textBoxCristerio.Name = "textBoxCristerio";
            this.textBoxCristerio.Size = new System.Drawing.Size(218, 22);
            this.textBoxCristerio.TabIndex = 9;
            // 
            // ConsultaUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCristerio);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "ConsultaUsuarioForm";
            this.Text = "ConsultaUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.TextBox textBoxCristerio;
    }
}