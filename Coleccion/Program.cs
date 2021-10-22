using System;
using System.Collections.Generic;

namespace Coleccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();
            foreach(int numero in new int[5] { 5, 4, 3, 6, 9 })
            {
                numeros.Enqueue(numero); 
            }
        }
    }
}
