using CMD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CMD.Models.Data;

namespace CMD.Controllers
{
    public class ClinicController : ApiController
    {
        ICMDRepository db;
        public ClinicController(ICMDRepository repo)
        {
            this.db = repo;
        }

        public IHttpActionResult GetClinic(int id)
        {
            var clinic = db.GetClinic(id);
            if (clinic == null)
            {
                return NotFound();
            }
            return Ok(clinic);
        }

        public IHttpActionResult Post(Clinic clinic)
        {
            // validation
            if (!ModelState.IsValid)
                return BadRequest("Invalid input");
            db.CreateClinic(clinic);
            // location / status code 201 / resource
            return Created($"api/clinic/{clinic.ClinicId}", clinic);
        }

    }
}
