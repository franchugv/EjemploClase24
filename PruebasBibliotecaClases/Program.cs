using EjemploClase24;

namespace PruebasBibliotecaClases
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CuentaJoven hola;

            CuentaPlatino p;

            hola = new CuentaJoven();

            p = new CuentaPlatino();

            p.Ingresar(20);

            hola.Titular = "Juan";

            hola.Ingresar(20);

            Console.WriteLine(hola.Titular);

            Console.WriteLine(p.Cantidad);


        }
    }
}
