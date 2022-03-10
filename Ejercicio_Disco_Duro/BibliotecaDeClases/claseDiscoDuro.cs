using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace BibliotecaDeClases
{
    public class claseDiscoDuro
    {
        static int capacidad, numParticiones;
        static string medidaCapacidad;
        
        public int Capacidad
        {
            get
            {
                return capacidad;
            }
            set
            {
                 capacidad = value;
            }
        }

        public int  NumeroParticiones
        {
            get
            {
                return numParticiones;
            }
            set
            {
                numParticiones = value;
            }
        }

        public string MedidaCapacidad
        {
            get
            {
                return medidaCapacidad;
            }
            set
            {
                medidaCapacidad = value;
            }
        }


    }
}
