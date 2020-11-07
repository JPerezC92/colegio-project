using CollegeProject.src.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollegeProject.src.Aplicacion
{
    class Calificar
    {
        private readonly AlumnoRepositorio _repositorio;

        public Calificar(AlumnoRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public void ejecutar(int id, float practica, float parcial, float examen)
        {
            Alumno alumno = this._repositorio.obtener(id);

            Evaluacion _practica = new Evaluacion("practica", practica, 20.0f);
            Evaluacion _parcial = new Evaluacion("parcial", parcial, 30.0f);
            Evaluacion _examen = new Evaluacion("examen", examen, 50.0f);

            alumno.aniadirEvaluacion(_practica);
            alumno.aniadirEvaluacion(_parcial);
            alumno.aniadirEvaluacion(_examen);

            this._repositorio.actualizar(alumno);
        }
    }
}
