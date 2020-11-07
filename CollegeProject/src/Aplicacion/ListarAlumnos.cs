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
            List<Dictionary<String, String>> data = new List<Dictionary<String, String>>();

            List<Alumno> alumnos = this._repositorio.obtenerTodos();

            foreach (Alumno item in alumnos)
            {
                data.Add(item.toDictionary());
            }

            return data;
        }
    }
}
