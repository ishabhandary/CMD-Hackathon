using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMD.Models.Entities
{
    public class Service
    {
        public long ServiceId { get; set; }

        [Required]
        public string ServiceName { get; set; }

        [Required]
        public int ServiceCode { get; set; }

        public string ServiceDescription { get; set; }

        public double AveragePrice { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public ServiceType ServiceType { get; set; }

        public List<Clinic> Clinics { get; set; }

    }

    public enum ServiceType
    {
        Consultation, Xray, BloodTest, CovidTest, MRIScan
    }
}