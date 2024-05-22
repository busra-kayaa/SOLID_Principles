using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_2207
{
    internal interface IClinic_ISP_2207 : IEntity_ISP_2207
    {
        List<IDoctor_ISP_2207> Doctors { get; set; }
        void AddDoctor(IDoctor_ISP_2207 doctor);
        void RemoveDoctor(IDoctor_ISP_2207 doctor);
    }
}
