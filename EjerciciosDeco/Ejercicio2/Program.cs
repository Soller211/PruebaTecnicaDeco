using System;

namespace ParImpar
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Se requiere la generación de un código que identifique cuando el numero es par o impar.
      Mensajes para mostrar:
        •	Cuando sea par mostrara el siguiente mensaje “El numero (Valor del número) es par”
        •	Cuando sea impar mostrara el siguiente mensaje “El numero (Valor del número) es impar”
      */
      Console.WriteLine("Ingrese un número:");
      int numero = Convert.ToInt32(Console.ReadLine());
      
      if (numero % 2 == 0)
      {
        Console.WriteLine($"El numero {numero} es par.");
      }
      else
      {
        Console.WriteLine($"El numero {numero} es impar.");
      }

      Console.ReadLine();
    }
  }
}

