using recu_Montes.Entidades;

Console.WriteLine("Ejercicio 3 kilos y libras");

       Kilo pesoEnKilos = new Kilo(70.0f);
       Libra pesoEnLibras = new Libra(154.3f);
       
   
       Kilo sumaKilos = pesoEnKilos;
       Console.WriteLine($"Suma de Kilos: {sumaKilos.ObtenerPeso()} kg");

   
       Libra sumaLibras = pesoEnLibras ;
       Console.WriteLine($"Suma de Libras: {sumaLibras.ObtenerPeso()} lb");

    
       Kilo sumaKiloLibra = pesoEnKilos + pesoEnLibras;
       Console.WriteLine($"Suma de Kilo y Libra (en Kilos): {sumaKiloLibra.ObtenerPeso()} kg");

   
       Libra sumaLibraKilo = pesoEnLibras + pesoEnKilos;
       Console.WriteLine($"Suma de Libra y Kilo (en Libras): {sumaLibraKilo.ObtenerPeso()} lb");

    
        Kilo otroPesoEnKilos = new Kilo(70.0f);
        Console.WriteLine($"¿pesoEnKilos == otroPesoEnKilos?: {pesoEnKilos == otroPesoEnKilos}");

    
        Libra otraPesoEnLibras = new Libra(154.3f);
       Console.WriteLine($"¿pesoEnLibras == otraPesoEnLibras?: {pesoEnLibras == otraPesoEnLibras}");

    
       Kilo pesoDiferenteEnKilos = new Kilo(75.0f);
       Console.WriteLine($"¿pesoEnKilos != pesoDiferenteEnKilos?: {pesoEnKilos != pesoDiferenteEnKilos}");

    
       Libra pesoDiferenteEnLibras = new Libra(154.0f);
       Console.WriteLine($"¿pesoEnLibras != pesoDiferenteEnLibras?: {pesoEnLibras != pesoDiferenteEnLibras}");
