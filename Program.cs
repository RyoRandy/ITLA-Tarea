using System;
using System.Linq;

namespace ITLA_Tarea
{
    class Program
    {
        #region Programas
        static void Main(string[] args)
        {
            /*PrimerArray();
            SegundoArray();
            TercerArray();
            CuartoArray();*/
            //QuintoArray();
            //SextoArray();
            //SeptimoArray();
            //OctavoArray();
            //NovenoArray();
            //DecimoArray();
            Console.WriteLine("Presiona cualquier tecla del teclado");
            /*var key = Console.ReadKey();
            Console.WriteLine($"{key.Key}");
            Console.WriteLine($"{key.KeyChar}");
            Console.WriteLine($"{key.Modifiers}");*/

            /*bool a = true;
            if(!a){
                Console.WriteLine($"True, this is the value of a: {a}");
            } else{
                
                Console.WriteLine($"False, this is the value of a: {a}");
            }*/

            Image obj = new Image();
            obj.Add(new Image("reymer.png", 1024, 768));
            obj.List();
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

        #region Poo
        public class Image
        {
            #region Constructors
            public Image()
            {
                this.Item = new Image[700];
            }
            public Image (string name, int pixelHeight, int pixelWidth)
            {
                this.ObjectId = Guid.NewGuid();
                this.Name = name;
                this.PixelHeight = pixelHeight;
                this.PixelWidth = pixelWidth;
                this.QuantityLimit = 0;
                this.Size = new Random().Next(700);
                this.Item = new Image[700];
            }
            #endregion
            #region Attributes
            public Guid ObjectId {get; private set;}
            public string Name {get; set;}
            public int PixelHeight {get; set;}
            public int PixelWidth {get; set;}
            public float Size {get; private set;}
            public int QuantityLimit {get; private set;}
            private Image[] Item {get; set;}

            #endregion
            #region Methods
            private bool CapacityExcedeed()
            {
                if(this.QuantityLimit == 700)
                {
                    this.Write("You've excedeed the limit.");
                    return true;
                } 
                return false;
            }
            private void Write(string text)
            {
                Console.WriteLine(text);
            }
            public void Add(Image file)
            {
                if(!this.CapacityExcedeed())
                {
                    for(int i = 0; i < Item.Length; i++)
                    {
                        this.Item[i] = file;
                        this.QuantityLimit++;
                    }
                }
            }
            public void List()
            {
                for(int i = 0; i < Item.Length; i++)
                {
                    Write($"Item: {i}, ObjectId: {Item[i].ObjectId.ToString()}, Name: {Item[i].Name}, Size: {Item[i].Size}kB, Pixel Height: {Item[i].PixelHeight}, Pixel Width: {Item[i].PixelWidth}");
                }
            }
            #endregion

        }
        #endregion

    }
}