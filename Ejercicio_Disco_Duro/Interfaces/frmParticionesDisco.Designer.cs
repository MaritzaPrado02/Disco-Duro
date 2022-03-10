
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
            this.components = new System.ComponentModel.Container();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblParticiones = new System.Windows.Forms.Label();
            this.cmbCapacidadAlmacenamiento = new System.Windows.Forms.ComboBox();
            this.nudParticiones = new System.Windows.Forms.NumericUpDown();
            this.btnPartir = new System.Windows.Forms.Button();
            this.pnlParticiones = new System.Windows.Forms.Panel();
            this.cmbPartH = new System.Windows.Forms.ComboBox();
            this.txtPartH = new System.Windows.Forms.TextBox();
            this.lblPartH = new System.Windows.Forms.Label();
            this.cmbPartG = new System.Windows.Forms.ComboBox();
            this.txtPartG = new System.Windows.Forms.TextBox();
            this.lblPartG = new System.Windows.Forms.Label();
            this.cmbPartF = new System.Windows.Forms.ComboBox();
            this.txtPartF = new System.Windows.Forms.TextBox();
            this.lblPartF = new System.Windows.Forms.Label();
            this.cmbPartE = new System.Windows.Forms.ComboBox();
            this.txtPartE = new System.Windows.Forms.TextBox();
            this.lblPartE = new System.Windows.Forms.Label();
            this.cmbPartD = new System.Windows.Forms.ComboBox();
            this.txtPartD = new System.Windows.Forms.TextBox();
            this.lblPartD = new System.Windows.Forms.Label();
            this.btnGuardarParticiones = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDefinirTamanio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudParticiones)).BeginInit();
            this.pnlParticiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(71, 43);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(85, 20);
            this.lblCapacidad.TabIndex = 1;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Location = new System.Drawing.Point(174, 41);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 26);
            this.txtCapacidad.TabIndex = 2;
            // 
            // lblParticiones
            // 
            this.lblParticiones.AutoSize = true;
            this.lblParticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticiones.Location = new System.Drawing.Point(71, 82);
            this.lblParticiones.Name = "lblParticiones";
            this.lblParticiones.Size = new System.Drawing.Size(87, 20);
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
            this.cmbCapacidadAlmacenamiento.Location = new System.Drawing.Point(304, 40);
            this.cmbCapacidadAlmacenamiento.Name = "cmbCapacidadAlmacenamiento";
            this.cmbCapacidadAlmacenamiento.Size = new System.Drawing.Size(90, 28);
            this.cmbCapacidadAlmacenamiento.TabIndex = 5;
            // 
            // nudParticiones
            // 
            this.nudParticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudParticiones.Location = new System.Drawing.Point(174, 78);
            this.nudParticiones.Margin = new System.Windows.Forms.Padding(2);
            this.nudParticiones.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudParticiones.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudParticiones.Name = "nudParticiones";
            this.nudParticiones.Size = new System.Drawing.Size(90, 26);
            this.nudParticiones.TabIndex = 6;
            this.nudParticiones.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnPartir
            // 
            this.btnPartir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartir.Location = new System.Drawing.Point(268, 130);
            this.btnPartir.Name = "btnPartir";
            this.btnPartir.Size = new System.Drawing.Size(168, 32);
            this.btnPartir.TabIndex = 7;
            this.btnPartir.Text = "Generar particiones";
            this.btnPartir.UseVisualStyleBackColor = true;
            this.btnPartir.Click += new System.EventHandler(this.btnPartir_Click);
            // 
            // pnlParticiones
            // 
            this.pnlParticiones.Controls.Add(this.cmbPartH);
            this.pnlParticiones.Controls.Add(this.txtPartH);
            this.pnlParticiones.Controls.Add(this.lblPartH);
            this.pnlParticiones.Controls.Add(this.cmbPartG);
            this.pnlParticiones.Controls.Add(this.txtPartG);
            this.pnlParticiones.Controls.Add(this.lblPartG);
            this.pnlParticiones.Controls.Add(this.cmbPartF);
            this.pnlParticiones.Controls.Add(this.txtPartF);
            this.pnlParticiones.Controls.Add(this.lblPartF);
            this.pnlParticiones.Controls.Add(this.cmbPartE);
            this.pnlParticiones.Controls.Add(this.txtPartE);
            this.pnlParticiones.Controls.Add(this.lblPartE);
            this.pnlParticiones.Controls.Add(this.cmbPartD);
            this.pnlParticiones.Controls.Add(this.txtPartD);
            this.pnlParticiones.Controls.Add(this.lblPartD);
            this.pnlParticiones.Location = new System.Drawing.Point(12, 192);
            this.pnlParticiones.Name = "pnlParticiones";
            this.pnlParticiones.Size = new System.Drawing.Size(468, 255);
            this.pnlParticiones.TabIndex = 8;
            // 
            // cmbPartH
            // 
            this.cmbPartH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPartH.FormattingEnabled = true;
            this.cmbPartH.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cmbPartH.Location = new System.Drawing.Point(307, 209);
            this.cmbPartH.Name = "cmbPartH";
            this.cmbPartH.Size = new System.Drawing.Size(90, 28);
            this.cmbPartH.TabIndex = 18;
            // 
            // txtPartH
            // 
            this.txtPartH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPartH.Location = new System.Drawing.Point(115, 211);
            this.txtPartH.Name = "txtPartH";
            this.txtPartH.Size = new System.Drawing.Size(172, 26);
            this.txtPartH.TabIndex = 20;
            // 
            // lblPartH
            // 
            this.lblPartH.AutoSize = true;
            this.lblPartH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPartH.Location = new System.Drawing.Point(55, 214);
            this.lblPartH.Name = "lblPartH";
            this.lblPartH.Size = new System.Drawing.Size(35, 20);
            this.lblPartH.TabIndex = 19;
            this.lblPartH.Text = "(H:)";
            // 
            // cmbPartG
            // 
            this.cmbPartG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPartG.FormattingEnabled = true;
            this.cmbPartG.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cmbPartG.Location = new System.Drawing.Point(307, 165);
            this.cmbPartG.Name = "cmbPartG";
            this.cmbPartG.Size = new System.Drawing.Size(90, 28);
            this.cmbPartG.TabIndex = 15;
            // 
            // txtPartG
            // 
            this.txtPartG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPartG.Location = new System.Drawing.Point(115, 167);
            this.txtPartG.Name = "txtPartG";
            this.txtPartG.Size = new System.Drawing.Size(172, 26);
            this.txtPartG.TabIndex = 17;
            // 
            // lblPartG
            // 
            this.lblPartG.AutoSize = true;
            this.lblPartG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPartG.Location = new System.Drawing.Point(55, 170);
            this.lblPartG.Name = "lblPartG";
            this.lblPartG.Size = new System.Drawing.Size(36, 20);
            this.lblPartG.TabIndex = 16;
            this.lblPartG.Text = "(G:)";
            // 
            // cmbPartF
            // 
            this.cmbPartF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPartF.FormattingEnabled = true;
            this.cmbPartF.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cmbPartF.Location = new System.Drawing.Point(306, 121);
            this.cmbPartF.Name = "cmbPartF";
            this.cmbPartF.Size = new System.Drawing.Size(90, 28);
            this.cmbPartF.TabIndex = 12;
            // 
            // txtPartF
            // 
            this.txtPartF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPartF.Location = new System.Drawing.Point(114, 123);
            this.txtPartF.Name = "txtPartF";
            this.txtPartF.Size = new System.Drawing.Size(172, 26);
            this.txtPartF.TabIndex = 14;
            // 
            // lblPartF
            // 
            this.lblPartF.AutoSize = true;
            this.lblPartF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPartF.Location = new System.Drawing.Point(54, 126);
            this.lblPartF.Name = "lblPartF";
            this.lblPartF.Size = new System.Drawing.Size(33, 20);
            this.lblPartF.TabIndex = 13;
            this.lblPartF.Text = "(F:)";
            // 
            // cmbPartE
            // 
            this.cmbPartE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPartE.FormattingEnabled = true;
            this.cmbPartE.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cmbPartE.Location = new System.Drawing.Point(306, 76);
            this.cmbPartE.Name = "cmbPartE";
            this.cmbPartE.Size = new System.Drawing.Size(90, 28);
            this.cmbPartE.TabIndex = 9;
            // 
            // txtPartE
            // 
            this.txtPartE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPartE.Location = new System.Drawing.Point(114, 78);
            this.txtPartE.Name = "txtPartE";
            this.txtPartE.Size = new System.Drawing.Size(172, 26);
            this.txtPartE.TabIndex = 11;
            // 
            // lblPartE
            // 
            this.lblPartE.AutoSize = true;
            this.lblPartE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPartE.Location = new System.Drawing.Point(54, 81);
            this.lblPartE.Name = "lblPartE";
            this.lblPartE.Size = new System.Drawing.Size(34, 20);
            this.lblPartE.TabIndex = 10;
            this.lblPartE.Text = "(E:)";
            // 
            // cmbPartD
            // 
            this.cmbPartD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPartD.FormattingEnabled = true;
            this.cmbPartD.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cmbPartD.Location = new System.Drawing.Point(306, 28);
            this.cmbPartD.Name = "cmbPartD";
            this.cmbPartD.Size = new System.Drawing.Size(90, 28);
            this.cmbPartD.TabIndex = 9;
            // 
            // txtPartD
            // 
            this.txtPartD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPartD.Location = new System.Drawing.Point(114, 30);
            this.txtPartD.Name = "txtPartD";
            this.txtPartD.Size = new System.Drawing.Size(172, 26);
            this.txtPartD.TabIndex = 1;
            // 
            // lblPartD
            // 
            this.lblPartD.AutoSize = true;
            this.lblPartD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPartD.Location = new System.Drawing.Point(53, 33);
            this.lblPartD.Name = "lblPartD";
            this.lblPartD.Size = new System.Drawing.Size(35, 20);
            this.lblPartD.TabIndex = 0;
            this.lblPartD.Text = "(D:)";
            // 
            // btnGuardarParticiones
            // 
            this.btnGuardarParticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarParticiones.Location = new System.Drawing.Point(196, 457);
            this.btnGuardarParticiones.Name = "btnGuardarParticiones";
            this.btnGuardarParticiones.Size = new System.Drawing.Size(93, 34);
            this.btnGuardarParticiones.TabIndex = 9;
            this.btnGuardarParticiones.Text = "Guardar";
            this.btnGuardarParticiones.UseVisualStyleBackColor = true;
            this.btnGuardarParticiones.Click += new System.EventHandler(this.btnGuardarParticiones_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblDefinirTamanio
            // 
            this.lblDefinirTamanio.AutoSize = true;
            this.lblDefinirTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinirTamanio.Location = new System.Drawing.Point(12, 169);
            this.lblDefinirTamanio.Name = "lblDefinirTamanio";
            this.lblDefinirTamanio.Size = new System.Drawing.Size(240, 20);
            this.lblDefinirTamanio.TabIndex = 10;
            this.lblDefinirTamanio.Text = "Definir tamaño de las particiones";
            // 
            // frmParticionesDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 504);
            this.Controls.Add(this.lblDefinirTamanio);
            this.Controls.Add(this.btnGuardarParticiones);
            this.Controls.Add(this.pnlParticiones);
            this.Controls.Add(this.btnPartir);
            this.Controls.Add(this.nudParticiones);
            this.Controls.Add(this.cmbCapacidadAlmacenamiento);
            this.Controls.Add(this.lblParticiones);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.lblCapacidad);
            this.Name = "frmParticionesDisco";
            this.Text = "DiscoDuro";
            ((System.ComponentModel.ISupportInitialize)(this.nudParticiones)).EndInit();
            this.pnlParticiones.ResumeLayout(false);
            this.pnlParticiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblParticiones;
        private System.Windows.Forms.ComboBox cmbCapacidadAlmacenamiento;
        private System.Windows.Forms.NumericUpDown nudParticiones;
        private System.Windows.Forms.Button btnPartir;
        private System.Windows.Forms.Panel pnlParticiones;
        private System.Windows.Forms.TextBox txtPartD;
        private System.Windows.Forms.Label lblPartD;
        private System.Windows.Forms.ComboBox cmbPartD;
        private System.Windows.Forms.ComboBox cmbPartE;
        private System.Windows.Forms.TextBox txtPartE;
        private System.Windows.Forms.Label lblPartE;
        private System.Windows.Forms.ComboBox cmbPartF;
        private System.Windows.Forms.TextBox txtPartF;
        private System.Windows.Forms.Label lblPartF;
        private System.Windows.Forms.ComboBox cmbPartH;
        private System.Windows.Forms.TextBox txtPartH;
        private System.Windows.Forms.Label lblPartH;
        private System.Windows.Forms.ComboBox cmbPartG;
        private System.Windows.Forms.TextBox txtPartG;
        private System.Windows.Forms.Label lblPartG;
        private System.Windows.Forms.Button btnGuardarParticiones;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblDefinirTamanio;
    }
}

