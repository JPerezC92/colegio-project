using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeProject.src.Dominio
{
    class Evaluacion
    {
        public String _tipo;
        public float _calificacion;
        public float valor;
        public Evaluacion(String tipo, float calificacion, float valor)
        {
            this._tipo = tipo;
            this._calificacion = calificacion;
            this.valor = valor;
        }


    }
}
