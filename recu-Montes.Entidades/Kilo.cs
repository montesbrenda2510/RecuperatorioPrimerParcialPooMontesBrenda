namespace recu_Montes.Entidades
{
    public class Kilo
    { 
         private float peso;

        public Kilo(float peso = 5)
        {
            this.peso = peso;
        }

        public float ObtenerPeso()
        {
           return peso;
        }
            
        public void EstablecerPeso(float nuevoPeso)
        {
           peso = nuevoPeso;
        }
        
        public static implicit operator Kilo(float peso)
        {
            return new Kilo(peso);
        }

        
        public static implicit operator float(Kilo kilo)
        {
            return kilo.peso;
        }
        
        public static explicit operator Libra(Kilo kilo)
        {
            float pesoEnLibras = kilo.peso * 2.20462f;
            return new Libra(pesoEnLibras);
        }
       
        public static bool operator ==(Kilo k1, Kilo k2)
        {
            if (ReferenceEquals(k1, null) || ReferenceEquals(k2, null))
            {
                return ReferenceEquals(k1, k2);
            }
            return k1.peso == k2.peso;
        }

       
        public static bool operator !=(Kilo k1, Kilo k2)
        {
            return !(k1 == k2);
        }
        
        public static Kilo operator +(Kilo k1, Kilo k2)
        {
            return new Kilo(k1.peso + k2.peso);
        }

        
        public static Kilo operator +(Kilo k, Libra l)
        {
            float pesoConvertido = l.ObtenerPeso() * 0.45359237f;
            return new Kilo(k.peso + pesoConvertido);
        }

       
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Kilo))
            {
                return false;
            }
            return this == (Kilo)obj;
        }

        
        public override int GetHashCode()
        {
            return peso.GetHashCode();
        }

    }
}
