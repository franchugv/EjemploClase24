using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase24
{
    public class CuentaOro : Cuenta
    {
 

        // PROPIEDADES

        public override string Titular 
        {
            get
            {
                return _titilar;
            }
            set
            {
                _titilar = value;
            } 
        }

        public override double Cantidad
        {
            get
            {
                return _cantidad;
            }
        }

        public override DateTime FechaNac 
        {
            get
            {
                return _fechaNac;
            }
            set
            {
                _fechaNac = value;
            } 
        }


        public override string NumCuenta 
        {
            get
            {
                return _numCuenta;
            }
            set => throw new NotImplementedException(); 
        }


        // METODOS


        public override void Ingresar(double importe)
        {
            throw new NotImplementedException();
        }

        public override void Retirar(double importe)
        {
            throw new NotImplementedException();
        }

        
    }
}
