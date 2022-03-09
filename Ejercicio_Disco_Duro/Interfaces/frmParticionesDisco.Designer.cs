
namespace Interfaces
{
    partial class frmParticionesDisco
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblParticiones = new System.Windows.Forms.Label();
            this.cmbCapacidadAlmacenamiento = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(95, 53);
            this.lblCapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(107, 25);
            this.lblCapacidad.TabIndex = 1;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Location = new System.Drawing.Point(232, 50);
            this.txtCapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(132, 30);
            this.txtCapacidad.TabIndex = 2;
            // 
            // lblParticiones
            // 
            this.lblParticiones.AutoSize = true;
            this.lblParticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticiones.Location = new System.Drawing.Point(95, 101);
            this.lblParticiones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParticiones.Name = "lblParticiones";
            this.lblParticiones.Size = new System.Drawing.Size(108, 25);
            this.lblParticiones.TabIndex = 3;
            this.lblParticiones.Text = "Particiones";
            // 
            // cmbCapacidadAlmacenamiento
            // 
            this.cmbCapacidadAlmacenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCapacidadAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCapacidadAlmacenamiento.FormattingEnabled = true;
            this.cmbCapacidadAlmacenamiento.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cmbCapacidadAlmacenamiento.Location = new System.Drawing.Point(407, 50);
            this.cmbCapacidadAlmacenamiento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCapacidadAlmacenamiento.Name = "cmbCapacidadAlmacenamiento";
            this.cmbCapacidadAlmacenamiento.Size = new System.Drawing.Size(119, 33);
            this.cmbCapacidadAlmacenamiento.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(232, 96);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // frmParticionesDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 554);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbCapacidadAlmacenamiento);
            this.Controls.Add(this.lblParticiones);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.lblCapacidad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmParticionesDisco";
            this.Text = "DiscoDuro";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblParticiones;
        private System.Windows.Forms.ComboBox cmbCapacidadAlmacenamiento;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

