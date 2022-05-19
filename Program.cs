using System;
using System.Collections.Generic;

namespace sr1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. инициализировать все поля
            //2. получить полную информацию об аптеке
            //3. выяснить стоимость самого дорогого лекарства
            //4. найти стоимость всех лекарсив
            int sum = 0;
            int max=0;
            Console.WriteLine("Демонстрация работы класса");
            List <Apteka> apteka = new List <Apteka>();
            Console.WriteLine("введите название аптеки:");
            string name = Console.ReadLine();
            Console.WriteLine("кол-во лекарств:");
            int kol = Convert.ToInt32(Console.ReadLine());

            for (int x=0;x < kol;x++)
            {
                Console.WriteLine("введите название лекарства: ");
                string name_l = Console.ReadLine();
                Console.WriteLine("введите его цену: ");
                int money_l = Convert.ToInt32(Console.ReadLine());
                sum = money_l + sum;
                if (money_l > max)
                {
                  max = money_l;
                }
               apteka.Add(new Apteka(name, name_l, money_l,sum, max));
            }
            Console.WriteLine("название аптеки:"+name);
            Console.WriteLine("название и стоимость лекарств:");
           
            //apteka.Sort();
            foreach (Apteka z in apteka)
            z.Info();
            
            Console.WriteLine($"стоимость всех лекарств: {sum} руб.");
            Console.WriteLine($"стоимость максимального лекарства: {max} руб.");
        }
    }
}
