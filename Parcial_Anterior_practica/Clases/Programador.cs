using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Anterior_practica.Clases
{
    class Programador : Empleado
    {
        private string seniority;
        private string lenguaje_principal;
        public string _nombre { get => nombre; set => nombre = value; }
        public string _apellido { get => apellido; set => apellido = value; }
        public int _edad { get => edad; set => edad = value; }

        public Programador()
        {
        }

        public Programador(string nombre, string apellido, int edad, string seniority, string lenguaje_principal) : base(nombre, apellido, edad)
        {
            this.seniority = seniority;
            this.lenguaje_principal = lenguaje_principal;
        }

        public string Seniority { get => seniority; set => seniority = value; }
        public string Lenguaje_principal { get => lenguaje_principal; set => lenguaje_principal = value; }

        public void mostrarSeñority()
        {
            Console.WriteLine($"El señoriti es: {seniority}");
        }

        public void mostrarLenguaje_principal()
        {
            Console.WriteLine($"El lenguaje principal es: {lenguaje_principal}");
        }

        public void mostrar_datos_Personales()
        {
            Console.WriteLine($"El nombre del programador es: {nombre} {apellido} y su tiene {edad} años de edad ");
        }
    }
}
