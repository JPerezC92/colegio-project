using CollegeProject.src.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeProject.src.Aplicacion
{

    class MejorAlumno
    {
        AlumnoRepositorio _repositorio;

        public MejorAlumno(AlumnoRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }
    }
}
