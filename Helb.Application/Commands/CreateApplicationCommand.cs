using HelbMicroService.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelbMicroService.Application.Commands
{
    public  class CreateApplicationCommand : IRequest<Guid>
    {

        public required ApplicantDto applicantDetails { get; set; }
    }
}
