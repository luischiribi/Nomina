using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    internal class ClassMain
    {
        
      public static void Main(string [] args)
      {
            Pago factura = new Pago();
            Console.WriteLine("Bienvenido al programa nomina");
            Console.WriteLine("1.Si desea agregar un empleado");
            Console.WriteLine("2.SI desea salir del programa");
            string opc = Console.ReadLine();
            switch (opc)
            {
                case "1":
                    factura.CalcularNomina();
                    factura.ImprimirDatos();
                    break;

                case "2":
                    Console.WriteLine("Salir del programa");
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }
      }
               
    }
}
