using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_770
{   
    public class CreditCard
    {
        static public int PRE(Money M)
        {
            int d = M.Realo * 100 + M.Man;
            return d;
        }
        static public Money PRE(int a)
        {
            int a1 = a / 100;
            int a2 = a % 100;
            Money M = new Money(" рублей ", a1, a2);
            return M;
        }
        static public Money Mon { get; set; }
        static public string CVC { get; set; }
        public CreditCard(string C,int a,int b,string rub)
        {
            Mon = new Money(rub, a, b);CVC = C;
        }
        public void Summa() { Console.Write(" На карте : ");Mon.Mostra(); }
        static public Money operator +(CreditCard M,Money M2)
        {
            int a = PRE(Mon) + PRE(M2);
            Mon=PRE(a);
            return Mon;
        }
        static public Money operator -(CreditCard M, Money M2)
        {
            int a = PRE(Mon) + PRE(M2);
            Mon = PRE(a);
            return Mon;
        }
        static public bool operator ==(CreditCard M, string h)
        {
            return CVC == h;
        }
        static public bool operator !=(CreditCard M, string h)
        {
            return CVC != h;
        }
        static public bool operator >(CreditCard M, Money M2)
        {
            return PRE(Mon) > PRE(M2);
        }
        static public bool operator <(CreditCard M, Money M2)
        {
            return PRE(Mon) < PRE(M2);
        }
    }
}
