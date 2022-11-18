using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiFinalGomezFederico.Models;

namespace WebApiFinalGomezFederico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {

        private readonly DbhospitalApiContext _context;

        public MedicoController(DbhospitalApiContext context) {
            this._context = context;
        }

        [HttpGet]
        public List<Doctor> Get()
        {
            //EF
            List<Doctor> doctores = _context.Doctor.ToList();
            return doctores;


        }
        [HttpGet("{Doctor_NO}")]
        public Doctor Get(int Doctor_NO)
        {
            Doctor doctor = _context.Doctor.Find(Doctor_NO);
            return doctor;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Doctor doctor)
        {

            _context.Doctor.Add(doctor);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Doctor> Delete(int Doctor_NO)
        {
            Doctor doctor = _context.Doctor.Find(Doctor_NO);

            _context.Doctor.Remove(doctor);
            _context.SaveChanges();
            return doctor;
        }
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Doctor doctor, int id)
        {
            if (id != doctor.Doctor_NO)
            {
                BadRequest();
            }

            _context.Entry(doctor).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }
        [HttpGet("{Especialidad}")]
        public dynamic Get(string Especialidad)
        {
            dynamic hospital = (from p in _context.Doctor where p.Especialidad == Especialidad select new { p.Especialidad});
            return hospital;
        }
    




    }
}
