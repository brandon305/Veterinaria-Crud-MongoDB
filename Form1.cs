using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;


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

        private void eliminarDueño_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var servidor = mc.GetServer();
                var database = servidor.GetDatabase("Veterinaria");
                servidor.Connect();
                var coleccion = database.GetCollection<Dueño>("dueños");
                coleccion.Remove(Query.EQ("nombre",lblnombre.Text));
                MessageBox.Show("Se borro correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("ocurrio un error:" + error);
            }
        }

        private void eliminarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var servidor = mc.GetServer();
                var database = servidor.GetDatabase("Veterinaria");
                servidor.Connect();
                var coleccion = database.GetCollection<Mascota>("mascotas");
                coleccion.Remove(Query.EQ("nombre", lblnombremascota.Text));
                MessageBox.Show("Se borro correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("ocurrio un error:" + error);
            }
        }

        private void actualizarDueño_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var servidor = mc.GetServer();
                var database = servidor.GetDatabase("Veterinaria");
                servidor.Connect();
                var coleccion = database.GetCollection<Dueño>("dueños");

                var query = Query.EQ("nombre", lblnombre.Text);
                var dueño = coleccion.FindOne(query);
                dueño.numero = lblnumero.Text;
                dueño.direccion = lbldireccion.Text;
                dueño.sexo = lblsexo.Text;
                coleccion.Save(dueño);

                MessageBox.Show("Se actualizo correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("ocurrio un error:" + error);
            }
        }

        private void actualizarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var servidor = mc.GetServer();
                var database = servidor.GetDatabase("Veterinaria");
                servidor.Connect();
                var coleccion = database.GetCollection<Mascota>("mascotas");

                var query = Query.EQ("nombre", lblnombremascota.Text);
                var mascota = coleccion.FindOne(query);
                mascota.raza = lblraza.Text;
                mascota.dueño = lbldueño.Text;
                mascota.edad = lbledad.Text;
                coleccion.Save(mascota);

                MessageBox.Show("Se actualizo correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("ocurrio un error:" + error);
            }
        }

    
    }
}
