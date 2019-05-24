using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueoLorena
{
    public class Datos
    {
        //encapsulamiento
        private string Usuario;
        private string TipoVehiculo;
        private string Placa;
        private string TipoPago;
        private string TipoParqueo;
        private int TiempoParqueo;
        private int TotalPago;

        public Datos(string Usuario, string TipoVehiculo, string Placa, string TipoPago, string TipoParqueo, int TiempoParqueo, int TotalPago)
        {
            this.Usuario = Usuario;
            this.TipoVehiculo = TipoVehiculo;
            this.Placa = Placa;
            this.TipoPago = TipoPago;
            this.TipoParqueo = TipoParqueo;
            this.TiempoParqueo = TiempoParqueo;
            this.TotalPago = TotalPago;
        }


        ////contructor
        //public Datos()
        //{
          
        //}

      


        public string usuario
        {
            get
            {
                return Usuario;
            }

            set
            {
                Usuario = value;
            }
        }

        public string tipovehiculo
        {
            get
            {
                return TipoVehiculo;
            }

            set
            {
                TipoVehiculo = value;
            }
        }

        public string placa
        {
            get
            {
                return Placa;
            }

            set
            {
                Placa = value;
            }
        }

        public string tipopago
        {
            get
            {
                return TipoPago;
            }

            set
            {
                TipoPago = value;
            }
        }

        public string tipoparqueo
        {
            get
            {
                return TipoParqueo;
            }

            set
            {
                TipoParqueo = value;
            }
        }

        public int tiempoarqueo
        {
            get
            {
                return TiempoParqueo;
            }

            set
            {
                TiempoParqueo = value;
            }
        }

        public int totalpago
        {
            get
            {
                return TotalPago;
            }

            set
            {
                TotalPago = value;
            }
        }

    }
}
