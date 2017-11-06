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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AgregarDueño_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var servidor = mc.GetServer();
                var database = servidor.GetDatabase("Veterinaria");
                servidor.Connect();
                var coleccion = database.GetCollection<Dueño>("dueños");
                var dueño = new Dueño { nombre = lblnombre.Text, numero = lblnumero.Text, direccion = lbldireccion.Text, sexo = lblsexo.Text };
                coleccion.Insert(dueño);
                MessageBox.Show("Datos guardados correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("ocurrio un error:" + error);
            }

        }

        private void AgregarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var servidor = mc.GetServer();
                var database = servidor.GetDatabase("Veterinaria");
                servidor.Connect();
                var coleccion = database.GetCollection<Mascota>("mascotas");
                var mascota = new Mascota { nombre = lblnombremascota.Text, raza = lblraza.Text, dueño = lbldueño.Text, edad = lbledad.Text };
                coleccion.Insert(mascota);
                MessageBox.Show("Datos guardados correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("ocurrio un error:" + error);
            }
        }

        private void MostrarDueños_Click(object sender, EventArgs e)
        {
            VistaDueños ventana1 = new VistaDueños();
            ventana1.Show();      
        }

        private void MostrarMascotas_Click(object sender, EventArgs e)
        {
            VistaMascotas ventana1 = new VistaMascotas();
            ventana1.Show();
        }

    
    }
}
