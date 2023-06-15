using System;

namespace TablasMultiplicar
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Genere un código que cumpla con lo siguiente: (Version Switch-case)
        Se debe contar con un parámetro de entrada, este parámetro tendrá el valor de un color (De los mencionado más adelante), este parámetro debe diferenciarse entre las siguientes opciones “Amarillo”, “Morado”, “Rosa”, “Azul”, “Blanco” e imprimirá lo siguiente dependiendo de la opción ingresada por el usuario:
        Amarillo = La Tabla del 2. 
        Morado = Tabla del 7
        Rosa = Tabla del 9
        Azul = Tabla del 6
        Blanco = Tabla del 12
      */
      Console.WriteLine("Ingrese un color (Amarillo, Morado, Rosa, Azul, Blanco):");
      string color = Console.ReadLine();

      imprimirTablaMultiplicarSwitch(color);

      Console.ReadLine();
    }

    static void imprimirTablaMultiplicarSwitch(string color)
    {
      switch (color)
      {
        case "Amarillo":
          Console.WriteLine("Tabla del 2:");
          for (int i = 1; i <= 10; i++)
          {
            int resultado = 2 * i;
            Console.WriteLine($"2x{i} = {resultado}");
          }
          break;
        case "Morado":
          Console.WriteLine("Tabla del 7:");
          for (int i = 1; i <= 10; i++)
          {
            int resultado = 7 * i;
            Console.WriteLine($"7x{i} = {resultado}");
          }
          break;
        case "Rosa":
          Console.WriteLine("Tabla del 9:");
          for (int i = 1; i <= 10; i++)
          {
            int resultado = 9 * i;
            Console.WriteLine($"9x{i} = {resultado}");
          }
          break;
        case "Azul":
          Console.WriteLine("Tabla del 6:");
          for (int i = 1; i <= 10; i++)
          {
            int resultado = 6 * i;
            Console.WriteLine($"6x{i} = {resultado}");
          }
          break;
        case "Blanco":
          Console.WriteLine("Tabla del 12:");
          for (int i = 1; i <= 10; i++)
          {
            int resultado = 12 * i;
            Console.WriteLine($"12x{i} = {resultado}");
          }
          break;
        default:
          Console.WriteLine("Color no válido.");
          break;
      }
    }
  }
}
