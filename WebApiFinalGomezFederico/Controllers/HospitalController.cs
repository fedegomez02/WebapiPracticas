using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiFinalGomezFederico.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;

namespace WebApiFinalGomezFederico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly DbhospitalApiContext _context;

        public HospitalController(DbhospitalApiContext context)
        {
            this._context = context;
        }


        [HttpPost]
        public ActionResult Post([FromBody]Hospital hospital)
        {

            _context.hospital.Add(hospital);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public dynamic Get()
        {
            dynamic hospital = (from p in _context.hospital  select new { p.Nombre, p.Num_Cama, p.numeroTelefono });
            return hospital;
        }


        [HttpGet("{Num_cama}")]
        public dynamic Get(int Num_cama)
        {
            dynamic hospital = (from p in _context.hospital where p.Num_Cama > Num_cama select new {p.Nombre,p.Num_Cama,p.numeroTelefono });
            return hospital;
        }

    }
}
