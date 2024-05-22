using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SRP_2207
{
    public class Doctor_SRP_2207
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Specialization { get; set; }
        public string DoctorID { get; set; }
        public string PhoneNumber { get; set; }
        public Doctor_SRP_2207(string name, string surname, string specialization, string doctorID, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            Specialization = specialization;
            DoctorID = doctorID;
            PhoneNumber = phoneNumber;
        }
        public static void AddDoctor(List<Doctor_SRP_2207> doctors, string name, string surname, string specialization, string doctorID, string phoneNumber)
        {
            Doctor_SRP_2207 newDoctor = new Doctor_SRP_2207(name, surname, specialization, doctorID, phoneNumber);
            doctors.Add(newDoctor);
            Console.WriteLine("Doktor başarıyla eklendi.");
        }

        public static void RemoveDoctor(List<Doctor_SRP_2207> doctors, string doctorID)
        {
            Doctor_SRP_2207 doctorToRemove = doctors.Find(d => d.DoctorID == doctorID);
            if (doctorToRemove != null)
            {
                doctors.Remove(doctorToRemove);
                Console.WriteLine("Doktor başarıyla çıkarıldı.");
            }
            else
            {
                Console.WriteLine("Belirtilen ID ile doktor bulunamadı.");
            }
        }

        public void DisplayDoctorInfo()
        {
            Console.WriteLine($"Adı: {Name}, Soyadı: {Surname}, Uzmanlık Alanı: {Specialization}, Doktor ID: {DoctorID}, Telefon Numarası: {PhoneNumber}");
        }

        public static void UpdateDoctorInfo(List<Doctor_SRP_2207> doctors, string doctorID, string name, string surname, string specialization, string doctorid, string phoneNumber)
        {
            Doctor_SRP_2207 doctorToUpdate = doctors.Find(d => d.DoctorID == doctorID);

            if (doctorToUpdate == null)
            {
                Console.WriteLine("Hata: Belirtilen ID'ye sahip doktor bulunamadı.");
                return;
            }

            doctorToUpdate.Name = name;
            doctorToUpdate.Surname = surname;
            doctorToUpdate.Specialization = specialization;
            doctorToUpdate.DoctorID = doctorid ;
            doctorToUpdate.PhoneNumber = phoneNumber;

            Console.WriteLine("Doktor bilgileri başarıyla güncellendi.");
        }

    }

  }
