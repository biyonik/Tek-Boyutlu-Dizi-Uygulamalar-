using System;

namespace Uygulama_11
{
    class Program
    {
        private const int ARRAY_SIZE = 20;
        private static int[] intArrOne;
        private static int[] intArrTwo;

        public Program()
        {
            intArrOne = new int[ARRAY_SIZE];
            intArrTwo = new int[ARRAY_SIZE];
        }

        static void Main(string[] args)
        {
            intArrOne = populate(ARRAY_SIZE);
            intArrTwo = populate(ARRAY_SIZE);
            double T1 = 0, T2 = 0, T3 = 0, T4 = 0, T5 = 0, C1 = 1, C2 = 1, F = 0;

            Console.WriteLine("1.Dizi");
            Array.ForEach(intArrOne, x => Console.Write($"{x}, "));
            Console.WriteLine("\n2.Dizi");
            Array.ForEach(intArrTwo, x => Console.Write($"{x}, "));
            Console.WriteLine("\n--------------------------------------");
            for (int i = 0; i < intArrOne.GetLength(0); i++)
            {
                T1 += Math.Pow(intArrOne[i], 2);
                T2 += intArrOne[i] * intArrTwo[i];
                T3 += intArrTwo[i];
                T4 += intArrOne[i];
                T5 += Math.Log(intArrTwo[i]);
                C1 *= Math.Sqrt(intArrTwo[i]);
                C2 *= intArrOne[i];
            }
            F = (T1 + (2 * T2) + Math.Pow(T3, 2) + 3 * C1) / (Math.Sqrt(T4) + intArrOne.GetLength(0) * T5 - C2);
            Console.WriteLine($"T1 = {T1}\nT2 = {T2}\nT3 = {T3}\nT4 = {T4}\nT5 = {T5}\nC1 = {C1}\nC2 = {C2}\nF = {F}");
            Console.ReadKey();
        }

        private static int[] populate(int size)
        {
            int[] paramArr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                int item = rnd.Next(0, 999);
                paramArr[i] = item;
            }
            return paramArr;
        }
    }
}
