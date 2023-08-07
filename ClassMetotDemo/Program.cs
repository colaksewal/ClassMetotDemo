using ClassMetotDemo;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(47, "Margaret", "Garcia", 20,"female");
            Musteri musteri2 = new Musteri(45, "Jack", "Thomas", 22, "male");

            MusteriManager manage =new MusteriManager();
            manage.MusterEkle(musteri1);
            manage.MusterEkle(musteri2);

            manage.PrintList();

        }
    }
}