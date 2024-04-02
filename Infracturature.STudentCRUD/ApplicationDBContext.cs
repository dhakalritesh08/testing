using Domain.StudentCRUD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infracturature.STudentCRUD
{
    public class ApplicationDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP - EJIH7BA; Database = NetApiTesting; Trusted_Connection = True; TrustServerCertificate = True; MultipleActiveResultSets = True");
        }
        public DbSet<Student> Student { get; set; }
       
      
    }
}
