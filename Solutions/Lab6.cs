using System;

namespace bootcamp.Solutions
{
    public class Lab6
    {
        public void Problem24()
        {
            int a = int.Parse(Console.ReadLine());
            int i = 1;

            for (i = 1; i <= a; i++)
            {
                int star = i;
                while (star-- > 0)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("\n");
            }
        }
        public void Problem23()
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            while (true)
            {
                int num2 = num / 10;
                num = num2;
                count++;
                if (num <= 0)
                {
                    System.Console.WriteLine(count);
                    break;
                }
            }
        }
        int degree(int num)
        {
            int m = 0;
            while (num != 0)
            {
                m++;
                num /= 10;
            }
            return m;
        }
        bool Arm(int x)
        {
            int num = degree(x);
            double sum = 0;
            int i = x;
            while (i != 0)
            {
                int temp = i % 10;
                sum += Math.Pow(temp, num);
                i /= 10;
            }
            if (sum == x)
            {
                return true;
            }
            return false;
        }
        public void Problem22()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                if (Arm(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
        bool palindrom(int num)
        {
            int rev = 0, val;
            val = num;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            if (val == rev)
                return true;
            else
                return false;
        }
        int reverseDigits(int num)
        {
            int rev_num = 0;
            while (num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num /= 10;
            }
            return rev_num;
        }
        public void Problem21()
        {
            int num = int.Parse(Console.ReadLine());
            int step = 0;
            while (palindrom(num) == false)
            {
                num += reverseDigits(num);
                step++;
            }
            Console.WriteLine($"{step} {num}");

        }
        int getNewNum(int num)
        {
            int sumOfDig = 0;
            int origNum = num;
            while (num != 0)
            {
                sumOfDig += num % 10;
                num /= 10;
            }
            int newNum = origNum % 10 * 10 + sumOfDig % 10;
            return newNum;
        }
        public void Problem20()
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int newNum, numCpy = num; true; numCpy = newNum)
            {
                newNum = getNewNum(numCpy);
                count++;
                if (num == newNum)
                {
                    System.Console.WriteLine(count);
                    break;
                }
            }
        }
        public void Problem19()
        {
            int num = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = a + b;


            if (num == 1)
            {
                System.Console.WriteLine(a);
            }
            else if (num == 2)
            {
                System.Console.WriteLine(b);
            }
            else if (num > 2)
            {
                for (int i = 2; i < num; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                System.Console.WriteLine(c);
            }
        }
        int collatz(long n)
        {
            int count = 0;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                count++;
            }
            return count;
        }
        public void Problem18()
        {
            long x = long.Parse(Console.ReadLine()), y = long.Parse(Console.ReadLine());

            if (collatz(x) > collatz(y))
            {
                Console.WriteLine($"{y} {collatz(y)}");
            }
            else
            {
                Console.WriteLine($"{x} {(collatz(x))}");
            }

        }
        public void Problem17()
        {
            int num = int.Parse(Console.ReadLine());
            int x = 0, y = 0, yunalish = 0;
            while (num-- > 0)
            {
                int k = int.Parse(Console.ReadLine());
                switch (yunalish % 4)
                {
                    case 0: y += k; break;
                    case 1: x += k; break;
                    case 2: y -= k; break;
                    case 3: x -= k; break;
                    default: break;
                }
                yunalish++;
            }
            Console.WriteLine($"{x} {y}");

        }
        bool isPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void Problem16()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = num; ; i++)
            {
                if (isPrime(i) == true)
                {
                    System.Console.WriteLine(i);
                    break;
                }
            }
        }
        public void Problem15()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i != 0; i++)
            {
                if (num % i == 0)
                {
                    num /= i;
                }
                else
                {
                    break;
                }
            }
            if (num == 1)
            {
                System.Console.WriteLine("true");
            }
            else
            {
                System.Console.WriteLine("false");
            }
        }
        public void Problem14()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n * n * n;
            }
            System.Console.WriteLine(sum);
        }
        public void Problem13()
        {
            int sum = 0;
            int count = 0;
            while (true)
            {


                int num = int.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    break;
                }
                sum += num;
                count++;
            }
            float aver = (float)sum / count;
            Console.WriteLine($"{sum} {aver} {count}");

        }
        public void Problem12()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i != 0; i++)
            {
                if (i > num)
                {
                    break;

                }
                sum += i;
            }
            System.Console.WriteLine(sum);
        }
        public void Problem11()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    for (int k = 1; k <= 6; k++)
                    {
                        if ((i + j + k) == 10)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
        public void Problem10()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                sum = 0;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum < 10)
                {
                    System.Console.WriteLine(sum);
                    break;
                }
                num = sum;
            }
        }
        public void Problem9()
        {
            int num = int.Parse(Console.ReadLine());
            int n = 1;
            for (int i = 1; i <= num; i++)
            {
                int space = num - i;
                while (space-- > 0)
                {
                    System.Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write((n++ % 10) + " ");
                }
                System.Console.WriteLine();
            }
        }
        public void Problem8()
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                int temp = i;
                while (temp != 0)
                {
                    if (temp % 10 == 3)
                    {
                        count++;
                    }
                    temp /= 10;
                }
            }
            System.Console.WriteLine(count);
        }
        public void Problem7()
        {
            for (int i = 1; i <= 10; i++)
            {
                int num = i;
                for (int j = 1; j <= 10; j++)
                {
                    System.Console.Write((num++ % 10) + " ");
                }
                System.Console.WriteLine();
            }
        }
        public void Problem6()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int space = num - i;
                while (space-- > 0)
                {
                    System.Console.Write(" ");
                }
                int stars = i * 2 - 1;
                while (stars-- > 0)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }

            for (int i = num - 1; i > 0; i--)
            {
                int space = num - i;
                while (space-- > 0)
                {
                    System.Console.Write(" ");
                }
                int stars = i * 2 - 1;
                while (stars-- > 0)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        public void Problem5()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());


            for (int i = n1 | n2; i > 0; i--)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    System.Console.WriteLine(i);
                    break;
                }
            }
        }
        public void Problem4()
        {
            for (int i = 2; i <= 10; i++)
            {
                System.Console.Write(i + "!=");
                for (int j = 1; j < i; j++)
                {
                    System.Console.Write(j + "*");
                }
                System.Console.Write(i);
                int factorial = 1;
                for (int k = 1; k <= i; k++)
                {
                    factorial *= k;
                }
                System.Console.WriteLine("=" + factorial);
            }
        }
        public void Problem3()
        {
            int sum = 0;
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
                sum += num;
            }
            System.Console.WriteLine(sum);
        }
        public void Problem2()
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            while (true)
            {
                int guess = int.Parse(Console.ReadLine());
                count++;
                if (guess > num)
                {
                    System.Console.WriteLine(guess + ">");
                }
                else if (guess < num)
                {
                    System.Console.WriteLine(guess + "<");
                }
                else if (guess == num)
                {
                    System.Console.WriteLine(count);
                    break;
                }
            }
        }
        public void Problem1()
        {
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            int temp = num;
            while (num-- > 0)
            {
                if (temp % i == 0)
                {
                    System.Console.Write(i + " ");
                }
                i++;
            }
        }
    }
}