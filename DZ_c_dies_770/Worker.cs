using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_770
{
    public abstract class Worker
    {
        public abstract void Print();
    }
    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine(" Президент ");
        }
    }
    public class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine(" Охрана ");
        }
    }
    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine(" Манагер ");
        }
    }
    public class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine(" Инженер ");
        }
    }
}
