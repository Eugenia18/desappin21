using System;
using System.IO;

namespace p18_repasopoov2
{
    class Program
    {
        static void Main(string[] args)
        {
            Red mired = null;
            string arch = "datos.json";
           
            
            if(File.Exists(arch)) {
                // cargar los datos del archivo que ya existe en disco: datos.xml
                Console.WriteLine($"Cargando los datos del archivo de disco : {arch}");
                //Utils.LeerXml(arch, ref mired);
                Utils.LeerJson(arch, ref mired);
            }
            else {
                Console.WriteLine($"Inicializando datos desde el codigo ...");
                Inicializa(ref mired);  
                // grabar los datos al disco en el archivo datos.xml
                //Utils.GrabarXml(arch, mired);
                Utils.GrabarJson(arch, mired);
            }

            Reporte(mired);         
        }

        static void Inicializa(ref Red mired) {
            // Inicializar datos
            mired = new Escuela("Universidad Patito SA de CV","Ing. Juan Perez","Av. de la Juventud 348");
            mired.AgregarProfesor(new Profesor("Jose Diaz","DateTime.Parse("01/01/2018")","1A","Fisica","Salario,1200"));
            mired.AgregarProfesor(new Profesor("Maria Perez","DateTime.Parse("10/2/2016")","2A","Algebra","Salario, 3400"));
            mired.AgregarProfesor(new Profesor("Claudia Sid","DateTime.Parse("01/4/2019")","4B","Calculo","Salario, 3800"));
            mired.AgregarProfesor(new Profesor("Crlos Lopez","DateTime.Parse("01/1/2016")","8A","Quimica","Salario, 1000"));
            mired.Profesor[0].AgregarAlumno(new Alumno("Fatima Soto","23",
                "DateTime.Parse("01/01/2019")","si",7,7,7));
            mired.Profesor[1].AgregarAlumno(new Alumno("Damian Diaz","25",
                "DateTime.Parse("01/01/2016")","no",8,8,8));
            mired.Profesor[2].AgregarAlumno(new Alumno("Fatima soto", "23",
                "DateTime.Parse("01/01/2018")","si",6,6,6));
            }

        static void Reporte(Escuela mired) {
            // Reporte 
            Console.WriteLine("\n>> Datos generales del escuela:");
            Console.WriteLine($"Nombre     : {miescuela.nombre}");
            Console.WriteLine($"Encargado : {miescuela.encargado}");
            Console.WriteLine($"Domicilio   : {miescuela.domicilio}");
            Console.WriteLine($"Total profesores escuela : {miescuela.profesores.Count}");
            Console.WriteLine($"Total alumnos : {miescuela.TotVuln}");

            Console.WriteLine("\n>>Datos generales de los profesores:");
            mired.profesores.ForEach(n=>Console.WriteLine(n.ToString()));
            Console.WriteLine($"Mayor numero de saltos: {mired.Mayor} ");
            Console.WriteLine($"Menor numero de saltos: {mired.Menor} ");
            Console.WriteLine("\n>> Alumnos por nodo:");
            foreach(Nodo n in mired.nodos) {
                Console.WriteLine($"\n> Ip: {n.ip}, Tipo: {n.tipo}\n");
                n.alumnos.ForEach(v=>Console.WriteLine(v.ToString()));
            }
        }
    }
}
