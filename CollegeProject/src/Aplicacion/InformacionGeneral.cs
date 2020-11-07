using CollegeProject.src.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeProject.src.Aplicacion
{
    class InformacionGeneral
    {
        private readonly AlumnoRepositorio _repositorio;

        public InformacionGeneral(AlumnoRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public Dictionary<String, String> ejecutar()
        {
            List<Alumno> alumnos = this._repositorio.obtenerTodos();
            Registro registro = new Registro(alumnos);

            return registro.obtenerInformacionGeneral();
        }
    }
}
