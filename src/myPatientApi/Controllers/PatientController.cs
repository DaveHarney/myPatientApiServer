using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myPatientApi.Models;

namespace myPatientApi.Controllers
{
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        Patient[] patients = new Patient[]
        {
            new Patient
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                SocialSecurityNumber = "123550001"
            },
            new Patient
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                SocialSecurityNumber = "123550002"
            },
            new Patient
            {
                Id = 3,
                FirstName = "Lisa",
                LastName = "Smith",
                SocialSecurityNumber = "123550003"
             }
            };

        // GET: api/patient
        public IEnumerable<Patient> Get()
        {
            return patients;
        }
        // GET api/patient/5
        [HttpGet("{id}")]
        public Patient Get(int id)
        {
            var patient = patients.FirstOrDefault((p) => p.Id == id);
            if (patient == null)
            {
                return null;
            }
            return patient;
        } 
    }
}
