using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_13;
using static LAB_13._1.pantalla;

namespace LAB_13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = pantalla.pantallaPrincipal();

            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = pantalla.getEncuesta();
                        break;
                    case 2:
                        opcion = pantalla.getDatos();
                        break;
                    case 3:
                        opcion = pantalla.eliminarDato();
                        break;
                    case 4:
                        opcion = pantalla.ordenarDato();
                        break;
                    case 0:
                    default:
                        opcion = pantalla.pantallaPrincipal();
                        break;
                }
            } while (opcion != 5);
        }
    }
}
