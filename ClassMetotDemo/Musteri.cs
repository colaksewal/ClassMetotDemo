using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Musteri
    {
        public int id { get; set; }
        public string name { get; set; }

        public string surname { get; set; }

        public int age { get; set; }
        
        public string gender { get; set; }

        public Musteri(int id, string name , string surname, int age , string gender)
        {
            this.id = id;   
            this.name = name;   
            this.surname = surname; 
            this.age = age; 
            this.gender = gender;   


        }
    }
}
