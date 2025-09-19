using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial_Anterior_practica.Clases;
using Parcial_Anterior_practica.Enums;

namespace Parcial_Anterior_practica.Servicio
{
    internal class FactoryEmpleado
    {
        //metodo para fabricar automatizadamente programadores.
        public List<Programador> crearProgramador(int cantindad)
        {
            List<Programador> programadores = new List<Programador>();
            for (int i = 0; i < cantindad; i++)
            {
                Programador programador = new Programador();
                Console.WriteLine("Ingrese el nombre del programador: ");
                programador._nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido del programador: ");
                programador._apellido = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del programador: ");
                programador._edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el seniority del programador: ");
                programador.Seniority = Console.ReadLine();
                Console.WriteLine("Ingrese el lenguaje principal del programador: ");
                programador.Lenguaje_principal = Console.ReadLine();
                programadores.Add(programador);
            }
            return programadores;
        }

        // metodo para fabricar automatizadamente testers.
        public List<Tester> crearTester(int cantindad)
        {
            List<Tester> testers = new List<Tester>();
            for (int i = 0; i < cantindad; i++)
            {
                Tester tester = new Tester();
                Console.WriteLine("Ingrese el nombre del tester: ");
                tester._nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido del tester: ");
                tester._apellido = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del tester: ");
                tester._edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de proyectos del tester: ");
                tester.Cant_proyectos = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    tester.Tipo_test = Tipo_test.manual;
                }
                else
                {
                    tester.Tipo_test = Tipo_test.automatico;
                }
                testers.Add(tester);
            }
            return testers;
        }
    }
}

