using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayiListesi = new ArrayList();
            ArrayList enKucukListe = new ArrayList();
            ArrayList enBuyukListe = new ArrayList();
            

            Console.WriteLine("Lütfen 20 tane sayı giriniz: ");

            for(int i = 0; i<20; i++){
                int sayi = int.Parse(Console.ReadLine());
                sayiListesi.Add(sayi);
            }

            sayiListesi.Sort();
            for(int i = 0; i<3; i++){
                enKucukListe.Add(sayiListesi[i]);
            }
            sayiListesi.Reverse();
            for(int i = 0; i<3; i++){
                enBuyukListe.Add(sayiListesi[i]);
            }

            int enKucukToplam = 0;
            foreach(int sayi in enKucukListe){
                enKucukToplam += sayi;
            }

            int enBuyukToplam = 0;
            foreach(int sayi in enBuyukListe){
                enBuyukToplam += sayi;
            }

            int enKucukOrtalama = enKucukToplam/3;
            int enBuyukOrtalama = enBuyukToplam/3;

            Console.WriteLine("En küçük 3 sayının ortalaması: " + enKucukOrtalama);
            Console.WriteLine("En büyük 3 sayının ortalaması: " + enBuyukOrtalama);

            Console.WriteLine("Ortalama toplamları: " + enKucukOrtalama+enBuyukOrtalama);
            Console.ReadLine();

        }
    }
}
