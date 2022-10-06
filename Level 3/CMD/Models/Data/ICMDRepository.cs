using CMD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Models.Data
{
    public interface ICMDRepository
    {
        Clinic CreateClinic(Clinic clinic);

        Clinic GetClinic(int id);
    }
}
