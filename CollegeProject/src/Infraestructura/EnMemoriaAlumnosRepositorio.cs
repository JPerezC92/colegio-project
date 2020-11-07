using CollegeProject.src.Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace CollegeProject.src.Infraestructura
{
    class EnMemoriaAlumnosRepositorio : AlumnoRepositorio
    {
        public List<Alumno> alumnos = new List<Alumno>();

        public void guardar(Alumno alumno)
        {
            this.alumnos.Add(alumno);
        }

        public List<Alumno> obtenerTodos()
        {
            return this.alumnos;
        }

        public Alumno obtener(int id)
        {
            Alumno alumno = this.alumnos.Find(
                delegate (Alumno item)
                {
                    return item._id == id;
                }
                );
            return alumno;

        }
        public void actualizar(Alumno alumno)
        {
            int index = this.alumnos.FindIndex(item => item._id == alumno._id);
            this.alumnos[index] = alumno;
        }

    }
}
