using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase24
{
    public class CuentaPlatino : Cuenta
    {
        public override void Retirar(double importe)
        {
            
            ValidarImporte(importe);

            // PROCESO

            _cantidad -= importe;

        }
    }
}
