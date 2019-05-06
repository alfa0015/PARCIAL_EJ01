using System;


namespace PARCIAL3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] ej1;
            ej1 = new int[2, 10];
            int counti = 0;
            int countd = 9;
            int[] resultado = new int[10];
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    int value = rnd.Next(1, 100);
                    ej1[f, c] = value;
                }
            }
            for (int c = 0; c < 10; c++)
            {
                Console.WriteLine($"Matriz original: {ej1[0, c]}, {ej1[1, c]}");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Multiplicacion: {ej1[0, counti]}, {ej1[1, countd]}");
                resultado[i] = ej1[0, counti] * ej1[1, countd];
                counti++;
                countd--;
            }
            Console.WriteLine("\n");
            foreach (int result in resultado)
            {
                Console.WriteLine($"El Resultado es: {result}");
            }
        }
    }
}
