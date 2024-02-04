using HelbMicroService.Domain.Entities;
using HelbMicroService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelbMicroService.Infastracture.Persistence
{
    public class ApplicantRepository : IApplicantRepository
    {

        private readonly HelbContext _helbContext;
        public ApplicantRepository(HelbContext helbContext)
        {
            _helbContext = helbContext ?? throw new ArgumentNullException(nameof(helbContext));
                
        }

       

        public async Task<bool> SaveApplicantAsync(Applicant applicant)
        {
            try
            {
                await _helbContext.ApplicantDetails.AddAsync(applicant);
              
                
                await  _helbContext.SaveChangesAsync();
                return true;
                

            }
            catch (Exception)
            {
                return false;

                throw;
            }
        }
    }
}
