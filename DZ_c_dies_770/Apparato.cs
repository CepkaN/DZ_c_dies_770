using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_770
{
    public abstract class Apparato
    {
        public string Nome { get; set; }
        public string Info{get;set;}
        public virtual void Show() { }
        public virtual void Sound() { }
        public virtual void Desc() { }
    }
    public class Bollitore : Apparato
    {
        public string Nome { get; set; }
        public string Info { get; set; }
        public Bollitore()
        {
            Nome = " чайник ";Info = " 1111";
        }
        public override void Show() { Console.WriteLine(Nome); }
        public override void Sound() { Console.WriteLine(" свистит "); }
        public override void Desc() { Console.WriteLine(Info); }
    }
    public class Microonde : Apparato
    {
        public string Nome { get; set; }
        public string Info { get; set; }
        public Microonde() { Nome = " Микроволновка ";Info = " 2222 "; }
        public override void Show() { Console.WriteLine(Nome); }
        public override void Sound() { Console.WriteLine(" волнуется "); }
        public override void Desc() { Console.WriteLine(Info); }
    }
    public class Auto : Apparato
    {
        public string Nome { get; set; }
        public string Info { get; set; }
        public Auto() { Nome = " автомобиль ";Info = " 3333"; }
        public override void Show() { Console.WriteLine(Nome); }
        public override void Sound() { Console.WriteLine(" врум-врум "); }
        public override void Desc() { Console.WriteLine(Info); }
    }
    public class Piroscafo : Apparato
    {
        public string Nome { get; set; }
        public string Info { get; set; }
        public Piroscafo() { Nome = " пароход ";Info = " 4444"; }
        public override void Show() { Console.WriteLine(Nome); }
        public override void Sound() { Console.WriteLine(" гудит "); }
        public override void Desc() { Console.WriteLine(Info); }
    }
}
