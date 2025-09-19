using Parcial_Anterior_practica.Clases;
using Parcial_Anterior_practica.Enums;
using Parcial_Anterior_practica.Servicio;

namespace Parcial_Anterior_practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryEmpleado fabricaEmpleado = new FactoryEmpleado();
            List<Programador> empleados_programadores = new List<Programador>();
            empleados_programadores = fabricaEmpleado.crearProgramador(2);
            List<Tester> empleados_testers = new List<Tester>();
            empleados_testers = fabricaEmpleado.crearTester(2);


            foreach (Programador prog in empleados_programadores) {

                Console.WriteLine($"Nombre : {prog._nombre}, apellido: {prog._apellido}, edad: {prog._edad}, " +
                    $"lenguaje_base: {prog.Lenguaje_principal}, seniority:{prog.Seniority}.");
            }

            foreach (Tester test in empleados_testers)
            {

                Console.WriteLine($"Nombre : {test._nombre}, apellido: {test._apellido}, edad: {test._edad}, " +
                    $" cantidad de proyectos: {test.Cant_proyectos}, tipo_test: {test.Tipo_test}. ");
            }
        }
    }
}
        

