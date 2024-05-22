using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SRP_2207
{
    public class Patient_SRP_2207
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string TCKN { get; set; }
        public string PhoneNumber { get; set; }

        public Patient_SRP_2207(string name, string surname, int age, string gender, string tckn, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            TCKN = tckn;
            PhoneNumber = phoneNumber; 
        }
        public static void AddPatient(List<Patient_SRP_2207> patients, string name, string surname, int age, string gender, string tckn, string phoneNumber)
        {
            Patient_SRP_2207 newPatient = new Patient_SRP_2207(name, surname, age, gender, tckn, phoneNumber);
            patients.Add(newPatient);
            Console.WriteLine("Hasta başarıyla eklendi.");
        }

        public static void RemovePatient(List<Patient_SRP_2207> patients, string tckn)
        {
            Patient_SRP_2207 patientToRemove = patients.Find(p => p.TCKN == tckn);
            if (patientToRemove != null)
            {
                patients.Remove(patientToRemove);
                Console.WriteLine("Hasta başarıyla kaldırıldı.");
            }
            else
            {
                Console.WriteLine("Belirtilen TCKN ile hasta bulunamadı.");
            }
        }
        public void DisplayPatientInfo()
        {
            Console.WriteLine($"Adı: {Name}, Soyadı: {Surname}, Yaş: {Age}, Cinsiyet: {Gender}, TCKN: {TCKN}, Telefon: {PhoneNumber}");
        }

    }

}
