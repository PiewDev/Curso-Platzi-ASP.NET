using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platzi_ASP_NET_CORE.Models
{
    public class EscuelaContext: DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var escuela = new Escuela()
            {
                AñoDeCreación = 2005,
                Nombre = "Platzi",
                Ciudad = "Rafaela",
                Pais = "Argentina",
                Dirección = "Los Colonos 8100",
                TipoEscuela = TiposEscuela.Secundaria

            };

            var cursos = CargarCursos(escuela);
            var asignaturas = CargarAsignaturas(cursos);
            var alumnos = CargarAlumnos(cursos);

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());


        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();
            foreach (var curso in cursos)
            {
                var tmplist = new List<Asignatura>()
                {
                    new Asignatura{Nombre="Matemáticas", CursoId = curso.Id},
                    new Asignatura{Nombre="Educación Física", CursoId = curso.Id },
                    new Asignatura{Nombre="Castellano", CursoId = curso.Id },
                    new Asignatura{Nombre="Ciencias Naturales", CursoId = curso.Id },
                    new Asignatura{Nombre="Programacion", CursoId = curso.Id}
                };
                listaCompleta.AddRange(tmplist);
                


            }
            return listaCompleta;
        }

        private List<Curso> CargarCursos(Escuela escuela)
        {
            return new List<Curso>()
            {
                new Curso{EscuelaID = escuela.Id, Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso{EscuelaID = escuela.Id, Nombre = "201", Jornada = TiposJornada.Tarde},
                new Curso{EscuelaID = escuela.Id, Nombre = "301", Jornada = TiposJornada.Noche},
                new Curso{EscuelaID = escuela.Id, Nombre = "401", Jornada = TiposJornada.Mañana},
                new Curso{EscuelaID = escuela.Id, Nombre = "501", Jornada = TiposJornada.Mañana},
            };
        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listaAlumnos = new List<Alumno>();
            Random rnd = new Random();
            foreach (var curso in cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var tmplist = GenerarAlumnosAlAzar(cantRandom, curso);
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;

        }
        private List<Alumno> GenerarAlumnosAlAzar(int cantidad, Curso curso)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   CursoId = curso.Id,
                                   Nombre = $"{n1} {n2} {a1}"

                               };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }
    }
}

