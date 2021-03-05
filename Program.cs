using System;
using System.Linq;

namespace ITLA_Tarea
{
    class Program
    {
        #region Programas
        static void Main(string[] args)
        {
            //PrimerArray();
            //SegundoArray();
            //TercerArray();
            //CuartoArray();
            QuintoArray();
            //SextoArray();
            //SeptimoArray();
            //OctavoArray();
            //NovenoArray();
            //DecimoArray();
        }
        #endregion
        
        #region PrimerArray
        static void PrimerArray(){
            double media = 0;
            int cantidad = 4;
            int[] numeros = new int[cantidad];
            Console.WriteLine("Programa #1 - Bienvenido.");
            Console.WriteLine("Ingrese los cuatro números.");
            for (int i = 0; i < numeros.Length; i++){
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                media = media + numeros[i];
            }
            media /= cantidad;
            Console.WriteLine($"Los números en el array son:");
            for (int i = 0; i < numeros.Length; i++){
                Console.Write(numeros[i] + ", ");
            }
            Console.WriteLine($"La media aritmetica es: {media}");
            Console.WriteLine("Fin del Programa #1 \n" + 
            "-------");
        }
        #endregion

        #region SegundoArray
        static void SegundoArray(){
            int cantidad = 5;
            float[] reales = new float[cantidad];
            
            Console.WriteLine("Programa #2 - Bienvenido.");
            Console.WriteLine("Ingrese los cinco números");
            for(int i = 0; i < reales.Length; i++){
                reales[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("El orden normal de los números es el siguiente: ");
            for(int i = 0; i < reales.Length; i++) {
                Console.Write(reales[i] + " ");
            }
            Console.WriteLine("El orden contrario es: ");
            for(int i = reales.Length - 1; i >= 0; i--){
                Console.Write(reales[i] + " ");
            }
            Console.WriteLine("Fin del Programa #2 \n" + 
            "-------");
        }
        #endregion

        #region TercerArray
        static void TercerArray(){
            Console.WriteLine("Programa #3 - Bienvenido.");
            int[] dias = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            Console.WriteLine("Ingrese en base a los números de la lista al mes que desea saber sus días. \n" + 
            "Seleccione un mes. \n" +
            "1-) Enero \n" + 
            "2-) Febrero \n" + 
            "3-) Marzo \n" +
            "4-) Abril \n" + 
            "5-) Mayo \n" + 
            "6-) Junio \n" +
            "7-) Julio \n" + 
            "8-) Agosto \n" + 
            "9-) Septiembre \n" +
            "10-) Octubre \n" + 
            "11-) Noviembre \n" + 
            "12-) Diciembre");
            int mes = Convert.ToInt32(Console.ReadLine());
            if (mes > meses.Length || mes <= 0){
                Console.WriteLine("El mes ingresado no existe, intentelo nuevamente");
                mes = Convert.ToInt32(Console.ReadLine());
            }
            else {
                mes -= 1;
                Console.WriteLine($"El mes que elegiste es {meses[mes]} y tiene {dias[mes]} días");
            }
            Console.WriteLine("Fin del Programa #3 \n" + 
            "-------");
        }
        #endregion

        #region CuartoArray
        static void CuartoArray(){
            int[] nums = new int[10];
            Console.WriteLine("Ingrese los 10 Números");
            for(int i = 0; i < nums.Length; i++){
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Los numeros son: ");
            for(int i = 0; i < nums.Length; i++){
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Calculando...");
            Console.WriteLine("El mayor de todos es: " + nums.Max());
        }
        #endregion

        #region QuintoArray
        static void QuintoArray(){
            string[] names = new string[100];
            string name = "";
            for(int i = 0; i < names.Length; i++){
                Console.WriteLine("Introduzca el nombre");
                name = Console.ReadLine();
                names[i] = name;
                if (name.Length <= 0) {
                    break;
                }
            }
            Console.WriteLine("El programa se ha parado, los nombres introducidos en el array son: ");
            for(int i = 0; i < names.Length; i++){
                Console.Write(names[i] + " ");
            }
        }
        #endregion
    }
}