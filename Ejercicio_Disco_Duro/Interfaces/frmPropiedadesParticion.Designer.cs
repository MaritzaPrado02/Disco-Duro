
namespace Interfaces
{
    partial class frmPropiedadesParticion
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
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.cmbTipoArchivo = new System.Windows.Forms.ComboBox();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.cmbPesoArchivo = new System.Windows.Forms.ComboBox();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCargarArchivo = new System.Windows.Forms.Label();
            this.lblCargarTamanio = new System.Windows.Forms.Label();
            this.txtCargarArchivo = new System.Windows.Forms.TextBox();
            this.txtCargarTamanio = new System.Windows.Forms.TextBox();
            this.pnlCargarArchivo = new System.Windows.Forms.Panel();
            this.clmNombreArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTamanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.pnlCargarArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.Location = new System.Drawing.Point(71, 30);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(61, 20);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "Archivo";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreArchivo.Location = new System.Drawing.Point(156, 27);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(272, 26);
            this.txtNombreArchivo.TabIndex = 1;
            // 
            // cmbTipoArchivo
            // 
            this.cmbTipoArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoArchivo.FormattingEnabled = true;
            this.cmbTipoArchivo.Items.AddRange(new object[] {
            ".txt",
            ".doc",
            ".docx",
            ".jpg",
            ".gif",
            ".bmp",
            ".png",
            ".avi",
            ".mp4",
            ".mpeg",
            ".mwv",
            ".exe",
            ".bat",
            ".dll",
            ".sys",
            ".mp3",
            ".wav",
            ".wma",
            ".zip",
            ".rar",
            ".tar",
            ".pdf",
            ".epub",
            ".azw",
            ".img",
            ".mds"});
            this.cmbTipoArchivo.Location = new System.Drawing.Point(463, 27);
            this.cmbTipoArchivo.Name = "cmbTipoArchivo";
            this.cmbTipoArchivo.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoArchivo.TabIndex = 2;
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanio.Location = new System.Drawing.Point(71, 80);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(67, 20);
            this.lblTamanio.TabIndex = 3;
            this.lblTamanio.Text = "Tamaño";
            // 
            // txtTamanio
            // 
            this.txtTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanio.Location = new System.Drawing.Point(156, 77);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(272, 26);
            this.txtTamanio.TabIndex = 4;
            // 
            // cmbPesoArchivo
            // 
            this.cmbPesoArchivo.AllowDrop = true;
            this.cmbPesoArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesoArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesoArchivo.FormattingEnabled = true;
            this.cmbPesoArchivo.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.cmbPesoArchivo.Location = new System.Drawing.Point(463, 77);
            this.cmbPesoArchivo.Name = "cmbPesoArchivo";
            this.cmbPesoArchivo.Size = new System.Drawing.Size(121, 28);
            this.cmbPesoArchivo.TabIndex = 5;
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombreArchivo,
            this.clmTamanio});
            this.dgvArchivos.Location = new System.Drawing.Point(12, 204);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.Size = new System.Drawing.Size(687, 166);
            this.dgvArchivos.TabIndex = 6;
            this.dgvArchivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchivos_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(509, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 38);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar archivo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(475, 29);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 34);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar archivo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCargarArchivo
            // 
            this.lblCargarArchivo.AutoSize = true;
            this.lblCargarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargarArchivo.Location = new System.Drawing.Point(49, 15);
            this.lblCargarArchivo.Name = "lblCargarArchivo";
            this.lblCargarArchivo.Size = new System.Drawing.Size(61, 20);
            this.lblCargarArchivo.TabIndex = 9;
            this.lblCargarArchivo.Text = "Archivo";
            // 
            // lblCargarTamanio
            // 
            this.lblCargarTamanio.AutoSize = true;
            this.lblCargarTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargarTamanio.Location = new System.Drawing.Point(49, 58);
            this.lblCargarTamanio.Name = "lblCargarTamanio";
            this.lblCargarTamanio.Size = new System.Drawing.Size(67, 20);
            this.lblCargarTamanio.TabIndex = 10;
            this.lblCargarTamanio.Text = "Tamaño";
            // 
            // txtCargarArchivo
            // 
            this.txtCargarArchivo.Enabled = false;
            this.txtCargarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargarArchivo.Location = new System.Drawing.Point(134, 12);
            this.txtCargarArchivo.Name = "txtCargarArchivo";
            this.txtCargarArchivo.Size = new System.Drawing.Size(233, 26);
            this.txtCargarArchivo.TabIndex = 11;
            // 
            // txtCargarTamanio
            // 
            this.txtCargarTamanio.Enabled = false;
            this.txtCargarTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargarTamanio.Location = new System.Drawing.Point(134, 55);
            this.txtCargarTamanio.Name = "txtCargarTamanio";
            this.txtCargarTamanio.Size = new System.Drawing.Size(233, 26);
            this.txtCargarTamanio.TabIndex = 12;
            // 
            // pnlCargarArchivo
            // 
            this.pnlCargarArchivo.Controls.Add(this.txtCargarArchivo);
            this.pnlCargarArchivo.Controls.Add(this.txtCargarTamanio);
            this.pnlCargarArchivo.Controls.Add(this.btnEliminar);
            this.pnlCargarArchivo.Controls.Add(this.lblCargarArchivo);
            this.pnlCargarArchivo.Controls.Add(this.lblCargarTamanio);
            this.pnlCargarArchivo.Location = new System.Drawing.Point(12, 387);
            this.pnlCargarArchivo.Name = "pnlCargarArchivo";
            this.pnlCargarArchivo.Size = new System.Drawing.Size(687, 89);
            this.pnlCargarArchivo.TabIndex = 13;
            // 
            // clmNombreArchivo
            // 
            this.clmNombreArchivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombreArchivo.Frozen = true;
            this.clmNombreArchivo.HeaderText = "Nombre del archivo";
            this.clmNombreArchivo.Name = "clmNombreArchivo";
            this.clmNombreArchivo.Width = 114;
            // 
            // clmTamanio
            // 
            this.clmTamanio.Frozen = true;
            this.clmTamanio.HeaderText = "Tamaño";
            this.clmTamanio.Name = "clmTamanio";
            // 
            // frmPropiedadesParticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 489);
            this.Controls.Add(this.pnlCargarArchivo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArchivos);
            this.Controls.Add(this.cmbPesoArchivo);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.lblTamanio);
            this.Controls.Add(this.cmbTipoArchivo);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.lblArchivo);
            this.Name = "frmPropiedadesParticion";
            this.Text = "Propiedades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.pnlCargarArchivo.ResumeLayout(false);
            this.pnlCargarArchivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.ComboBox cmbTipoArchivo;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.ComboBox cmbPesoArchivo;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCargarArchivo;
        private System.Windows.Forms.Label lblCargarTamanio;
        private System.Windows.Forms.TextBox txtCargarArchivo;
        private System.Windows.Forms.TextBox txtCargarTamanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTamanio;
        private System.Windows.Forms.Panel pnlCargarArchivo;
    }
}