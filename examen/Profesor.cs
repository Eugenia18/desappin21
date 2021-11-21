using System.Collections.Generic;

namespace p18_repasopoov2
{
    public class Profesor {

        public Profesor() => Alumnos = new List<Alumno>();

        public Profesor(string pnombre,string pfechaing,int pgrupo,int pmateria,string salario) : this() =>
            (nombre,fechaing,grupo,materia,salario) = (pnombre,pfechaing,pgrupo,pmateria,psalario);

        public string nombre {get;  set;}
        public string fechaing {get;  set;}
        public int grupo {get;  set;}
        public int materia {get;  set;}
        public string salario {get;  set;}
        public List<Alumno> Alumnos {get;  set;}

        public void AgregarAlumno(Alumno v) => Alumnos.Add(v);

        public override string ToString() => 
                $"Nombre: {nombre,-12} Fechaing: {fechaing.ToString("dd/mm/yy"),-8} Grupo: {grupo,-3} Materia: {materia,-3} Salario: {salario,-8} TotV: {alumnos.Count}";
    }

}