using System;
using System.Collections.Generic;
using System.Text;

namespace sr1
{
    class Apteka
    {
        public string name; //название аптеки
        public string name_l; //название лекарств
        public int money_l; //стоимость каждого лекарства
        public int sum; //cумма всех лекарств
        public int max;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="name_l"></param>
        /// <param name="money_l"></param>

        //описание методов
        public Apteka(string name, string name_l, int money_l,int sum, int max)
        {
            this.name = name;
            this.name_l = name_l;
            this.money_l = money_l;
            this.sum = sum;
            this.max = max;
        }
        public void Info()
        {
            Console.WriteLine($"{name_l}- {money_l} руб.");
            
        }
    }
}
