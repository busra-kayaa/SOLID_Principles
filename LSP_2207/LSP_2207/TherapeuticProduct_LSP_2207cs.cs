using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2207
{
    internal class TherapeuticProduct_LSP_2207cs
    {
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Instructions { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"İlaç Adı: {Name}, Dozaj: {Dosage}, Talimatlar: {Instructions}");
        }
    }
}
