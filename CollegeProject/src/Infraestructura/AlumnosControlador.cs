using CollegeProject.src.Aplicacion;
using CollegeProject.src.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeProject.src.Infraestructura
{
    class AlumnosControlador
    {
        EnMemoriaAlumnosRepositorio EnMemoriaRepositorio = new EnMemoriaAlumnosRepositorio();

        public void agregarRegistro(int id, string nombres, float practica = 0, float parcial = 0, float examen = 0)
        {

            RegistrarAlumno registrarAlumno = new RegistrarAlumno(this.EnMemoriaRepositorio);

            registrarAlumno.ejecutar(id, nombres);

            new Calificar(this.EnMemoriaRepositorio).ejecutar(id, practica, parcial, examen);

        }

        public List<Dictionary<String, String>> cargarRegistros()
        {
            ListarAlumnos listarAlumnos = new ListarAlumnos(this.EnMemoriaRepositorio);

            return listarAlumnos.ejecutar();
        }

        public Dictionary<String, String> cargarInformacionGeneral()
        {
            InformacionGeneral informacionGeneral = new InformacionGeneral(this.EnMemoriaRepositorio);
            return informacionGeneral.ejecutar();
        }
    }
}
