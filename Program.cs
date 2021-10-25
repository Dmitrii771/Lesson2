using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double ii = Math.Sqrt(4.0); // Корень числа
            double jj = Math.Pow(4, 3); // Возводим 4 в степень 3



            // инициализация массива
            //int[] A = new int[10];
            int[] A1 = new int[] {1,5,6,4,8,-1,-5,-3};
            //int[] A2 = { 1, 5, 6, 4, 8 };
            //int[] A3 = new int[] { 4 };
            //int[] A4 = new[] { 4 };



            //for(int i = 0; i < A1.Length; i++)
            //{
            //    Console.Write(A1[i]);
            //A1[i] = i;
            //Console.WriteLine(A1[i]);
            // }


            //int l = A1.Length;
            //Console.WriteLine(l);

            // Двумерные массивы
            //int[,] B = new int[5,2];
            //int[,] C = new int[2, 3] { { 3, 6, 5 }, { 7, 8, 6 } };
            //for (int i = 0; i < 5; i++)

            //{
            //    for (int j = 0; j < 2; j++)
            //        Console.Write(B[i,j]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine(B.Length);
            //Console.WriteLine(B.GetLength(0));


            // зубчатые массивы (массив массивов)
            //int[][] V = new int[2][]; 

            //V[0] = new int[] { 1, 2, 3};
            //V[1] = new int[] { 1, 2 };

            //for (int i = 0; i < V.Length; i++)
            //{
            //    for (int j = 0; j < V[i].Length; j++)
            //        Console.Write(V[i][j]);
            //    Console.WriteLine();
            //}

            // Ввод с клавиатуры что нам нужно.
            //int tmp;
            //Console.Write("Enter number: ");
            //while (!Int32.TryParse(Console.ReadLine(), out tmp))
            //{
            //    Console.Write("Enter number: ");
            //}


            // 5 Упражнение
            // TODO: Отсортировать массив без разницы по убыванию или по возрастанию.
            int tmp = A1[0];
            for (int i = 1; i < A1.Length;i++)
                if (A1[i] > tmp)
                {
                    tmp = A1[i];
                    A1[i] = A1[i + 1];
                    A1[i + 1] = tmp;
                }
            foreach (int i in A1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
