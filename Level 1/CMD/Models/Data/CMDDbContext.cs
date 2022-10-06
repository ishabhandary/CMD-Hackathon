using CMD.Models.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace CMD.Models.Data
{
    public class CMDDbContext : DbContext
    {
        public CMDDbContext()
            : base("name=initial")
        {
        }


        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<Service> Services { get; set; }
    }
}