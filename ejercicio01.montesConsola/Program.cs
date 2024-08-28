using Ejercicio01.Montes.Consola;
using RecuperatorioPrimerParcialPooTema1;

namespace ejercicio01.montesConsola
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecicio 1 Esfera ");

            var lado = ConsoleExtensions.ReadDouble("Ingrese el valor del lado del cuadrado:");
            Esfera cuadrado = new Esfera(lado);

        }
    }
}
