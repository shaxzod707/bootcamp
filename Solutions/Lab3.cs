using System;

namespace bootcamp.Solutions
{
    public class Lab3
    {
        public void Problem1()
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);
            char ch = (char)n;

            System.Console.WriteLine(ch);
        }

        public void Problem2()
        {
            System.Console.WriteLine("Width: ");
            string n1 = Console.ReadLine();
            System.Console.WriteLine("Length: ");
            string n2 = Console.ReadLine();
            System.Console.WriteLine("Area is: ");

            float n = float.Parse(n1);
            float m = float.Parse(n2);

            System.Console.WriteLine(n * m);
        }

        public void Problem3()
        {
            string str = Console.ReadLine();
            double d = double.Parse(str);

            int i = (int)Math.Round(d, MidpointRounding.AwayFromZero);
            Console.WriteLine("Original Value = {0}", d);
            Console.WriteLine("Rounded Value = {0}", i);  
        }

        public void Problem4()
        {
            System.Console.Write("Input lower case: ");
            string str = Console.ReadLine();
            char ch = char.Parse(str);

            System.Console.WriteLine("Output upper case : {0}", (char)(ch - 32));

        }

        public void Problem5()
        {
            System.Console.Write("Input upper case: ");
            string str = Console.ReadLine();
            char ch = char.Parse(str);

            System.Console.WriteLine("Output lower case : {0}", (char)(ch + 32));
        }
    }
}