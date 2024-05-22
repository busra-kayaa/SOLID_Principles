using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2207
{
    internal class Patient_LSP_2207
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public virtual void Add()
        {
            Console.WriteLine("Hasta ekleme işlemi gerçekleştirildi.");
        }
        public virtual void Remove()
        {
            Console.WriteLine("Hasta çıkarma işlemi gerçekleştirildi.");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Hasta Adı: {Name}, Soyadı: {Surname}, Yaşı: {Age}");
        }
    }
}
