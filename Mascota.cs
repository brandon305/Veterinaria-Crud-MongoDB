using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MongoDB
{
    class Mascota
    {
         public string nombre { get; set; }
        public string raza { get; set; }
        public string dueño { get; set; }
        public string edad { get; set; }
        public Object id { get; set; }

        public Mascota(){}

        public Mascota(string nombre, string raza, string dueño, string edad, Object id)
        {
            this.nombre=nombre;
            this.raza = raza;
            this.dueño = dueño;
            this.edad = edad;
            this.id = id;
        }
    }
}
