using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_2207
{
    internal class Prescription_LSP_2207
    {
        public List<TherapeuticProduct_LSP_2207cs> Products { get; set; }
        public string PrescriptionNumber { get; set; }
        public DateTime IssueDate { get; set; }

        public Prescription_LSP_2207()
        {
            Products = new List<TherapeuticProduct_LSP_2207cs>();
            IssueDate = DateTime.Now;
        }

        public void AddProduct(TherapeuticProduct_LSP_2207cs product)
        {
            Products.Add(product);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Reçete Numarası: {PrescriptionNumber}, Veriliş Tarihi: {IssueDate}");
            Console.WriteLine("İlaçlar:");
            foreach (var product in Products)
            {
                product.DisplayInfo();
            }
        }
    }
}
