using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace p18_repasopoov2
{
    public static class Utils {
        public static void GrabarXml(string arch, Escuela escuela) {
            FileStream f = File.Open(arch, FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(Escuela));
            xml.Serialize(f,red);
        }
        public static void LeerXml(string arch, ref Escuela escuela) {
            FileStream f = File.Open(arch, FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(Escuela));
            escuela = (Escuela) xml.Deserialize(f);
        }
        public static void GrabarJson(string arch, Escuela escuela) {
             StreamWriter f = File.CreateText(arch);
             JsonSerializer json = new JsonSerializer();
             json.Serialize(f, escuela);
             f.Close();
        }
        public static void LeerJson(string arch, ref Escuela escuela) {
           StreamReader f = File.OpenText(arch);
           string txt = f.ReadToEnd();
           escuela = JsonConvert.DeserializeObject<Escuela>(txt);
        }
    }
}