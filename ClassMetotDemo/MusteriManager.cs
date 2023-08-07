using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
           // Musteri[] musteris = new Musteri[] {};
       
            //Liste oluşturarak eklemeler yap

         

            List<Musteri> musteriList = new List<Musteri>();

            public void MusterEkle(Musteri musteri)
            {
                musteriList.Add(musteri);
            }

           public   void MusteriSil(Musteri musteri)
           {
            musteriList.Remove(musteri);    
           }

            public void PrintList()
            {
               foreach(Musteri musteri in musteriList) { 
                Console.WriteLine(musteri.id + " " + musteri.name + " " + musteri.surname + " "+ musteri.age+ " "+ musteri.gender);
            }
                
            }

    }
}
