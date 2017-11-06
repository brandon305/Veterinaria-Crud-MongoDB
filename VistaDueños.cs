using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CRUD_MongoDB
{
    public partial class VistaDueños : Form
    {
        
        public VistaDueños()
        {

            InitializeComponent();
            
        }

        private void VistaDueños_Load(object sender, EventArgs e)
        {
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var servidor = mc.GetServer();
            var database = servidor.GetDatabase("Veterinaria");
            servidor.Connect();
            var coleccion = database.GetCollection<Dueño>("dueños");
            dataGridViewDueños.DataSource = coleccion.FindAll().ToList();
        }
    }
}
