using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    internal class Pago
    {
        Empleado miEmpleado = new Empleado();
        public void CalcularNomina()
        {

            Console.WriteLine("Digite la cedula del empleado");
            miEmpleado.Documento = Console.ReadLine();
            Console.WriteLine("Digite el nombre del empleado");
            miEmpleado.Nombre = Console.ReadLine();
            Console.WriteLine("Digite el apellido del empleado");
            miEmpleado.Apellido = Console.ReadLine();
            Console.WriteLine("Digite el salario del empleado");
            miEmpleado.Salario= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite dias trabajados");
            miEmpleado.Dias_trabajados = double.Parse(Console.ReadLine());

            miEmpleado.TotalDevengado1 = miEmpleado.Salario / 30;
            miEmpleado.TotalDevengado1 = miEmpleado.Salario * miEmpleado.Dias_trabajados;

            miEmpleado.Aux_Transporte1 = 117172 / 30;
            miEmpleado.Aux_Transporte1 = miEmpleado.Aux_Transporte1 * miEmpleado.Dias_trabajados;

            miEmpleado.Salud = miEmpleado.TotalDevengado1 * 0.04;
            miEmpleado.Pension = miEmpleado.TotalDevengado1 * 0.04;

            if (miEmpleado.Salario <= 2000000)
            {
                miEmpleado.TotalDevengado1 = miEmpleado.TotalDevengado1 + miEmpleado.Aux_Transporte1;
            }
            else
            {
                miEmpleado.TotalDevengado1 = miEmpleado.TotalDevengado1;
            }
        }
        public void ImprimirDatos()
        {
            Console.WriteLine($"numero de cedula:{miEmpleado.Documento} ");
            Console.WriteLine($"nombre:{miEmpleado.Nombre} ");
            Console.WriteLine($"apellido:{miEmpleado.Apellido} ");
            Console.WriteLine($"salario:{miEmpleado.Salario} ");
            Console.WriteLine($"dias trabajados:{miEmpleado.Dias_trabajados} ");
            Console.WriteLine($"total devengado:{miEmpleado.TotalDevengado1} ");
            Console.WriteLine($"pago salud : {miEmpleado.Salud}");
            Console.WriteLine($"pago pension: {miEmpleado.Pension}");

        }
    }
}
