using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace тест
{
    internal class Program
    {
        public static string name ;
        public static double seconds;
        public static double k;
        public static double vsrc;
        public static double o;
        public static char[] vvod;
        static void Main(string[] args)
        {
            ConsoleKeyInfo knopk;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear(); ;
                Console.WriteLine("Введите ваше имя: ");
                name = Console.ReadLine();
                Console.Clear();
                vvod = Class1.s.ToCharArray();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                foreach (char item in vvod)
                {
                    Console.Write(item);
                }
                Console.WriteLine(' ');
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Когда будете готовы - нажмите Enter. Для выхода - Escape");
                knopk = Console.ReadKey();
                Console.Clear();
                if (knopk.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    foreach (char item in vvod)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    k = 0;
                    o = 0;

                    vrema();
                }
            } while (knopk.Key != ConsoleKey.Escape);
            Console.WriteLine("gПока пока");
            Environment.Exit(0);
        }
        static void vrema()
        {
            seconds = 0;
            int minutes = 1;
            Thread vremi = new Thread(_ =>
            {
                do
                {
                    try
                    {
                        double der;
                        der = k + o;
                        Console.SetCursorPosition(0, 10);
                        Console.Write($"{minutes}:{seconds.ToString().PadLeft(2, '0')} ");
                        Thread.Sleep(1000);
                        if (der == 449)
                        {
                            break;
                        }
                        if (seconds == 0 && minutes == 1)
                        {
                            minutes--;
                            seconds = 60;
                        }
                        seconds--;
                    }
                    catch (System.Threading.ThreadInterruptedException)
                    {
                        break;
                    }
                } while ( seconds >= 0);
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("Стоп!");
                
            });
            vremi.Start();
            text();
            Thread.Sleep(2000);
            ConsoleKeyInfo knopk2 = Console.ReadKey(true);          
            if (knopk2.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Пока пока");
                Environment.Exit(0);
            }
            else 
            {
                tablica.zapictablica(name,vsrc,k);
                tablica.tablicar();                
            }

        }
        internal static void text()
        {
            int j = 1;
            int h = 0;
            int i=0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                try
                {
                    ConsoleKeyInfo uservvodit = Console.ReadKey(true);
                    char a = uservvodit.KeyChar;
                    Console.SetCursorPosition(h, j);
                    Console.WriteLine(a);
                    if (a == vvod[i])
                    {
                        k++;
                    }
                    else if (a != vvod[i])
                    {
                        o++;
                    }
                    h++;
                }
                catch (Exception)
                {
                    h = 0;
                    j++;
                    ConsoleKeyInfo uservvodit = Console.ReadKey(true);
                    char a = uservvodit.KeyChar;
                    Console.SetCursorPosition(h, j);
                    Console.WriteLine(a);
                    if (a == vvod[i])
                    {
                        k++;
                    }
                    else if (a != vvod[i])
                    {
                        o++;
                    }
                }
                finally
                {
                    i++;
                }
                
            } while (k + o < 449 && seconds > 0);
            vsrc = k / 60;
        }
        

           
    }
}
