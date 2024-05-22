using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_2207
{
    internal interface IClinic_DIP_2207
    {
        string Name { get; set; }
        string Surname { get; set; }

        void AddDoctor(IDoctor_DIP_2207 doctor);
        void RemoveDoctor(IDoctor_DIP_2207 doctor);
    }
}
