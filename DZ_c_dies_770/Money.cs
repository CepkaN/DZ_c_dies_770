using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_770
{
    public class Money
    {
        public string Nome { get; set; }
        public int Realo { get; set; }
        public int Man { get; set; }
        public Money(string N,int a,int b)
        {
            Nome = N;Realo = a;Man = b;
        }
        public void Mostra()
        {
            Console.WriteLine("  " + Realo + " и " + Man + "  " + Nome);
        }
    }
    public class Product
    {
        public string NomeP { get; set; }
        public Money Prix { get; set; }
        public Product(string N,string M,int a,int b)
        {
            NomeP = N;Prix = new Money(M, a, b);
        }
        public void Mo()
        {
            Console.Write(" Наименование : " + NomeP + "\n Цена : " );Prix.Mostra();
        }
        public void PrixVar(int a)
        {
            int g = Prix.Realo * 100 + Prix.Man;
            g = g - a * 100;
            Prix.Realo = g / 100;Prix.Man = g % 100;
            Console.WriteLine(" Новая цена : ");Prix.Mostra();
        }
    }
}
