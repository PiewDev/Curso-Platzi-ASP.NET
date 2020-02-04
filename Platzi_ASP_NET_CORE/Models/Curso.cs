using System;
using System.Collections.Generic;


namespace Platzi_ASP_NET_CORE.Models
{
    public class Curso:ObjetoEscuelaBase, ILugar
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        public string Dirección { get; set; }

        public string EscuelaID { get; set; }

        public Escuela Escuela { get; set; }

        public void LimpiarLugar()
        {
           
            Console.WriteLine("Limpiando Establecimiento...");
            Console.WriteLine($"Curso {Nombre} Limpio");
        }
    }
}