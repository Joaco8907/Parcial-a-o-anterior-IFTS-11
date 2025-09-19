using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Anterior_practica.Clases
{
    abstract class Empleado
    {
        protected string nombre;
        protected string apellido;
        protected int edad;


        public Empleado()
        {
        }

        public Empleado(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
    }
}
