using CMD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMD.Models.Data
{
    public class CMDRepository : ICMDRepository
    {
        private CMDDbContext db=new CMDDbContext();
        public Clinic CreateClinic(Clinic clinic)
        {
            db.Clinics.Add(clinic);
            db.SaveChanges();
            return clinic;
        }

        public Clinic GetClinic(int id)
        {
            var clinic = (from c in db.Clinics
                    where c.ClinicId==id
                    select c).FirstOrDefault();
            return clinic;
        }
    }
}