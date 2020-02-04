using System;
using System.Collections.Generic;

namespace Platzi_ASP_NET_CORE.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public string CursoId { get; set; }
        public Curso Curso { get; set; }

        public List<Evaluación> Evaluaciones { get; set; }
    }
}