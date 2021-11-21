using System.Collections.Generic;

namespace p18_repasopoov2
{
    public class Escuela {

        public Escuela() => profesores = new List<Profesor>();

        public Escuela(string pnombre, string pencargado, string pdomicilio) : this() =>
            (nombre,encargado,domicilio) = (pnombre,pencargado,pdomicilio);
         
        public string nombre {get;  set;}
        public string encargado {get;  set;}
        public string domicilio {get;  set;}
        public List<Profesor> profesores {get;  set;}
        public int Mayor {
            get {
                int m=profesores[0].saltos;
                foreach (Profesor n in profesores)
                    if(n.saltos>m) m = n.saltos;
                return m;
            }
        }
        public int Menor {
            get {
                int m=profesores[0].saltos;
                foreach (Profesor n in profesores)
                    if(n.saltos<m) m = n.saltos;
                return m;
            }
        }
        public int TotVuln {
            get {
                int s=0;
                foreach (Profesores n in profesores)
                     s = s + n.alumnos.Count;
                return s;
            }
        }
        
        public void AgregarProfesor(Profesor n) => Profesores.Add(n);

    }


}