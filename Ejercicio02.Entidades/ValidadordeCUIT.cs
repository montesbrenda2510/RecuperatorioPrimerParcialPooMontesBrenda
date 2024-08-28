using System.Text.RegularExpressions;

namespace Ejercicio02.Entidades
{
    public static class ValidadordeCUIT
    {
        public enum Tipo
        {
            Empresa = 30,
            Hombre = 20,
            Mujer = 27
        }
        public static bool Validar(string cuilCuit)
        {
            if (!EsFormatoValido(cuilCuit))
            {
                return false;
            }

            Tipo tipo = ObtenerTipo(cuilCuit);

            string[] partes = cuilCuit.Split('-');
            string dni = partes[1];
            int digitoVerificador = int.Parse(partes[2]);

            if (!EsDigitoVerificadorValido(tipo, dni, digitoVerificador))
            {
                Console.WriteLine("El dígito verificador del CUIL/CUIT no es válido.");
                return false;
            }
            return true;
        }

        private static bool EsFormatoValido(string cuilCuit)
        {
            string p = @"^\d{2}-\d{8}-\d{1}$";
            return Regex.IsMatch(cuilCuit, p);
        }


        private static Tipo ObtenerTipo(string cuilCuit)
        {
            string tipoStr = cuilCuit.Substring(0, 2);
            if (int.TryParse(tipoStr, out int tipo))
            {
                return (Tipo)tipo;
            }
            throw new ArgumentException("Tipo de CUIL/CUIT no válido.");
        }


        private static bool EsDigitoVerificadorValido(Tipo tipo, string dni, int digitoVerificador)
        {
            string cuilCuitSinVerificador = ((int)tipo).ToString() + dni;
            int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };

            int suma = 0;
            for (int i = 0; i < multiplicadores.Length; i++)
            {
                suma += int.Parse(cuilCuitSinVerificador[i].ToString()) * multiplicadores[i];
            }

            int mod11 = suma % 11;
            int digitoCalculado = mod11 == 0 ? 0 : mod11 == 1 ? 9 : 11 - mod11;

            return digitoCalculado == digitoVerificador;
        }


    }


}
