using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2207
{
    internal class Clinic_OCP_2207 : IPrint_OCP_2207
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Clinic_OCP_2207(string clinicName, string department, string address, string phoneNumber)
        {
            Name = clinicName;
            Department = department;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public static void AddClinic(List<Clinic_OCP_2207> clinics, string name, string department, string address, string phoneNumber)
        {
            Clinic_OCP_2207 newClinic = new Clinic_OCP_2207(name, department, address, phoneNumber);
            clinics.Add(newClinic);
            Console.WriteLine("Klinik başarıyla eklendi.");
        }
        public static void RemoveClinic(List<Clinic_OCP_2207> clinics, string name)
        {
            Clinic_OCP_2207 clinicToRemove = clinics.Find(c => c.Name == name);
            if (clinicToRemove != null)
            {
                clinics.Remove(clinicToRemove);
                Console.WriteLine("Klinik başarıyla kaldırıldı.");
            }
            else
            {
                Console.WriteLine("Belirtilen isimle klinik bulunamadı.");
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Klinik Adi: {Name}, Departmant: {Department}, Adres: {Address}, Telefon: {PhoneNumber}");

        }
    }
}
