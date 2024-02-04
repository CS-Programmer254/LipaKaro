using HelbMicroService.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelbMicroService.Application.Services
{
   public interface IApplicantService
    {
        Task<Guid> CreateApplicant(CreateApplicationCommand applicationCommand);
        Task<Guid> CreateApplicantAsync(CreateApplicationCommand request);

    }
}
