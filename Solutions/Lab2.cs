using System;

namespace bootcamp.Solutions
{
    public class Lab2
    {
        public void Problem1()
        {
            Console.WriteLine("222222\n2    2\n2    2\n222222");
        }

        public void Problem2()
        {
            Console.WriteLine("  A\n A A\nAAAAA");
        }

        public void Problem3()
        {
            System.Console.WriteLine("Birthdate");
            System.Console.WriteLine("Enter month");
            string month = Console.ReadLine();
            System.Console.WriteLine("Enter date");
            string date = Console.ReadLine();

            int m1 = int.Parse(month);
            int d1 = int.Parse(date);

            string m = m1.ToString().PadLeft(2, '0');
            string d = m1.ToString().PadLeft(2, '0');

            System.Console.WriteLine("Birthdate is " + m + '-' + d);
        }

        public void Problem4()
        {
            System.Console.WriteLine("Birthdate");
            System.Console.WriteLine("Enter Month and Date: ");
            string month = Console.ReadLine();
            string date = Console.ReadLine();
            int m1 = int.Parse(month);
            int d1 = int.Parse(date);
            string mo1 = m1.ToString().PadLeft(2, '0');
            string da1 = d1.ToString().PadLeft(2, '0');

            System.Console.WriteLine("Birthdate is " + mo1 + "-" + da1);
        }

        public void Problem5()
        {
            string c = Console.ReadLine();
            System.Console.WriteLine(c + c + c + c + c + c);
            System.Console.WriteLine(c + "    " + c);
            System.Console.WriteLine(c + "    " + c);
            System.Console.WriteLine(c + c + c + c + c + c);
        }

        public void Problem6()
        {
            System.Console.WriteLine("Enter integer ");
            string num = Console.ReadLine();
            int n = int.Parse(num);
            for (int i = 1; i <= 9; i++)
            {
                System.Console.WriteLine(n + "*" + i + '=' + n * i);
            }
        }

        public void Problem7()
        {
            for (int i = 1; i <= 5; i++)
            {
                string temp = i.ToString();
                System.Console.Write(temp + '!' + '=');
                int fac = 1;

                for (int j = 1; j <= i; j++)
                {
                    fac *= j;
                }
                string temp2 = fac.ToString();
                System.Console.WriteLine(temp2);
            }
        }

        public void Problem8()
        {
            int f1 = 0, f2 = 1, f3 = f1 + f2;
            System.Console.WriteLine(f1);
            System.Console.WriteLine(f2);
            for (int i = 0; i < 7; i++)
            {
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
                System.Console.WriteLine(f3);
            }
        }

    }
}