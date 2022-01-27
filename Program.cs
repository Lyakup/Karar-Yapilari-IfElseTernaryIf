using System;

namespace Karar_Yapilari_IfElseTernary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            Console.WriteLine("Time :" + time);

            /*
            if(time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın");
            
            }else if (time <= 18)
            {
                Console.WriteLine("İyi Günler");
            }
            else if (time <= 23)
            {
                Console.WriteLine("İyi Akşamlar");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }
            */

            string sonuc;

            //sonuc = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : time <= 23 ? "İyi Akşamlar" : "İyi Geceler";
            sonuc = time >= 0 && time < 6 ? "İyi Geceler" : time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : time <= 23 ? "İyi Akşamlar" : "İyi Geceler";

            Console.WriteLine(sonuc);
        }
    }
}