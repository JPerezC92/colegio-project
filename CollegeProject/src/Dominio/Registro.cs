using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeProject.src.Dominio
{
    class Registro
    {
        public List<Alumno> _alumnos;

        public Registro(List<Alumno> alumnos)
        {
            this._alumnos = alumnos;
        }

        public Alumno obtenerMejorAlumno()
        {
            Alumno mejorAlumno = null;
            this._alumnos.ForEach(
                delegate (Alumno item)
                {
                    if (mejorAlumno == null || mejorAlumno.promedio < item.promedio)
                    {
                        mejorAlumno = item;
                    }
                });
            return mejorAlumno;
        }

        public Alumno obtenerPeorAlumno()
        {
            Alumno peorAlumno = null;
            this._alumnos.ForEach(
                delegate (Alumno item)
                {
                    if (peorAlumno != null || peorAlumno.promedio > item.promedio)
                    {
                        peorAlumno = item;
                    }
                });
            return peorAlumno;
        }

        public float promedioDeClase()
        {
            float sumaPromedios = 0;
            float cantidadAlumnos = 0;
            this._alumnos.ForEach(
                delegate (Alumno item)
                {
                    if (item.promedio > 0)
                    {
                        sumaPromedios += item.promedio;
                        cantidadAlumnos += 1;
                    }
                });

            return sumaPromedios / cantidadAlumnos;

        }

        public Dictionary<String, String> obtenerInformacionGeneral()
        {
            Dictionary<String, String> datos = new Dictionary<String, String>();

            datos.Add("mejorAlumno", this.obtenerMejorAlumno().nombres);
            //datos.Add("nombres", this.obtenerPeorAlumno().nombres);
            datos.Add("promedioClase", this.promedioDeClase().ToString());
            //datos.Add("nivel", this.nivel);
            return datos;
        }




    }
}
