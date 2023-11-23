using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace тест
{
    public class tablica
    {
        public string name;
        public double vminutu;
        public double vsec;
        public static void zapictablica(string name, double vsrc, double k)
        {
            string json = "";
            List<tablica> tablicas = new List<tablica>();
            tablica cpicki = new tablica();
            cpicki.name = name;
            cpicki.vsec = vsrc;
            cpicki.vminutu = k;
            tablicas.Add(cpicki);
            string ajson = File.ReadAllText("C:\\Users\\user1\\Desktop\\resul.json");
            List<tablica> vivodы = JsonConvert.DeserializeObject<List<tablica>>(ajson);
            try
            {
                vivodы.Add(cpicki);
                json = JsonConvert.SerializeObject(vivodы);
            }
            catch (Exception)
            {
                json = JsonConvert.SerializeObject(tablicas);
            }
            finally
            {

                File.WriteAllText("C:\\Users\\user1\\Desktop\\resul.json", json);
            }
        }
        public static void tablicar()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                   Таблица рекордов                                                    ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            string json = File.ReadAllText("C:\\Users\\user1\\Desktop\\resul.json");
            List<tablica> vivoda = JsonConvert.DeserializeObject<List<tablica>>(json);
            foreach (var cpicki in vivoda)
            {
                Console.WriteLine("Имя                 " + cpicki.name);
                Console.WriteLine("Скорость в минуту   " + cpicki.vminutu);
                Console.WriteLine("Скорость в секунду  " + cpicki.vsec);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine("Если хотите повторить игру - нажмите Enter.Если хотите выйти - Escape");
            Thread.Sleep(1000);
            ConsoleKeyInfo knopk3 = Console.ReadKey(true);
            if (knopk3.Key == ConsoleKey.Enter)
            {

            }
            else if (knopk3.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Пока пока");
                Environment.Exit(0);
            }
        }
    }
    
}
