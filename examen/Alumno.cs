using System;
namespace p18_repasopoov2
{
    public class Alumno {

        public Alumno() {}

        public Alumno(string pnombre,string pedad,string pfachaing,string pbecado,DateTime pcalificaciones) =>
            (nombre,edad,fachaing,becado,calificaciones) = (pnombre,pedad,pfachaing,pbecado,pcalificaciones);

         public string nombre {get;  set;}
        public string edad {get;  set;}
        public string fachaing {get;  set;}
        public string becado {get;  set;}
        public DateTime calificaciones {get;  set;}
        {
            get {
                return DateTime.Now.Year - fecha.Year;
            }
        }

        public override string ToString() =>
            $"Nombre: {nombre,-12} Edad: {edad,-10} Fachaing: {fechaing.ToString("dd/mm/yy"),-8} Becado: {becado,-8} " +
            $"Calificaciones: {calificaciones -10} 
    }
}