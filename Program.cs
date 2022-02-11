using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisanlar C1 = new Calisanlar();
            C1.ad = "Ömer";
            C1.soyad = "Gökdaş";
            C1.yazdir(C1);

            Calisanlar C2 = new Calisanlar("ömer", "gökdaş");
            C2.yazdir(C2);

            Console.ReadLine();
        }


    }

    public class Calisanlar
    {
        public string ad;
        public string soyad;

        public Calisanlar()
        {
            
        }

        public void yazdir(Calisanlar C)
        {
            Console.WriteLine("{0}-{1}",C.ad,C.soyad);
        }


        public Calisanlar(string isim, string soyisim)
        {
            ad = isim;
            soyad = soyisim;
        }
    } 
}
