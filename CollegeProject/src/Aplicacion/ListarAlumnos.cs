using CollegeProject.src.Dominio;
using System;
using System.Collections.Generic;

namespace CollegeProject.src.Aplicacion
{
    class ListarAlumnos
    {
        private readonly AlumnoRepositorio _repositorio;

        public ListarAlumnos(AlumnoRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }
        public List<Dictionary<String, String>> ejecutar()
        {
            List<Alumno> alumnos = this._repositorio.obtenerTodos();

            Registro registro = new Registro(alumnos);




            return registro.data();
        }
    }
}
