using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_770
{
    public class StrumentoMusicale
    {
        public string Nome { get; set; }
        public string Info { get; set; }
        public virtual void Show() { }
        public virtual void Sound() { }
        public virtual void Desc() { }
        public virtual void History() { }
    }
    public class Violino : StrumentoMusicale
    {
        public string Nome { get; set; }
        public string Info { get; set; }
        public Violino()
        {
            Nome = " скрипка "; Info = " 1111";
        }
        public override void Show() { Console.WriteLine(Nome); }
        public override void Sound() { Console.WriteLine(" скрипичный "); }
        public override void Desc() { Console.WriteLine(Info); }
        public override void History() { Console.WriteLine(" очень интересная история"); }
    }
    public class Trombone : StrumentoMusicale
    {
        public string Nome { get; set; }
        public string Info { get; set; }
        public Trombone() { Nome = " тромбон "; Info = " 2222 "; }
        public override void Show() { Console.WriteLine(Nome); }
        public override void Sound() { Console.WriteLine(" гудит под нос "); }
        public override void Desc() { Console.WriteLine(Info); }
        public override void History() { Console.WriteLine(" очень старая интересная история"); }

    }
    public class Ukulele : StrumentoMusicale
    {
        public string Nome { get; set; }
        public string Info { get; set; }
        public Ukulele() { Nome = " укулеле "; Info = " 3333"; }
        public override void Show() { Console.WriteLine(Nome); }
        public override void Sound() { Console.WriteLine(" как балалайка, но хуже "); }
        public override void Desc() { Console.WriteLine(Info); }
        public override void History() { Console.WriteLine(" совсем неинтересная история"); }

    }
    public class Violoncello : StrumentoMusicale
    {
        public string Nome { get; set; }
        public string Info { get; set; }
        public Violoncello() { Nome = " виолончель "; Info = " 4444"; }
        public override void Show() { Console.WriteLine(Nome); }
        public override void Sound() { Console.WriteLine(" протяжный звук "); }
        public override void Desc() { Console.WriteLine(Info); }
        public override void History() { Console.WriteLine(" в церковь с таким нельзя"); }

    }
}

