using AbsaBankMicroservice.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Application.Commands
{
    public  class CreateStudentAccountCommand:IRequest<Guid>
    {
        public StudentAccountDto StudentAccountDetails { get; set; }
    }
}
