
using Ejercicio02.Entidades;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un CUIL/CUIT (formato XX-XXXXXXXX-X):");
            string? cuilCuit = Console.ReadLine();
          
            bool esValido = ValidadordeCUIT.Validar(cuilCuit!);

            if (!esValido)
            {
                Console.WriteLine("El CUIL/CUIT es válido.");
            }
            else
            {
                Console.WriteLine("El CUIL/CUIT es inválido.");
            }

        }
    }
}
