using System.Text;

namespace Ejercicio01.Montes.Consola
{
    public class Esfera
    {
        private int Radio { get; }
        private double Diametro { get; set; { return Diametro * 2; } } 
        public Esfera(int radio, double diametro)
        {
            if (radio > 0)
            {
                Radio = radio;
                Diametro =diametro;

            }
            else
            {
                throw new ArgumentException("El radio tiene que ser mayor a 0");
            }
        }

        public double GetPerimetro() => 4 *( Math.PI * Math.Pow(Radio,2));
        public double GetArea() => 4*(Math.PI * Math.Pow(Radio, 3));

        public string ImprimirInformacion()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Esfera con un radio de " + Radio);
            sb.AppendLine("Con un Perímetro de: " + GetPerimetro());
            sb.AppendLine("Con un Área de: " + GetArea());
            return sb.ToString();
        }

    }
}
