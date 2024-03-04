using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase24
{
    public abstract class Cuenta
    {

        // MIEMBROS
        
        protected string _titilar;
        protected double _cantidad;
        protected DateTime _fechaNac;
        protected string _numCuenta;

        // PROPIEDADES A IMPLEMENTAR

        public abstract string Titular
        {
            get;
            set;
        }


        public abstract double Cantidad
        {
            // SOLO LECTURA
            get;
        }


        public abstract DateTime FechaNac
        {
            get;
            set;
        }


        public abstract string NumCuenta
        {
            get;
            set;
        }


        // MÉTODOS
         
        public virtual void Ingresar(double importe)
        {
            if (importe <= 0) throw new Exception("Importe incorrecto");

            _cantidad = importe;
        }

        public abstract void Retirar(double importe);

        
    }

}
