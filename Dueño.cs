using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MongoDB
{
    class Dueño
    {
        public string nombre { get; set; }
        public string numero { get; set; }
        public string direccion { get; set; }
        public string sexo { get; set; }
        public Object id { get; set; }

        public Dueño(){}

        public Dueño(string nombre, string numero, string direccion, string sexo, Object id)
        {
            this.nombre=nombre;
            this.numero = numero;
            this.direccion = direccion;
            this.sexo = sexo;
            this.id = id;
        }
    }
}
