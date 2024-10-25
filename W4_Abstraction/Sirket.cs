using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_Abstraction
{
    public abstract class Sirket  //abstract sinifi olusturuyoruz 
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        public Sirket(string ad, string soyad, string departman)  //constructor olusturuyoruz 
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }

        public abstract void Gorev(); //abstract metodu olusturuyoruz
    }

    public class YazilimGelistirici : Sirket //inheritance ornegi 
    {
        public YazilimGelistirici(string ad, string soyad, string departman) 
            : base(ad, soyad, departman)  //abstract sinif oldugu icin constructor tanimlamamiz lazim
        { }
        public override void Gorev() //override ornegi 
        {
            Console.WriteLine($"{Ad} {Soyad} : {Departman} olarak calisiyorum");
        }

    }

    public class ProjeYoneticisi : Sirket
    {
        public ProjeYoneticisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman)
        { }
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} : {Departman} olarak calisiyorum");
        }
    }

    public class SatisTemsilcisi : Sirket
    {
        public SatisTemsilcisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman)
        { }
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} : {Departman} olarak calisiyorum");
        }
    }
}