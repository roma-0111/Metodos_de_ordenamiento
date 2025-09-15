using System.ComponentModel;
using System.Globalization;

namespace InsercionDirecta;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 3, 2, 1, 9, 12 };

        Console.WriteLine("Su orden originalmente: ");

        //MostrarArreglo:
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("");

        //InserciónDirecta:

        int cantNumeros = numeros.Length;

        //Comienza desde el segundo elemento (índice 1)
        for (int c = 1; c < cantNumeros; c++)
        {
            int clave = numeros[c];
            int j = c - 1;

            //Desplazamos los elementos mayores que clave
            while (j >= 0 && numeros[j] > clave)
            {
                numeros[j + 1] = numeros[j];
                j--;
            }
            //Insertamos la clave en su posición correcta
            numeros[j + 1] = clave;
        }

        Console.WriteLine("");
        Console.WriteLine("Ordenado: ");

        //MostrarArreglo:

        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }    
        Console.WriteLine("");
    }
}