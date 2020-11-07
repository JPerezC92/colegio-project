using CollegeProject.src.Infraestructura;
using CollegeProject.src.Aplicacion;
using CollegeProject.src.Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeProject
{
    public partial class Form1 : Form
    {
        AlumnosControlador alumnoControlador;

        public Form1()
        {
            InitializeComponent();

            this.alumnoControlador = new AlumnosControlador();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            this.agregarRegistro();


            this.aniadirRegistros();

            this.aniadirInformacionGeneral();
        }

        private void aniadirRegistros()
        {

            List<Dictionary<String, String>> registros = alumnoControlador.cargarRegistros();

            listAlumnos.Items.Clear();

            foreach (var item in registros)
            {
                String[] subItems = new string[] {
                    item["id"],
                    item["nombres"],
                    item["practica"],
                    item["parcial"],
                    item["examen"],
                    item["promedio"],
                    item["nivel"]
                };

                ListViewItem listViewAlumnos = new ListViewItem(subItems);
                listAlumnos.Items.Add(listViewAlumnos);
            }

        }

        private void agregarRegistro()
        {
            alumnoControlador.agregarRegistro(
                int.Parse(textBoxCodigo.Text),
                textBoxNombres.Text,
                float.Parse(textBoxPractica.Text),
                float.Parse(textBoxParcial.Text),
                float.Parse(textBoxExamen.Text)
        );
        }

        private void aniadirInformacionGeneral()
        {
            Dictionary<String, String> informacionGeneral = alumnoControlador.cargarInformacionGeneral();

            textBoxMejorAlumno.Text = informacionGeneral["mejorAlumno"];
            textBoxPeorAlumno.Text = informacionGeneral["peorAlumno"];
            textBoxPromedioClase.Text = informacionGeneral["promedioClase"];
            textBoxAprobados.Text = informacionGeneral["aprobados"];
            textBoxDesaprobados.Text = informacionGeneral["desaprobados"];
        }
    }
}
