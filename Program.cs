using System;
using System.Collections.Generic;
namespace generic_list
{
    class Program
    {
        static void Main (string[ ]args)
        {
            List<int>sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(92);
            sayiListesi.Add(1);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Mavi");
            renkListesi.Add("Siyah");
            renkListesi.Add("Sarı");
            renkListesi.Add("Lacivert");

            //count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            // Foreach ve List.ForEach ile elemanlara erişim.
            foreach (var sayi in sayiListesi)
            Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
            Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(92);
            renkListesi.Remove("Mavi");

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));
            //index ile eleman çıkarma 
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(2);
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            // Liste içerisinde arama
            if (sayiListesi.Contains(10))
            Console.WriteLine("10 liste içerisindedir.");

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Siyah"));

            //diziyi List'e çevirme
            string[] hayvanlar= {"kedi","Köpek","Kanarya"};
            List<string> hayvanListesi= new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz
            hayvanListesi.Clear();
            
            // List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi= new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1=new Kullanıcılar();
            kullanıcı1.Isim="Muhammed";
            kullanıcı1.Soyisim="Solmaz";
            kullanıcı1.Yas=23;

            Kullanıcılar user2= new Kullanıcılar();
            user2.Isim="İkbal";
            user2.Soyisim="Kıyatsıl";
            user2.Yas=21;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(user2);

            Console.WriteLine(user2.Isim);
            Console.WriteLine(user2.Soyisim);

            List<Kullanıcılar> yeniListe= new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim="Asude",
                Soyisim="Solmaz",
                Yas= 21
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı adı: "+kullanıcı.Isim);
                Console.WriteLine("Kullanıcı soyadı: "+kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yaşı: "+kullanıcı.Yas);
            }

        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim{ get =>isim; set=>isim=value;}
        public string Soyisim{ get =>soyisim; set=>soyisim=value;}
        public int Yas{ get =>yas; set=>yas=value;}        


    }
}