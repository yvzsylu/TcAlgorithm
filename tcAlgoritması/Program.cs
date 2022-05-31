using System;

namespace tcAlgoritması
{
    internal class Program
    {
        static bool TcMi(string tc)
        {
            bool deger = false;
            if (tc.Length != 11)
            {
                return false;
            }
            if (tc[0] == 0)
            {
                return false;
            }
            int c1, c2, c3, c4, c5, c6, c7, c8, c9, l10, l11;

            c1 = Convert.ToInt32(tc[0]) - 48;
            c2 = Convert.ToInt32(tc[1]) - 48;
            c3 = Convert.ToInt32(tc[2]) - 48;
            c4 = Convert.ToInt32(tc[3]) - 48;
            c5 = Convert.ToInt32(tc[4]) - 48;
            c6 = Convert.ToInt32(tc[5]) - 48;
            c7 = Convert.ToInt32(tc[6]) - 48;
            c8 = Convert.ToInt32(tc[7]) - 48;
            c9 = Convert.ToInt32(tc[8]) - 48;
            l10 = Convert.ToInt32(tc[9]) - 48;
            l11 = Convert.ToInt32(tc[10]) - 48;

            int onuncu, onbirinci;

            onuncu = (((c1 + c3 + c5 + c7 + c9) * 7) - (c2 + c4 + c6 + c8)) % 10;
            onbirinci = (c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + onuncu) % 10;

            if (onuncu == l10 && onbirinci == l11)
            {
                deger = true;
            }
            return deger;


        }
        static void Main(string[] args)
        {
            

            Console.Write("Tc' nizi giriniz:");
            string tc = Console.ReadLine();

            if (TcMi(tc))
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış");
            }


        }
    }
}
