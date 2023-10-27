using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamenUnidad2_JDPC
{
    internal class Back
    {

        public void Ejercicio1()
        {
           
            int[,] matriz = new int [4,5];
            
            for (int i = 1; i < matriz.GetLength(0); i++)
            {
              //  Console.WriteLine("Ingrese cuanto vendio el vendedor "[i]);
                for (int j = 1; j< matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Ingrese cuanto vendio el vendedor "+i+ " En el producto " +j);
                    matriz[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }


        }

        public void Ejercicio3()
        {
            Random rnd = new Random();
            int[] matriz= new int[100];
            Console.WriteLine("100 numeros al azar Desordenados");
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = rnd.Next(100); 
            }
            for (int i = 0;i < matriz.Length; i++)
            {
                Console.WriteLine(matriz[i]);
            }
            int auxiliar = 0;
            for (int i = 0; i<matriz.Length-1; i++)
            {
                for (int j = 0; j < matriz.Length - 1; j++)
                {
                    if (matriz[j+1] > matriz[j])
                    {
                        auxiliar = matriz[j+1];
                        matriz[j+1] = matriz[j];
                        matriz[j]= auxiliar;
                    }
                } 
            }
            Console.WriteLine("100 numeros al azar ordenados Descendente");

            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine(matriz[i]);
            }
            int auxiliar2 = 0;
            for (int i = 0; i < matriz.Length - 1; i++)
            {
                for (int j = 0; j < matriz.Length - 1; j++)
                {
                    if (matriz[j] > matriz[j+1])
                    {
                        auxiliar2 = matriz[j];
                        matriz[j] = matriz[j+1];
                        matriz[j+1] = auxiliar2;
                    }
                }
            }
            Console.WriteLine("100 numeros al azar ordenados Ascendente");
            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine(matriz[i]);
            }
            int media= 0;
            int inicio = 0;
            int final = matriz.Length;
            bool centinela = false;
            while (inicio<=final)
            {
                media=(inicio+final)/2;

                if (matriz[media]==75)
                {
                   
                    Console.WriteLine("El numero 75 se encuentra en la posicion " + media);
                    centinela = true;
                }
                if (matriz[media]>75)
                {
                    final = media-1;
                }
                else
                {
                    inicio=media+1;
                }
            }
            if (centinela==false)
                Console.WriteLine("El numero 75 no se encontro");
        }
    }
}
