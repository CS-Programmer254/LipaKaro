using HelbMicroService.Application.Commands;
using HelbMicroService.Domain.Entities;
using HelbMicroService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelbMicroService.Application.Services
{
    public class ApplicantService : IApplicantService
    {
        private readonly IApplicantRepository _applicantRepository;

        public ApplicantService(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository?? throw new ArgumentNullException(nameof(applicantRepository));
        }

        public Task<Guid> CreateApplicant(CreateApplicationCommand applicationCommand)
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> CreateApplicantAsync(CreateApplicationCommand applicationCommand)
        {
            try
            {
                var newApplicant = Applicant.AddNewApplicant(applicationCommand.applicantDetails.FirstName,
                    applicationCommand.applicantDetails.LastName,
                    applicationCommand.applicantDetails.Institution,
                    applicationCommand.applicantDetails.Course,
                    applicationCommand.applicantDetails.IsBothParentAlive,
                    applicationCommand.applicantDetails.Email,
                    applicationCommand.applicantDetails.IdNumber,
                    applicationCommand.applicantDetails.KraPin,
                    applicationCommand.applicantDetails.FirstName,
                    applicationCommand.applicantDetails.RegistrationNumber,
                    applicationCommand.applicantDetails.PhoneNumber
 
                );
                await _applicantRepository.SaveApplicantAsync(newApplicant);
                return newApplicant.Id;


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
