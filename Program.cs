using System;
using System.Linq;

namespace ITLA_Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimerArray();
            //SegundoArray();
            //TercerArray();
            //CuartoArray();
            //QuintoArray();
            //SextoArray();
            //SeptimoArray();
            //OctavoArray();
            //NovenoArray();
            //DecimoArray();
        }
        static void PrimerArray(){
            double media = 0;
            int cantidad = 4;
            int[] numeros = new int[cantidad];
            Console.WriteLine("Ingrese los cuatro números.");
            for (int i = 0; i < numeros.Length; i++){
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                media = media + numeros[i];
            }
            media /= cantidad;
            Console.WriteLine($"Los números en el array son:");
            for (int i = 0; i < numeros.Length; i++){
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine($"La media aritmetica es: {media}");
        }
    }
}
