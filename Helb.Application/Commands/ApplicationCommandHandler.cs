using HelbMicroService.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelbMicroService.Application.Commands
{
    public class ApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, Guid>


    {


        private readonly IApplicantService _applicantService;
        public ApplicationCommandHandler(IApplicantService applicantService)
        {
            _applicantService = applicantService?? throw new ArgumentNullException(nameof(applicantService));
                
        }
        public Task<Guid> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
			try
			{

                return _applicantService.CreateApplicantAsync(request);

            }
			catch (Exception)
			{

				throw;
			}
        }
    }
}
