using System;


namespace LabTaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Какой номер задания тестим?");
                int numOfTask;
                try
                {
                    numOfTask = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    
                    continue;
                }
                switch (numOfTask)
                {
                    case 1:
                        First();
                        break; ;
                    case 2:
                        Second();
                        break;
                    case 3:
                        Third();
                        break;
                    case 4:
                        Fourth();
                        break;
                    case 5:
                        Fifth();
                        break;

                    default:
                        Console.WriteLine("Такого номера нету");
                        break;

                }
                Console.WriteLine("Press any key to next....");
                Console.ReadKey();
            }

        }
        
        static void First()
        {
            Console.WriteLine("Введите Х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("А теперь введи У");
            int y = Convert.ToInt32(Console.ReadLine());
            if(Math.Cos(12 * y - 4) == 0)
            {
                Console.WriteLine("Е ВАСЯ НА НОЛЬ НЕ ДЕЛЯТ");
            }
            else if (x+1<0)
            {
                Console.WriteLine("x+1<0");
            }
            else
            {
                Console.WriteLine((1 + Math.Sin(Math.Sqrt(x))) / (Math.Cos(12 * y - 4)));
            }         

        }
        static void Second()
        {
            Console.WriteLine("Введите Х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(x)+Math.Abs(x+1));
        }
        static void Third()
        {

            Console.WriteLine("Введите Х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("А теперь введи У");
            int y = Convert.ToInt32(Console.ReadLine());
            if (1 + Math.Pow(x, 2) * Math.Pow(y, 2) == 0)
            {
                Console.WriteLine("Е ВАСЯ НА НОЛЬ НЕ ДЕЛЯТ");
            }
            else if (x + 2 < 0)
            {
                Console.WriteLine("x+2<0");
            }
            else
            {
                Console.WriteLine((1+Math.Pow(Math.Sin(x + y), 2)) / (2+x-(2*x)/(1+Math.Pow(x,2)*Math.Pow(y, 2))));
            }
        }
        static void Fourth()
        {
            Console.WriteLine("Введите Х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x-(Math.Pow(x, 3)/(3))-(Math.Pow(x, 5)/(5)));
        }
        static void Fifth()
        {
            Console.WriteLine("Введите m");
            int m = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Введите h");
            int h = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Введите v");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите g");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((m+Math.Pow(v, 3))/2+m*g*h);
        }
    }
}
