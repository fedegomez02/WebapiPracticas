using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApiFinalGomezFederico.Models
{
    public class DbhospitalApiContext : DbContext
    {
        public DbhospitalApiContext(DbContextOptions<DbhospitalApiContext> options)
           : base(options) { }


        public DbSet<Hospital> hospital{ get; set; }

        public DbSet<Doctor> Doctor { get; set; }



    }
}
