using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Takip_Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Matematik_İşlemleri matematik_işlemleri = new Matematik_İşlemleri();




            Console.WriteLine("Merhaba Hoşgeldin.");
            SayıAlma sayıAlma = new SayıAlma();
            sayıAlma.sayı1();
            sayıAlma.sayı2();

            sayıTutucu sayıtutucu = new sayıTutucu();


            Matematik_İşlemleri matematikişlemleri = new Matematik_İşlemleri();


            Console.Write("Sayıların mutlak değeri = "  );
            matematikişlemleri.MutlakDeğer3(sayıtutucu);




            Console.ReadLine();
        }
    }
}
