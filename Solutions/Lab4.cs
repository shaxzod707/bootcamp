using System;

namespace bootcamp.Solutions
{
    public class Lab4
    {
        public void Problem1()
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            System.Console.WriteLine(num / 10000 + "!" + num / 1000 % 10 + "!" + num / 100 % 10 + "!" + num / 10 % 10 + "!" + num % 10);
        }

        public void Problem2()
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            System.Console.WriteLine((num / 3600).ToString().PadLeft(2, '0') + ":" + (num % 3600 / 60).ToString().PadLeft(2, '0')  + ":" + (num % 60).ToString().PadLeft(2, '0'));
        }

        public void Problem3()
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            System.Console.WriteLine(num / 100 % 10);
        }

        public void Problem4()
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            System.Console.WriteLine((num / 100 % 10 < 5 ? (num / 1000) * 1000 : (num / 1000 + 1) * 1000));
        }

        public void Problem5()
        {
            string str = Console.ReadLine();
            double num = double.Parse(str);
            double PI = 3.14;
            double r = num / (2 * PI);
            double area = PI * r * r;

            int i = (int)Math.Round(area, MidpointRounding.AwayFromZero);

            System.Console.WriteLine(i);
        }

        public void Problem6()
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);

            if(num >= 20 && num <= 30)
            {
                System.Console.WriteLine(1);
            }
            else
            {
                System.Console.WriteLine(0);
            }
        }

        public void Problem7()
        {
            string str = Console.ReadLine();
            char ch = char.Parse(str);
            if((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                System.Console.WriteLine(1);
            }
            else
            {
                System.Console.WriteLine(0);
            }
        }

        public void Problem8()
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            if(num % 2 == 0)
            {
                System.Console.WriteLine("even");
            }
            else
            {
                System.Console.WriteLine("odd");
            }
        }

         public void Problem9()
        {
            string n = Console.ReadLine();
            string m = Console.ReadLine();
            int n1 = int.Parse(n);
            int m1 = int.Parse(m);
            System.Console.WriteLine((n1 > m1 ? n1 : m1));
        }

        public void Problem10()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);

            System.Console.WriteLine((num1 > num2 ? num1 / num2 : num2 / num1));
            System.Console.WriteLine((num1 > num2 ? num1 % num2 : num2 % num1));
            
        }
    }
}