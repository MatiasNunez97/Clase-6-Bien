using System;

namespace Clase_6_Bien
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
              ---------------------------------------------------------------------------------
               int i = 0;
               do
               {
                   Debug.WriteLine(i);
                   if (i == 2){
                       i+=5;

                   }
                   i++;
               } while (i < 1000);
               ----------------------------------------------------------------------------------
              */



            // Sortee 10 numeros y luego muestre en pantalla en pantalla el promedio de los mismos.
            Random ObjetoRandom = new Random();
            int numero = 0;

            for (int i = 0; i < 10; i++) // a la variable i (que empieza en 0), vaya sumandole  1 hasta llegar a 10 (que repita el proceso de abajo 10 veces)
            {
                numero += ObjetoRandom.Next(1000);  // acumulo numeros al azar diez veces y se van sumando
            }
            Console.WriteLine("El promedio de los diez numeros soretados es:  " + (numero / 10));  // los numeros sumados (Resultado final "numero", lo divide por 10 para sacar promedio.
        }
    }
}
