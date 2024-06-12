using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormacio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utils calculos = new Utils();

            Console.WriteLine(">>>> 1era Seccio");
            Console.WriteLine(">>>> 1era Seccio - I");
            calculos.CalcularDtoComp(100,(decimal)55, (decimal)5, (decimal)2);
            Console.WriteLine(">>>> 1era Seccio - II");
            Console.WriteLine(calculos.CalcularDtoComp(100,'+',"coste"));
            Console.WriteLine(calculos.CalcularDtoComp(75.02m,'-',"valor"));
            Console.WriteLine("\n>>>> 1era Seccio - III");
            calculos.matCalcularDtoComp(new decimal[] { (decimal)55, (decimal)5, (decimal)2, (decimal)7 });

            Console.WriteLine("\n>>>> 2ona Seccio");
            Utils codAlb2PTL = new Utils();

            Console.WriteLine(codAlb2PTL.Conversion2PTL("000001/04106"));
            Console.WriteLine(codAlb2PTL.Conversion2PTL("AV-054106"));
            Console.WriteLine(codAlb2PTL.Conversion2PTL("000001-01106"));
            Console.WriteLine(codAlb2PTL.Conversion2PTL("00155561070"));
            Console.WriteLine(codAlb2PTL.Conversion2PTL("0015556107"));
            Console.WriteLine(codAlb2PTL.Conversion2PTL("000001-01/106"));
            Console.WriteLine(codAlb2PTL.Conversion2PTL("XX - AV/5670"));

            Console.WriteLine("\n>>>> 3era Seccio");

            List<BBDD> Alumnos = new List<BBDD>();

            Alumnos.Add(new BBDD("Pere", "Tona", 35, new List<string> { "Juan", "Ana", "Luis" }));
            Alumnos.Add(new BBDD("Maria", "Barcelona", 28, new List<string> { "Laura", "Carlos" }));
            Alumnos.Add(new BBDD("Jose", "Madrid", 42, new List<string> { "Marta", "Pedro", "Sofia" }));
            Alumnos.Add(new BBDD("Lucia", "Valencia", 25, new List<string> { "Andres" }));

            foreach (var alumno in Alumnos)
            {
                Console.WriteLine(alumno);
            }

            Console.ReadKey();
        }
    }
}
