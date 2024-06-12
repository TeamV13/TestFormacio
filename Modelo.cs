using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormacio
{
    public class BBDD
    {
        public BBDD(){}
        public BBDD(string nombre, string poblacion, int edad, List<string> amigos)
        {
            this.nombre = nombre;
            this.poblacion = poblacion;
            this.edad = edad;
            this.amigos = amigos;
        }

        public string nombre {  get; set; }
        public string poblacion { get; set; }
        public int edad { get; set; }
        public List<string> amigos { get; set; }

        public override string ToString()
        {
            return string.Format("{0} de {1} tiene {2} y {3} colegas", this.nombre, this.poblacion, this.edad, this.amigos.Count); ;
        }

    }
}
