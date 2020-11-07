using System;
using System.Collections.Generic;
using System.Linq;

namespace CollegeProject.src.Dominio
{
    class Alumno
    {
        public int _id;
        public String nombres;
        public List<Evaluacion> evaluaciones = new List<Evaluacion>();
        public float promedio;
        private enum condicion { Excelente, Bueno, Malo, Pesimo };
        public String nivel;

        public Alumno(int id, String nombres)
        {
            this._id = id;
            this.nombres = nombres;
        }

        public void aniadirEvaluacion(Evaluacion evaluacion)
        {
            this.evaluaciones.Add(evaluacion);
            this.calcularPromedio();
        }

        private void calcularPromedio()
        {
            if (this.evaluaciones.Count() == 3)
            {
                this.promedio = 0.0f;
                foreach (Evaluacion evaluacion in this.evaluaciones)
                {
                    this.promedio += evaluacion._calificacion * (evaluacion.valor / 100);
                }
                this.calcularNivel();
            }
        }

        public Dictionary<String, String> toDictionary()
        {
            Dictionary<String, String> alumnoData = new Dictionary<String, String>();

            this.evaluaciones.ForEach(
                delegate (Evaluacion item)
                {
                    alumnoData.Add(
                        item._tipo,
                        item._calificacion.ToString());
                }
                );

            alumnoData.Add("id", this._id.ToString());
            alumnoData.Add("nombres", this.nombres);
            alumnoData.Add("promedio", this.promedio.ToString());
            alumnoData.Add("nivel", this.nivel);
            return alumnoData;
        }

        private void calcularNivel()
        {
            if ((this.promedio > 0) && (this.promedio <= 5))
            {
                this.nivel = condicion.Pesimo.ToString();
            }
            if ((this.promedio >= 6) && (this.promedio <= 10))
            {
                this.nivel = condicion.Malo.ToString();
            }
            if ((this.promedio >= 11) && (this.promedio <= 15))
            {
                this.nivel = condicion.Bueno.ToString();
            }
            if ((this.promedio >= 16) && (this.promedio <= 20))
            {
                this.nivel = condicion.Excelente.ToString();
            }

        }

    }
}
