using System;

namespace bootcamp.Solutions
{
    public class Lab7
    {
        public void Problem1()
        {
            int[] arr = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                sum += arr[i];
            }

            float aver = (float)sum / 5;

            for (int i = 0; i < 5; i++)
            {
                if (arr[i] > aver)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            System.Console.WriteLine();

        }

        public void Problem2()
        {
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    var temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        void printSt(int num, int count)
        {
            Console.Write($"{num}:");
            while (count-- > 0)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

        public void Problem3()
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int one = 0, twice = 0, third = 0;
            for (int i = 0; i < 10; i++)
            {
                switch (arr[i])
                {
                    case 1: one++; break;
                    case 2: twice++; break;
                    case 3: third++; break;
                }
            }
            printSt(1, one);
            printSt(2, twice);
            printSt(3, third);
        }

        public void Problem4()
        {
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max1, max2;
            max1 = arr[0] > arr[1] ? arr[0] : arr[1];
            max2 = arr[0] < arr[1] ? arr[0] : arr[1];

            for (int i = 2; i < 5; i++)
            {
                max2 = arr[i] > max2 ? arr[i] : max2;
                max2 = arr[i] > max1 ? max1 : max2;
                max1 = arr[i] > max1 ? arr[i] : max1;
            }
            Console.WriteLine($"{max1} {max2}");
        }

        public void Problem5()
        {
            char[] arr = new char[7];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < 7; i++)
            {
                if (arr[i] == 'c' && arr[i + 1] == 'a' && arr[i + 2] == 't')
                {
                    count++;
                }
            }
            Console.WriteLine($"{count}");

        }
    }
}