using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_estudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el promedio de un alumno

            Console.WriteLine("ESTE PROGRAMA CALCULA EL PROMEDIO DE UN ESTUDIANTE");

            double nota1, nota2, nota3, promedio;

            Console.WriteLine("Digite la nota 1");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la nota 2");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la nota 3");
            nota3= double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;
            promedio = Convert.ToDouble(promedio);

            Console.WriteLine("El promedio del estudiante es :  " + promedio);
            Console.ReadKey();




        }
    }
}
