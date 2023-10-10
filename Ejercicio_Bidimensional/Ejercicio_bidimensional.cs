using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Bidimensional
{
    internal class Ejercicio_bidimensional
    {
        int[] arreglo1 = new int[15];

        public void Arreglo()
        {
            //Llenamos el arreglo con multiplos de 5
            for(int i = 0; i < arreglo1.Length; i++)
            {
                arreglo1[i] = (i + 1) * 5;
            }

            int[] arreglo2 = new int[20];

            //Iniciamos cada elemento del arreglo 2 de forma de secuencia de los elementos 
            for(int i = 0; i < arreglo2.Length; i++)
            {
                arreglo2[i] = i;
            }
            //Copiamos los últimos 10 elementos del arreglo 1 en los últimos 10 elementos del arreglo 2
            Array.Copy(arreglo1, arreglo1.Length - 10, arreglo2, arreglo2.Length - 10, 10);

            //Mostramos el arreglo 1
            Console.WriteLine("Arreglo 1");
            foreach(int elemento in arreglo1 )
            {
                Console.Write(elemento + " ");
            }

            Console.WriteLine();
              //Mostramos el arreglo 2
             
            Console.WriteLine("Arreglo 2");
            foreach (int elemento in arreglo2 )
            {
                Console.Write(elemento + " ");
            }

            

        }
    }
}
