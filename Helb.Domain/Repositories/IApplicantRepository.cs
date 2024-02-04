using HelbMicroService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelbMicroService.Domain.Repositories
{
   public  interface IApplicantRepository
    {
        Task<bool> SaveApplicantAsync(Applicant applicant);
    }
}
