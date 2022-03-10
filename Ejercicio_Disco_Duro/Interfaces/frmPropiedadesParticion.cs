using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class frmPropiedadesParticion : Form
    {
        public frmPropiedadesParticion()
        {
            InitializeComponent();
            pnlCargarArchivo.Visible = false;
            this.Size = new Size (727, 418);
        }

        private void dgvArchivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Size = new Size(727, 528);
            pnlCargarArchivo.Visible = true;
        }
    }
}
