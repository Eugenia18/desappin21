//Caclular el area de n Circulo

using System;

namespace p02_areacirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            float radio=0; //Definir variable
            double area=0;
            Console.WriteLine("Calculando el Area de un Circulo");
            Console.WriteLine("Dame el radio?");
            radio = float.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(radio,2); //Elevar al cuadrado
            Console.WriteLine($"El area del circulo es {area}");

        }
    }
}
