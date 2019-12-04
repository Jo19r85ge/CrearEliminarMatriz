using System;

namespace Ejercicio2_Matriz
{
    class Program
    {
        class Crear
        {
            public static int[,] Matriz(int filas, int columnas)
            {
                var myMatriz = new int[filas, columnas];

                for (var i = 0; i < myMatriz.GetLength(0); i++)
                {
                    for (var j = 0; j < myMatriz.GetLength(1); j++)
                    {
                        myMatriz[i, j] = 1;
                        Console.Write(" || {0} || ", myMatriz[i, j]);
                    }
                    Console.WriteLine();
                }

                return myMatriz;
            }
        }

        class Eliminar
        {
            public static int[,] Posicion(int fila, int columna, int[,] myMatriz)
            {
                myMatriz[fila - 0, columna - 0] = 0;

                for (var i = 0; i < myMatriz.GetLength(0); i++)
                {
                    for (var j = 0; j < myMatriz.GetLength(1); j++)
                    {
                        Console.Write(" || {0} || ", myMatriz[i, j]);
                    }
                    Console.WriteLine();
                }

                return myMatriz;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a crear la matriz");

            Console.Write("Numero de filas: ");
            var filas = Int32.Parse(Console.ReadLine());

            Console.Write("Numero de columnas: ");
            var columnas = Int32.Parse(Console.ReadLine());

            var crearMatriz = Crear.Matriz(filas, columnas);

            Console.Write("Que fila quieres eliminar un valor: ");
            var filaIndice = Int32.Parse(Console.ReadLine());

            Console.Write("Que columna quieres eliminar un valor: ");
            var columnaIndice = Int32.Parse(Console.ReadLine());

            Eliminar.Posicion(filaIndice, columnaIndice, crearMatriz);
        }
    }
}



   