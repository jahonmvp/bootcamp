using System;

namespace bootcamp.Solutions
{
    public class Lab5
    {
        public void Problem5_20()
        {
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                System.Console.WriteLine("even");
            }
            else
            {
                System.Console.WriteLine("odd");
            }
        }
        public void Problem5_19()
        {
            char ch = char.Parse(Console.ReadLine());
            if(ch >= 'a' && ch <= 'z')
            {
                System.Console.WriteLine(1);
            }
            else if(ch >= 'A' && ch <= 'Z')
            {
                System.Console.WriteLine(1);
            }
            else
            {
                System.Console.WriteLine(0);
            }
        }
        public void Problem5_18()
        {
            int num = int.Parse(Console.ReadLine());

            System.Console.WriteLine((num / 100 % 10 < 5 ? (num / 1000) * 1000 : (num / 1000 + 1) * 1000));
        }
        public void Problem5_17()
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            if(hours <= 0 && min - 45 < 0)
            {
                hours = 24 - 1;
                min = min + 60 - 45;
            }
            else if(min - 45 < 0)
            {
                hours -= 1;
                min = min + 60 - 45;
            }
            Console.WriteLine($"{hours} {min}");
            
        }
        public void Problem5_16()
        {
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 0: System.Console.WriteLine("nol"); break;
                case 1: System.Console.WriteLine("bir"); break;
                case 2: System.Console.WriteLine("ikki"); break;
                case 3: System.Console.WriteLine("uch"); break;
                case 4: System.Console.WriteLine("to'rt"); break;
                case 5: System.Console.WriteLine("besh"); break;
                case 6: System.Console.WriteLine("olti"); break;
                case 7: System.Console.WriteLine("yetti"); break;
                case 8: System.Console.WriteLine("sakkiz"); break;
                case 9: System.Console.WriteLine("to'qqiz"); break;
                default: System.Console.WriteLine("boshqa"); break;
            }
        }
        public void Problem5_15()
        {
            char ch = char.Parse(Console.ReadLine());
            switch(ch)
            {
                case '+': System.Console.WriteLine(true); break;
                case '-': System.Console.WriteLine(true); break;
                case '*': System.Console.WriteLine(true); break;
                case '/': System.Console.WriteLine(true); break;
                case '%': System.Console.WriteLine(true); break;
                default: System.Console.WriteLine(false); break;
            }
        }
        public void Problem5_14()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if((a * a) + (b * b) == (c * c))
            {
                System.Console.WriteLine(true);
            }
            else if((a * a) + (c * c) == (b * b))
            {
                System.Console.WriteLine(true);
            }
            else if((b * b) + (c * c) == (a * a))
            {
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }
        }
        public void Problem5_13()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if(n1 + n2 > 100)
            {
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }
        }
        public void Problem5_12()
        {
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1: Problem5_4(); break;
                case 2: Problem5_9(); break;
                case 3: Problem5_10(); break;
                default: break;
            }
        }
        public void Problem5_11()
        {
            int drink = int.Parse(Console.ReadLine());
            int pay = int.Parse(Console.ReadLine());

            switch(drink)
            {
                case 1: System.Console.WriteLine("Americano" + "\n" + (pay - 500) / 500 + " " + pay % 500 / 100); break;
                case 2: System.Console.WriteLine("Caffe Latte" + "\n" + (pay - 400) / 500 + " " + (pay - 400) % 500 / 100); break;
                case 3: System.Console.WriteLine("Lemon Tea" + "\n" + (pay - 300) / 500 + " " + (pay - 300) % 500 / 100); break;
                default: break;
            }
        }
        public void Problem5_10()
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if(ch == '-')
            {
                System.Console.WriteLine(n1 - n2);
            }
            else if(ch == '+')
            {
                System.Console.WriteLine(n1 + n2);
            }
        }
        public void Problem5_9()
        {
            int g1 = int.Parse(Console.ReadLine()), g2 = int.Parse(Console.ReadLine()), g3 = int.Parse(Console.ReadLine());

            int s1 = int.Parse(Console.ReadLine()), s2 = int.Parse(Console.ReadLine()), s3 = int.Parse(Console.ReadLine());
            int strike = 0, ball = 0;

            if(s1 == g1)
            {
                strike ++;
            }
            else if(s1 == g2 || s1 ==g3)
            {
                ball ++;
            }
            if(s2 == g2)
            {
                strike ++;
            }
            else if(s2 == g1 || s2 == g3)
            {
                ball ++;
            }
            if(s3 == g3)
            {
                strike ++;
            }
            else if(s3 == g1 || s3 == g2)
            {
                ball ++;
            }
            System.Console.WriteLine(strike + "S" + ball + "B");
        }
        public void Problem5_8()
        {
            char ch = char.Parse(Console.ReadLine());
            if(ch >= 'a' && ch <= 'z')
            {
                System.Console.WriteLine((char)(ch - 32));
            }
            else if(ch >= 'A' && ch <= 'Z')
            {
                System.Console.WriteLine((char)(ch + 32));
            }
            else
            {
                System.Console.WriteLine("none");
            }
        }
        public void Problem5_7()
        {
            int num = int.Parse(Console.ReadLine());
            
            int guess = int.Parse(Console.ReadLine());

            if(guess > num)
            {
                System.Console.WriteLine("DOWN");
                int temp = int.Parse(Console.ReadLine());
                if(temp > num)
                {
                    System.Console.WriteLine("DOWN");
                }
                else if(temp < num)
                {
                    System.Console.WriteLine("UP");
                }
                else 
                {
                    System.Console.WriteLine("Correct");
                }
            }
            else if(guess < num)
            {
                System.Console.WriteLine("UP");
                int temp = int.Parse(Console.ReadLine());
                if(temp > num)
                {
                    System.Console.WriteLine("DOWN");
                }
                else if(temp < num)
                {
                    System.Console.WriteLine("UP");
                }
                else
                {
                    System.Console.WriteLine("Correct");
                }
            }
            else
            {
                System.Console.WriteLine("Correct");
            }
        }
        public void Problem5_6()
        {
            int num = int.Parse(Console.ReadLine());
            if((num % 4 == 0 | num % 400 == 0) && num % 100 == 0)
            {
                System.Console.WriteLine("normal year");
            }
            else if((num % 4 == 0 | num % 400 == 0) && num % 100 != 0)
            {
                System.Console.WriteLine("leap year");
            }
        }
        public void Problem5_5()
        {
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0 && num % 3 == 0 && num % 5 == 0)
            {
                System.Console.WriteLine("A");
            }
            else if(num % 2 == 0 && num % 3 == 0)
            {
                System.Console.WriteLine("B");
            }
            else if(num % 2 == 0 && num % 5 == 0)
            {
                System.Console.WriteLine("C");
            }
            else if(num % 3 == 0 && num % 5 == 0)
            {
                System.Console.WriteLine("D");
            }
            else if(num % 2 == 0 || num % 3 == 0 || num % 5 == 0)
            {
                System.Console.WriteLine("E");
            }
            else
            {
                System.Console.WriteLine("N");
            }
        }
        public void Problem5_4()
        {
            int n1 = int.Parse(Console.ReadLine()), n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            if(n1 > n2 && n2 > n3)
            {
                Console.WriteLine($"{n1} {n3}");
            }
            else if(n1 < n2 && n2 < n3)
            {
                Console.WriteLine($"{n3} {n1}");
            }
            else if(n1 < n2 && n2 > n3)
            {
                Console.WriteLine($"{n2} {n3}");
            }
            else if(n1 > n2 && n2 < n3)
            {
                Console.WriteLine($"{n3} {n2}");
                
            }
        }
        public void Problem5_3()
        {
            int n1 = int.Parse(Console.ReadLine()), n2 = int.Parse(Console.ReadLine());

            if(n1 > n2)
            {
                System.Console.WriteLine(n1);
            }
            else if(n1 < n2)
            {
                System.Console.WriteLine(n2);
            }
            else
            {
                System.Console.WriteLine(n2);
            }
        }
        public void Problem5_2()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if(n1 * n1 == n2)
            {
                System.Console.WriteLine(n1 + "*" + n1 + "=" + n2);
            }
            else if(n2 * n2 == n1)
            {
                System.Console.WriteLine(n2 + "*" + n2 + "=" + n1);
            }
            else
            {
                System.Console.WriteLine("none");
            }
        }
        public void Problem5_1()
        {
            int num = int.Parse(Console.ReadLine());
            if(num >= 0 && num <= 40)
            {
                System.Console.WriteLine("tashqarida o'yna");
            }
            else
            {
                System.Console.WriteLine("ichkarida o'yna");
            }
        }
    }
}