using CMD.Models.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace CMD.Models.Data
{
    public class CMDDbContext : DbContext
    {
      
        public CMDDbContext()
            : base("name=CMDDbContext")
        {
        }

        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Clinic> Clinics { get; set; }


    }

   
}