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
            //QuintoArray();
            //SextoArray();
            //SeptimoArray();
            //OctavoArray();
            //NovenoArray();
            //DecimoArray();
            //Participacion();
            
            //Persona persona1 = new Persona;
            //persona1.imprimir();
            //persona1.EsMayorEdad();
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
    
        #region SextoArray
        #endregion

        #region SeptimoArray
        static void SeptimoArray(){
            Console.WriteLine("Bienvenido, por favor ingrese su nombre.");
            string nombre = Console.ReadLine();
            for(int i = 0; i < nombre.Length; i++){
                Console.Write(nombre[i] + " ");
            }
        }
        #endregion
    
        #region OctavoArray
        #endregion

        #region NovenoArray
        #endregion

        #region DecimoArray
        private string nombre;
        private int edad;

        public void Persona() {
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());
        }
        public void Datos(){
            Console.WriteLine($"Nombre: {nombre}, Edad:{edad}");
        }
        public void EsMayorEdad(){
            if (edad >= 18){
                Console.WriteLine($"{nombre}: Es Mayor de edad");
            }
            else{
                Console.WriteLine($"{nombre}: No es Mayor de edad");
            }
        } 
        #endregion 

        #region Participacion
        /*static void Participacion(){
            //Crear un programa que simule un banco que tiene 3 clientes que pueden hacer depósitos y retiros. También el banco requiere que al final del día calcule la cantidad de dinero que hay depositado.

            int[] numCuenta;
            int confirmacion = 0;
            int cliente = 0;
            int[] clientes =  new int[3];
            for(int i = 0; i < clientes.Length; i++){
                cliente += 1;
                Console.WriteLine($"Bienvenido Cliente #{cliente}, ¿Qué desea hacer? \n" + 
                "1-) Depositar. \n" +
                "2-) Retirar. \n");
                clientes[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (clientes[1] == 1 || clientes[2] == 1 || clientes[3] == 1){
                int[] opcion = new int[3];

                for (int i = 0; i < opcion.Length; i++){
                    Console.WriteLine($"Cliente #{cliente}¿A quién desea depositar? \n" +
                    "1-) Cuenta Propia \n" +
                    "2-) Otro..");
                    opcion[i] = Convert.ToInt32(Console.ReadLine());
                }
                
                if (opcion[1] == 1 || opcion[2] == 1 || opcion[3] == 1) {
                    for(int i = 0; i < clientes.Length; i++){
                        Console.WriteLine("Inserte el número de cuenta");
                        numCuenta[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    if (numCuenta[1] > 999999999 || numCuenta[2] > 999999999 || numCuenta[3] > 999999999){
                        do {
                            Console.WriteLine("El número de cuenta no existe. Por favor intentelo nuevamente.");
                            numCuenta[] = Convert.ToInt32(Console.ReadLine());
                        }
                        while (numCuenta[1] != 999999999 && numCuenta[2] != 999999999 && numCuenta[3] != 999999999);
                    }

                    Console.WriteLine($"El número de cuenta es: {numCuenta}");
                    Console.WriteLine("¿Monto a depositar?");
                    int monto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"El monto a depositar es: {monto}");
                    Console.WriteLine("\n");
                    Console.WriteLine("¿Está seguro de llevar está acción a cabo? \n" +
                    "1-) Si. \n" +
                    "2-) No.");
                    confirmacion = Convert.ToInt32(Console.ReadLine());
                        if (confirmacion == 1){
                            Console.WriteLine($"Depositando {monto} Pesos Dominicanos al número de cuenta {numCuenta}.");
                        }
                        else if (confirmacion == 2){
                            Console.WriteLine("Cancelando proceso. \n" +
                            "Gracias por utilizar nuestro servicio, vuelva pronto."); 
                        }
                        else {
                            Console.WriteLine("Error.");
                        }
                }
                else if (opcion[1] == 2 || opcion[2] == 2 || opcion[3] == 2){
                    Console.WriteLine("Inserte el número de cuenta");
                    int numCuenta = Convert.ToInt32(Console.ReadLine());
                    if (numCuenta > 999999999){
                        do {
                            Console.WriteLine("El número de cuenta no existe. Por favor intentelo nuevamente.");
                            numCuenta = Convert.ToInt32(Console.ReadLine());
                        }
                        while (numCuenta > 999999999);
                    }

                    Console.WriteLine($"El número de cuenta es: {numCuenta}");
                    Console.WriteLine("¿Monto a depositar?");
                    int monto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"El monto a depositar es: {monto}");
                    Console.WriteLine("\n");
                    Console.WriteLine("¿Está seguro de llevar está acción a cabo? \n" +
                    "1-) Si. \n" +
                    "2-) No.");
                    confirmacion = Convert.ToInt32(Console.ReadLine());
                        if (confirmacion == 1){
                            Console.WriteLine($"Depositando {monto} Pesos Dominicanos al número de cuenta {numCuenta}.");
                        }
                        else if (confirmacion == 2){
                            Console.WriteLine("Cancelando proceso. \n" +
                            "Gracias por utilizar nuestro servicio, vuelva pronto."); 
                        }
                        else {
                            Console.WriteLine("Error.");
                        }
                }
            }
            else if(clientes[1] == 2 || clientes[2] == 2 || clientes[3] == 2){
                Console.WriteLine("¿Cuánto desea retirar?");
                int retiro = Convert.ToInt32(Console.ReadLine());

                if (retiro <= 250000){
                    Console.WriteLine($"La cantidad a retirar es de {retiro} \n" +
                    "------ \n" +
                    "¿Seguro que quiere retirar está cantidad? \n" +
                    "1-) Si \n" + 
                    "2-) No.");

                    int respuestaRetiro = Convert.ToInt32(Console.ReadLine());
                    if (respuestaRetiro == 1){
                        Console.WriteLine($"Retirando {retiro} Pesos.");
                    }
                    else if (respuestaRetiro == 2){
                        Console.WriteLine($"El retiro ha sido anulado, Gracias por utilizar nuestro servicio.");
                    }
                    else {
                        Console.WriteLine("Error.");
                    }
                }
                else {
                    Console.WriteLine("Error.");
                }
            }
        } */
        #endregion   
    }
}