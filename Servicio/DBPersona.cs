using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class DBPersona
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Celular { get; set; }


        public DBPersona() { }

        public DBPersona(int id, string Nombre, int Edad, string Celular)
        {
            this.id = id;
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Celular = Celular;
        }   
    }
}
