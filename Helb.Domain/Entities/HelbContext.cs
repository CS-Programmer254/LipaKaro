using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelbMicroService.Domain.Entities
{
  public class HelbContext:DbContext
    {
        public DbSet <Applicant> ApplicantDetails { get; set; }
        public DbSet <Gurantor> GurantorDetails { get; set; }


       

        public HelbContext(DbContextOptions<HelbContext> options) : base(options)
        { 
        
        
        
        
        }
    }
}
