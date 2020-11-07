using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace CollegeProject.src.Dominio
{
    interface AlumnoRepositorio
    {
        void guardar(Alumno alumno);
        List<Alumno> obtenerTodos();
        Alumno obtener(int id);
        void actualizar(Alumno alumno);
    }
}
