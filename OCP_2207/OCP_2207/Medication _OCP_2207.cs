using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2207
{
    internal class Medication__OCP_2207 : IPrint_OCP_2207
    {
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string UsageInstructions { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        public Medication__OCP_2207(string name, string dosage, string instructions, double price, int stock)
        {
            Name = name;
            Dosage = dosage;
            UsageInstructions = instructions;
            Price = price;
            Stock = stock;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"İlaç Adı: {Name}, Dozaj: {Dosage}, Kullanma Talimatı: {UsageInstructions}, Stok: {Stock}, Fiyat: {Price}");

        }
        public static void AddMedication(List<Medication__OCP_2207> medications, string name, string dosage, string instructions, double price, int stock)
        {
            Medication__OCP_2207 newMedication = new Medication__OCP_2207(name, dosage, instructions, price, stock);
            medications.Add(newMedication);
            Console.WriteLine("İlaç başarıyla eklendi.");
        }
        public static void RemoveMedication(List<Medication__OCP_2207> medications, string name)
        {
            Medication__OCP_2207 medicationToRemove = medications.Find(m => m.Name == name);
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
    }
}
