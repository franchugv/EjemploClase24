﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase24
{
    public class CuentaJoven : Cuenta
    {

        // CONSTANTES

        // MIEMBROS

        // CONSTRUCTORES

        // PROPIEDADES

        public override string Titular
        {
            get
            {
                return _titilar;
            }
            set
            {
                base.ValidarCadena(value);
                _titilar = value;
            }
        }

        public override string NumCuenta 
        {
            get
            {
                return _numCuenta;
            }
            set
            {
                _numCuenta = value;
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
                base.ValidarFecha(value);
                _fechaNac = value;
            }
        }



        // MÉTODOS

        public override void Ingresar(double importe)
        {
            base.Ingresar(importe);  
        }

        public override void Retirar(double importe)
        {

        }


    }
}
