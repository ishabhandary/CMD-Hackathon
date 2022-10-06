using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMD.Models.Entities
{
    public class Clinic
    {
        public long ClinicId { get; set; }

        [Required]
        public string ClinicName { get; set; }

        public string BusinessName { get; set; }

        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string ZipCode { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public DateTime DateCreated { get; set; }

        public List<Service> Services { get; set; }

    }
}