using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial_Anterior_practica.Enums;

namespace Parcial_Anterior_practica.Clases
{
    class Tester : Empleado
    {
        private int cant_proyectos;
        private Tipo_test tipo_test;
        public string _nombre { get => nombre; set => nombre = value; }
        public string _apellido { get => apellido; set => apellido = value; }
        public int _edad { get => edad; set => edad = value; }
        public Tester()
        {
        }

        public Tester(string nombre, string apellido, int edad, int cant_proyectos, Tipo_test tipo_test) : base(nombre, apellido, edad)
        {
            this.Cant_proyectos = cant_proyectos;
            this.tipo_test = tipo_test;
        }

        internal Tipo_test Tipo_test { get => tipo_test; set => tipo_test = value; }
        public int Cant_proyectos { get => cant_proyectos; set => cant_proyectos = value; }

        public void mostrarCant_proyectos()
        {
            Console.WriteLine($"La cantidad de proyectos son: {Cant_proyectos}");
        }

        public void agregarProyecto(string nombre_proyecto)
        {
            Console.WriteLine($"El proyecto que se agregara es {nombre_proyecto}");
            Console.WriteLine("Agregando proyecto");
            Cant_proyectos += 1;
        }
        public void mostrarTipo_test()
        {
            Console.WriteLine($"El tipo de test es: {Tipo_test}");
        }

        public void mostrar_datos_Personales()
        {
            Console.WriteLine($"El nombre del programador es: {nombre} {apellido} y su tiene {edad} años de edad ");
        }
    }
}
