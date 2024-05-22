using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2207
{
    internal class Doctor_OCP_2207 : IPrint_OCP_2207
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Expertise { get; set; }
        public string DoctorID { get; set; }
        public string PhoneNumber { get; set; }
        public Doctor_OCP_2207(string name, string surname, string specialization, string doctorID, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            Expertise = specialization;
            DoctorID = doctorID;
            PhoneNumber = phoneNumber;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Adı: {Name}, Soyadı: {Surname}, Uzmanlık Alanı: {Expertise}, Doktor ID: {DoctorID}, Telefon Numarası: {PhoneNumber}");
        }
        public static void AddDoctor(List<Doctor_OCP_2207> doctors, string name, string surname, string specialization, string doctorID, string phoneNumber)
        {
            Doctor_OCP_2207 newDoctor = new Doctor_OCP_2207(name, surname, specialization, doctorID, phoneNumber);
            doctors.Add(newDoctor);
            Console.WriteLine("Doktor başarıyla eklendi.");
        }
        public static void RemoveDoctor(List<Doctor_OCP_2207> doctors, string doctorID)
        {
            Doctor_OCP_2207 doctorToRemove = doctors.Find(d => d.DoctorID == doctorID);
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
    }
}
