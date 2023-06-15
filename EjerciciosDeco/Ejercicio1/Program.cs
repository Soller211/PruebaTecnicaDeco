using System;

namespace InvertirCadenaTexto
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Realizar un programa donde el objetivo es invertir una cadena de texto,
       en la cual debe tener una caja de texto
       para capturar el texto que se desea invertir 
       y una caja de texto para mostrar el resultado.
      */
      Console.WriteLine("Ingrese un texto:");
      string textoOriginal = Console.ReadLine();

      string textoInvertido = InvertirTexto(textoOriginal);

      Console.WriteLine($"Texto invertido: {textoInvertido}");

      Console.ReadLine();
    }

    static string InvertirTexto(string texto)
    {
      char[] caracteres = texto.ToCharArray();
      Array.Reverse(caracteres);
      return new string(caracteres);
    }
  }
}

