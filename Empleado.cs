using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    internal class Empleado
    {
        private string documento;
        private string nombre;
        private string apellido;
        private double salario;
        private double dias_trabajados;
        private double TotalDevengado;
        private double Aux_Transporte;
        private double pension;
        private double salud;
        public Empleado()
        {

        }

        public string Documento { get => documento; set => documento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Salario { get => salario; set => salario = value; }
        public double Dias_trabajados { get => dias_trabajados; set => dias_trabajados = value; }
        public double TotalDevengado1 { get => TotalDevengado; set => TotalDevengado = value; }
        public double Aux_Transporte1 { get => Aux_Transporte; set => Aux_Transporte = value; }
        public double Pension { get => pension; set => pension = value; }
        public double Salud { get => salud; set => salud = value; }
    }
}
