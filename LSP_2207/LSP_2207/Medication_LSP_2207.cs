using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2207
{
    internal class Medication_LSP_2207 : TherapeuticProduct_LSP_2207cs
    {
        public decimal Price { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Fiyat: {Price:C}");
        }
    }
}
