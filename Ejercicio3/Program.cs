using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Modelo;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Consulta 1 */

            using (Ejercicio3Entities1 svcContext = new Ejercicio3Entities1())
            {
                var query1 = from a in svcContext.Domicilio
                             join b in svcContext.Persona
                             on a.Nombre equals b.Nombre
                             where a.Nombre == b.Nombre
                             select a;


                foreach (var a in query1)
                {
                    System.Console.WriteLine(a.Nombre + ", " + a.Direccion + ", " + a.Persona.Edad);
                }
                Console.ReadKey();
            }

            /* Consulta 2 */

            using (Ejercicio3Entities1 svcContext = new Ejercicio3Entities1())
            {
                var query2 = from p in svcContext.Persona
                             where p.Edad >= 18
                             select p;


                foreach (var p in query2)
                {
                    System.Console.WriteLine(p.Nombre + ", " + p.Edad);
                }
                Console.ReadKey();
            }

        }
    }
}
