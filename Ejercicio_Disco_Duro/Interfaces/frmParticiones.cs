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
    public partial class frmParticiones : Form
    {
        claseDiscoDuro objDatosDisco = new claseDiscoDuro();
        public frmParticiones()
        {
            InitializeComponent();
            
            if (objDatosDisco.NumeroParticiones == 2)
            {
                this.Size = new Size(473, 190);
            }
            else if (objDatosDisco.NumeroParticiones == 3)
            {
                this.Size = new Size(473, 252);
            }
            else if (objDatosDisco.NumeroParticiones == 4)
            {
                this.Size = new Size(473, 313);
            }
            else if (objDatosDisco.NumeroParticiones == 5)
            {
                this.Size = new Size(473, 376);
            }

        }
    }
}
