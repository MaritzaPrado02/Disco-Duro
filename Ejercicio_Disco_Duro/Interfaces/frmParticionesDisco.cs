using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace Interfaces
{
    public partial class frmParticionesDisco : Form
    {
        //Objeto de la clase
        claseDiscoDuro objDatosDD = new claseDiscoDuro();
        public frmParticionesDisco()
        {
            InitializeComponent();
            pnlParticiones.Visible = false;
            lblDefinirTamanio.Visible = false;
            this.Size = new Size(508, 217);
        }

        private void btnPartir_Click(object sender, EventArgs e)
        {
            #region Capturar Datos

            #region Validaciones
            if (txtCapacidad.Text == "")
            {
                errorProvider1.SetError(txtCapacidad, "Debe ingresar la capacidad del disco duro");
                txtCapacidad.Focus();
                return;
            }
            errorProvider1.SetError(txtCapacidad, "");


            int capacidad;
            if (!int.TryParse(txtCapacidad.Text, out capacidad))
            {
                errorProvider1.SetError(txtCapacidad, "Debe ingresar solo números en el campo del capacidad");
                txtCapacidad.Focus();
                return;
            }
            errorProvider1.SetError(txtCapacidad, "");

            if (cmbCapacidadAlmacenamiento.Text == "")
            {
                errorProvider1.SetError(cmbCapacidadAlmacenamiento, "Debe seleccionar la capacidad de almacenamiento");
                cmbCapacidadAlmacenamiento.Focus();
                return;
            }
            errorProvider1.SetError(cmbCapacidadAlmacenamiento, "");

            if (nudParticiones.Text == "")
            {
                errorProvider1.SetError(nudParticiones, "Debe ingresar la cantidad de particiones");
                nudParticiones.Focus();
                return;
            }
            errorProvider1.SetError(nudParticiones, "");

            #endregion

            objDatosDD.Capacidad = Convert.ToInt32(txtCapacidad.Text);
            objDatosDD.MedidaCapacidad = Convert.ToString(cmbCapacidadAlmacenamiento.Text);
            objDatosDD.NumeroParticiones = Convert.ToInt32(nudParticiones.Text);

            #endregion

            #region Redimensionar pantalla
            lblDefinirTamanio.Visible = true;
            pnlParticiones.Visible = true;
            
            if (objDatosDD.NumeroParticiones == 2)
            {
                this.Size = new Size(508, 392);
                txtPartE.Enabled = false;
                cmbPartE.Enabled = false;

                lblPartF.Visible = false;
                txtPartF.Visible = false;
                cmbPartF.Visible = false;
                lblPartG.Visible = false;
                txtPartG.Visible = false;
                cmbPartG.Visible = false;
                lblPartH.Visible = false;
                txtPartH.Visible = false;
                cmbPartH.Visible = false;

                btnGuardarParticiones.Location = new Point(196, 311);
            }
            else if(objDatosDD.NumeroParticiones == 3)
            {
                this.Size = new Size(508, 442);
                txtPartF.Enabled = false;
                cmbPartF.Enabled = false;

                lblPartG.Visible = false;
                txtPartG.Visible = false;
                cmbPartG.Visible = false;
                lblPartH.Visible = false;
                txtPartH.Visible = false;
                cmbPartH.Visible = false;

                btnGuardarParticiones.Location = new Point(196, 359);
            }
            else if(objDatosDD.NumeroParticiones == 4)
            {
                this.Size = new Size(508, 492);
                txtPartG.Enabled = false;
                cmbPartG.Enabled = false;

                lblPartH.Visible = false;
                txtPartH.Visible = false;
                cmbPartH.Visible = false;

                btnGuardarParticiones.Location = new Point(196, 403);
            }
            else if (objDatosDD.NumeroParticiones == 5)
            {
                this.Size = new Size(508, 538);
                txtPartH.Enabled = false;
                cmbPartH.Enabled = false;

                btnGuardarParticiones.Location = new Point(196, 453);
            }

            #endregion

        }

        private void btnGuardarParticiones_Click(object sender, EventArgs e)
        {
            frmParticiones frmInterfazParticiones = new frmParticiones();
            frmInterfazParticiones.Show();
            this.Hide();

            #region Guardar tamanio de particiones
           


            #endregion
        }
    }
}
