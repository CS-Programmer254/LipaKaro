using AbsaBankMicroservice.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Application.Commands
{
    public class CreateStudentAccountCommandHandler:IRequestHandler<CreateStudentAccountCommand,Guid>
    {
        private readonly IStudentAccountService _studentAccountService;
        public CreateStudentAccountCommandHandler(IStudentAccountService studentAccountService)
        {
            _studentAccountService=studentAccountService;
        }

        Task<Guid> IRequestHandler<CreateStudentAccountCommand, Guid>.Handle(CreateStudentAccountCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return _studentAccountService.CreateStudentAccountAsync(request);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
