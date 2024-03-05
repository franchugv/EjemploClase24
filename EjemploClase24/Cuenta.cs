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

        public virtual string Titular
        {
            get
            {
                return _titilar;
            }
            set
            {
                 // VALIDAR cadena Caaracteres: Solo letreas en blanco
                 ValidarCadena(value);
                _titilar = value;
                
            }
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

        // VIIRTUAL, SE PUEDE SOBREESCRIBIR SI SE QUIERE

        protected virtual void ValidarCadena(string cadena)
        {

            // Eliminación de los espacios en blanco con Trim()
            cadena = cadena.Trim();

            // Validación 
            if (string.IsNullOrEmpty(cadena)) throw new ArgumentException("Error: Cadena vacía o Null");

            if (!cadena.All(char.IsAsciiDigit)) throw new Exception("Error: No es número");
        }

    }

}
