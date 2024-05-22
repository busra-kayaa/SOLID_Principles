using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SRP_2207
{
    public class Clinic_SRP_2207
    {
        public string ClinicName { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Clinic_SRP_2207(string clinicName, string department, string address, string phoneNumber)
        {
            ClinicName = clinicName;
            Department = department;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public static void AddClinic(List<Clinic_SRP_2207> clinics, string name, string department, string address, string phoneNumber)
        {
            Clinic_SRP_2207 newClinic = new Clinic_SRP_2207(name, department, address, phoneNumber);
            clinics.Add(newClinic);
            Console.WriteLine("Klinik başarıyla eklendi.");
        }
        public static void RemoveClinic(List<Clinic_SRP_2207> clinics, string name)
        {
            Clinic_SRP_2207 clinicToRemove = clinics.Find(c => c.ClinicName == name);
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
        public void DisplayClinicInfo()
        {
            Console.WriteLine($"Klinik Adi: {ClinicName}, Departmant: {Department}, Adres: {Address}, Telefon: {PhoneNumber}");
        }

        public static void UpdateClinicInfo(List<Clinic_SRP_2207> clinics, string name, string newClinicName, string newDepartment, string newAddress, string newPhoneNumber)
        {
            Clinic_SRP_2207 clinicToUpdate = clinics.Find(d => d.ClinicName == name);

            if (clinicToUpdate == null)
            {
                Console.WriteLine("Hata: Belirtilen isimde klinik bulunamadı.");
                return;
            }

            clinicToUpdate.ClinicName = newClinicName;
            clinicToUpdate.Department = newDepartment;
            clinicToUpdate.Address = newAddress;
            clinicToUpdate.PhoneNumber = newPhoneNumber;

            Console.WriteLine("Klinik bilgileri başarıyla güncellendi.");
        }
    }
}
