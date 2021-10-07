using System;

namespace bootcamp.Solutions
{
    public class Lab5
    {
        public void Problem1()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Ichkarida o'yna");
            }
            if (0 <= n && n < 40)
            {
                System.Console.WriteLine("Tashqarida o'yna");
            }
            else
            {
                Console.WriteLine("Ichkarida o'yna");
            }
        }
        public void Problem2()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m == n * n)
            {
                System.Console.WriteLine(n + "*" + n + "=" + m);
            }
            if (n == m * m)
            {
                System.Console.WriteLine(m + "*" + m + "=" + n);
            }
            else
            {
                System.Console.WriteLine("none");
            }
        }
        public void Problem3()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (n > m)
            {
                System.Console.WriteLine(n);
            }
            else
            {
                System.Console.WriteLine(m);
            }
        }
        public void Problem4()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int max = n;
            int min = n;
            if (m > max)
                max = m;
            if (a > max)
                max = a;
            if (m < min)
                min = m;
            if (a < min)
                min = a;
            System.Console.WriteLine(max + " " + min);
        }
        public void Problem5()
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0 && a % 3 == 0 && a % 5 == 0)

                System.Console.WriteLine("A");

            else if (a % 2 == 0 && a % 3 == 0)

                System.Console.WriteLine('B');

            else if (a % 2 == 0 && a % 5 == 0)

                System.Console.WriteLine('C');

            else if (a % 3 == 0 && a % 5 == 0)

                System.Console.WriteLine('D');

            else if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0)

                System.Console.WriteLine("E");

            else

                System.Console.WriteLine('N');
        }
        public void Problem6()
        {
            int x = int.Parse(Console.ReadLine());
            if ((x % 4 == 0 && x % 100 != 0) || (x % 400 == 0))
                System.Console.WriteLine("Leap year");
            else
                System.Console.WriteLine("Normal year");
        }

        public void Problem7()
        {
            int a = int.Parse(Console.ReadLine());
            int v = 5;
            if (a == v)
            {

                System.Console.WriteLine("Correct");

            }
            else
            {
                if (a > v)
                {
                    System.Console.WriteLine("Down");
                }

                else
                {
                    System.Console.WriteLine("Up");

                    int c = int.Parse(Console.ReadLine());

                    if (c == v)

                        System.Console.WriteLine("Correct");

                    else
                    {
                        if (c > v)
                        {
                            System.Console.WriteLine("Down");
                        }

                        else
                        {

                            System.Console.WriteLine("Up");

                        }
                    }
                }
            }
        }

        public void Problem8()
        {
            char a = char.Parse(Console.ReadLine());

            if (a >= 65 && a <= 90)
            {
                Console.WriteLine(char.ToLower(a));
            }
            else if (a >= 97 && a <= 122)
            {
                Console.WriteLine(char.ToUpper(a));
            }
            else
            {
                System.Console.WriteLine("none");
            }
        }

        public void Problem9()
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());

            int strike = 0, ball = 0;

            if (a2 == a1)
            {
                strike++;
            }

            else if (a2 == b1 || a2 == c1)
            {
                ball++;
            }

            if (b2 == b1)
            {
                strike++;
            }

            else if (b2 == a1 || b2 == c1)
            {
                ball++;
            }

            if (c2 == c1)
            {
                strike++;
            }

            else if (c2 == a1 || c2 == b1)
            {
                ball++;
            }

            System.Console.WriteLine(strike + "S" + ball + "B");

        }

        public void Problem10()
        {
            int a = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            switch (op)
            {
                case '+':
                    System.Console.WriteLine(a + b); break;
                case '-':
                    System.Console.WriteLine(a - b); break;
            }

        }

        public void Problem11()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());


            switch (N)
            {
                case 1:
                    {
                        System.Console.WriteLine("Americano");
                        int narh = M - 500;
                        System.Console.WriteLine(narh / 500 + " " + narh / 500 % 100);
                        break;
                    }

                case 2:
                    {
                        System.Console.WriteLine("Caffe Latte");
                        int narh = M - 400;
                        System.Console.WriteLine(narh / 500 + " " + narh % 500 / 100);
                        break;
                    }
                case 3:
                    {
                        System.Console.WriteLine("Lemon Tea ");
                        int narh = M - 300;
                        System.Console.WriteLine(narh / 500 + " " + narh % 500 / 100);
                        break;
                    }

            }
        }

        public void Problem12()
        {
            int N = int.Parse(Console.ReadLine());

            switch (N)
            {
                case 1: Problem1(); break;
                case 2: Problem2(); break;
                case 3: Problem3(); break;
                case 4: Problem4(); break;
                case 5: Problem5(); break;
                case 6: Problem6(); break;
                case 7: Problem7(); break;
                case 8: Problem8(); break;
                case 9: Problem9(); break;
                case 10: Problem10(); break;
                case 11: Problem11(); break;
            }

        }

        public void Problem13()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a + b > 100)
            {
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }
        }

        public void Problem14()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            if (a * a + b * b == c * c)
            {
                System.Console.WriteLine("true");
            }

            else if (a * a + c * c == b * b)
            {
                System.Console.WriteLine("true");
            }

            else if (b * b + c * c == a * a)
            {
                System.Console.WriteLine("true");
            }
            else
            {
                System.Console.WriteLine("false");
            }
        }

        public void Problem15()
        {
            char a = char.Parse(Console.ReadLine());

            switch (a)
            {
                case '+':
                    System.Console.WriteLine("true"); break;

                case '-':
                    System.Console.WriteLine("true"); break;

                case '*':
                    System.Console.WriteLine("true"); break;

                case '/':
                    System.Console.WriteLine("true"); break;

                case '%':
                    System.Console.WriteLine("true"); break;

                default:
                    System.Console.WriteLine("false"); break;
            }
        }

        public void Problem16()
        {
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 0: System.Console.WriteLine("nol"); break;
                case 1: System.Console.WriteLine("bir"); break;
                case 2: System.Console.WriteLine("ikki"); break;
                case 3: System.Console.WriteLine("uch"); break;
                case 4: System.Console.WriteLine("turt"); break;
                case 5: System.Console.WriteLine("besh"); break;
                case 6: System.Console.WriteLine("olti"); break;
                case 7: System.Console.WriteLine("yetti"); break;
                case 8: System.Console.WriteLine("sakkiz"); break;
                case 9: System.Console.WriteLine("tuqqiz"); break;
                default: System.Console.WriteLine("boshqa"); break;

            }
        }

        public void Problem17()
        {
            int s = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());



            if (s == 0)
            {
                s = 24;
            }

            n = s * 60 + m - 45;

            System.Console.WriteLine(n / 60 + " " + n % 60);
        }

        public void Problem18()
        {
            int a = int.Parse(Console.ReadLine());

            if (a >= 90 && a <= 100)
            {
                System.Console.WriteLine("A");
            }
            else if (a >= 80 && a <= 89)
            {
                System.Console.WriteLine("B");
            }

            else if (a >= 70 && a <= 79)
            {
                System.Console.WriteLine("C");
            }
            else if (a >= 60 && a <= 69)
            {
                System.Console.WriteLine("D");
            }

            else
            {
                System.Console.WriteLine("F");
            }
        }

        public void Problem19()
        {
            int N = int.Parse(Console.ReadLine());

            int son = N / 100 % 10 < 5 ? N / 1000 * 1000 : (N / 1000 + 1) * 1000;

            System.Console.WriteLine(son);
        }

        public void Problem20()
        {
            char a = char.Parse(Console.ReadLine());

            if (a >= 65 && a <= 90 || a >= 97 && a <= 122)
            {
                System.Console.WriteLine("1");
            }
            else
            {
                System.Console.WriteLine("0");
            }
        }

        public void Problem21()
        {
            int b = int.Parse(Console.ReadLine());

            if (b % 2 == 0)
            {
                System.Console.WriteLine("even");
            }
            else
            {
                System.Console.WriteLine("odd");
            }
        }

    }
}