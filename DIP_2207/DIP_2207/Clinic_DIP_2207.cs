using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2207
{
    public class Clinic_DIP_2207 : IClinic_DIP_2207
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private List<IDoctor_DIP_2207> _doctors;

        public Clinic_DIP_2207()
        {
            _doctors = new List<IDoctor_DIP_2207>();
        }

        public void AddDoctor(IDoctor_DIP_2207 doctor)
        {
            _doctors.Add(doctor);
            Console.WriteLine($"{doctor.Name} {doctor.Surname} kliniğe eklendi.");
        }

        public void RemoveDoctor(IDoctor_DIP_2207 doctor)
        {
            _doctors.Remove(doctor);
            Console.WriteLine($"{doctor.Name} {doctor.Surname} klinikten çıkarıldı.");
        }
        public void OpenClinic()
        {
            Console.WriteLine($"Kliniği {Name} şu anda açık.");
        }

        public void CloseClinic()
        {
            Console.WriteLine($"Kliniği {Name} şu anda kapalı.");
        }
    }

}
