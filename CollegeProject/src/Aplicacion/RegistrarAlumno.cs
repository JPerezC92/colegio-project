using CollegeProject.src.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeProject.src.Aplicacion
{
    class RegistrarAlumno
    {
        private readonly AlumnoRepositorio _repositorio;
        public RegistrarAlumno(AlumnoRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }
        public void ejecutar(int id, String nombres)
        {
            Alumno nuevoAlumno = new Alumno(id, nombres);
            this._repositorio.guardar(nuevoAlumno);
        }
    }
}
