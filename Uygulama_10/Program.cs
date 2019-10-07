using System;

namespace Uygulama_10
{
    class Program
    {
        private const int ARRAY_SIZE = 40;
        private static int[] intArr;

        public Program()
        {
            intArr = new int[ARRAY_SIZE];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bir diziyi küçükten büyüğe doğru sıralayan uygulama");
            Console.WriteLine("---------------------------------------------------");
            intArr = populate(ARRAY_SIZE);
            Console.WriteLine("Dizinin ilk hali");
            Array.ForEach(intArr, x => Console.Write($"{x}, "));
            Console.WriteLine();
            Console.WriteLine("Dizinin son hali");
            Array.ForEach(sort(intArr), x => Console.Write($"{x}, "));
            Console.ReadKey();
        }

        private static int[] populate(int size)
        {
            int[] paramArr = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                int item = random.Next(0, 999);
                paramArr[i] = item;
            }
            return paramArr;
        }

        private static int[] sort(int[] paramArr)
        {
            
            for (int i = 0; i < paramArr.GetLength(0)-1; i++)
            {
                for (int j = i+1; j < paramArr.GetLength(0); j++)
                {
                    if(paramArr[j] < paramArr[i])
                    {
                        int temporary = paramArr[i];
                        paramArr[i] = paramArr[j];
                        paramArr[j] = temporary;
                    }   
                }
            }
            return paramArr;
        }
    }
}
