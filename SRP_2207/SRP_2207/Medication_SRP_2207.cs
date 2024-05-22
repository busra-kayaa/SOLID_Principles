using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SRP_2207
{
    internal class Medication_SRP_2207
    {
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string InstructionsforUse { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public Medication_SRP_2207(string name, string dosage, string instructions, double price, int stock)
        {
            Name = name;
            Dosage = dosage;
            InstructionsforUse = instructions;
            Price = price;
            Stock = stock;
        }
        public static void AddMedication(List<Medication_SRP_2207> medications, string name, string dosage, string instructions, double price, int stock)
        {
            Medication_SRP_2207 newMedication = new Medication_SRP_2207(name, dosage, instructions, price, stock);
            medications.Add(newMedication);
            Console.WriteLine("İlaç başarıyla eklendi.");
        }
        public static void RemoveMedication(List<Medication_SRP_2207> medications, string name)
        {
            Medication_SRP_2207 medicationToRemove = medications.Find(m => m.Name == name);
            if (medicationToRemove != null)
            {
                medications.Remove(medicationToRemove);
                Console.WriteLine("İlaç başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Belirtilen isimde ilaç bulunamadı.");
            }
        }
        public void DisplayMedicationInfo()
        {
            Console.WriteLine($"İlaç Adı: {Name}, Dozaj: {Dosage}, Kullanma Talimatı: {InstructionsforUse}, Stok: {Stock}, Fiyat: {Price}");
        }
    }
}
