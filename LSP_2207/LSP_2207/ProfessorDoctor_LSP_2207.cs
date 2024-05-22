using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2207
{
    internal class ProfessorDoctor_LSP_2207 : Doctor_LSP_2207
    {
        public string Field { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Uzmanlık Alanı: {Field}");
        }
        public override void Add()
        {
            base.Add();
            Console.WriteLine("Profesör doktor eklendi.");
        }
        public override void Remove()
        {
            base.Remove();
            Console.WriteLine(" Profesör Doktor çkarma işlemi gerçekleştirildi.");
        }
        public void ConductResearch()
        {
            Console.WriteLine("Araştırma yapılıyor...");
        }
    }
}
