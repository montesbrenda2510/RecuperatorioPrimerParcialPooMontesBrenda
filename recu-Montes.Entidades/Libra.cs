using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recu_Montes.Entidades
{
    public  class Libra
    {    
         private float peso;

        public Libra(float peso = 5)
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
        
        public static implicit operator Libra(float peso)
        {
            return new Libra(peso);
        }

        public static implicit operator float(Libra libra)
        {
            return libra.peso;
        }

       
        public static explicit operator Kilo(Libra libra)
        {
            float pesoEnKilos = libra.peso / 2.20462f;
            return new Kilo(pesoEnKilos);
        }
      
        public static bool operator ==(Libra l1, Libra l2)
        {
            if (ReferenceEquals(l1, null) || ReferenceEquals(l2, null))
            {
                return ReferenceEquals(l1, l2);
            }
            return l1.peso == l2.peso;
        }

        
        public static bool operator !=(Libra l1, Libra l2)
        {
            return !(l1 == l2);
        }
        
        public static Libra operator +(Libra l1, Libra l2)
        {
            return new Libra(l1.peso + l2.peso);
        }

        
        public static Libra operator +(Libra l, Kilo k)
        {
            float pesoConvertido = k.ObtenerPeso() * 2.20462262f;
            return new Libra(l.peso + pesoConvertido);
        }

        
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Libra))
            {
                return false;
            }
            return this == (Libra)obj;
        }

        
        public override int GetHashCode()
        {
            return peso.GetHashCode();
        }
    }
}
