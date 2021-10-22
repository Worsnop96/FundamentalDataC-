using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] database = LeerDatos();
            foreach (int i in database)  Console.WriteLine(i);

        }


        static int[] LeerDatos()
        {
            Console.WriteLine("how many elements do you want ?");
            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);
            int[] datos = new int[numElementos];

            for (int i= 0; i < numElementos; i++)
            {
                Console.WriteLine($"introduce el dato para la posicion {i}");
                respuesta = Console.ReadLine();
                int datosElemento = int.Parse(respuesta);
                datos[i] = datosElemento;
            }
            return datos;
        }
        
        
    }


}
