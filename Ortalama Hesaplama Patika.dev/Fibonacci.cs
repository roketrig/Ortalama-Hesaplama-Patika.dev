using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Hesaplama_Patika.dev
{
    public class Fibonacci
    {
        public int OrtalamaHesapla(int deger)
        {

            int[] sayilar = new int[deger];
            sayilar[0] = 1;
            sayilar[1] = 1;
            int toplam = 0;

            for (int i = 2; i < deger; i++)
            {
                sayilar[i] = sayilar[i - 1] + sayilar[i - 2];
                toplam += sayilar[i];
            }
            int b = toplam / deger;

            

            for (int i = 0; i < deger; i++)
            {
                Console.Write(sayilar[i]+ ", ");
            }

            Console.WriteLine("Fibonacci Ortalaması :" + b);

            return deger;
        }
    }
}
