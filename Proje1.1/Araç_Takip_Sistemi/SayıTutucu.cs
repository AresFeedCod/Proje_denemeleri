using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Takip_Sistemi
{
    internal interface SayıTutucu /* Bir İnterface ile ara köprü kuruyoruz ki aldığımız tüm sayıları birbirleri arasında aktarma yabiliriz. */
    {
        void sayı1();
        void sayı2();

        void geriyazdırma();
    }

    class sayıTutucu /* Bu class sayesinde değerlrimizi bir kalıtım olarak kullanıyoruz. */
    {
        public int sayı { get; set; }

        public int sayı2 { get; set; }

        public int geriyazdırma { get; set; }
    }

    class SayıAlma : SayıTutucu /* Kullanıcıdan verilerimizi artık alabiliyoruz. */ 
    {
        sayıTutucu sayıtutucu = new sayıTutucu();
        public void sayı1()
        {
            Console.Write("Lütfen birinçi sayıyı giriniz = ");
            sayıtutucu.sayı = Convert.ToInt32(Console.ReadLine());
        }

        public void geriyazdırma()
        {
            return;
        }


        public void sayı2()
        {
            Console.Write("Lütfen ikinçi sayıyı giriniz = ");
            sayıtutucu.sayı2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
