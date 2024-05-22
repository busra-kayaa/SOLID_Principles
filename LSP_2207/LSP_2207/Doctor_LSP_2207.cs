using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2207
{
    internal class Doctor_LSP_2207
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Specialization { get; set; }
        public string DoctorID { get; set; }
        public string PhoneNumber { get; set; }

        public virtual void Add()
        {
            Console.WriteLine("Doktor ekleme işlemi gerçekleştirildi.");
        }
        public virtual void Remove()
        {
            Console.WriteLine("Doktor çkarma işlemi gerçekleştirildi.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Doktor Adı: {Name}, Soyadı: {Surname}, Uzmanlık: {Specialization}");
        }
    }
}
