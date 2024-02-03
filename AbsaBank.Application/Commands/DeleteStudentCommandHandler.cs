﻿using AbsaBankMicroservice.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Application.Commands
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentAccountCommand, Guid>
    {
        private readonly IStudentAccountService _studentAccountService;
        public DeleteStudentCommandHandler(IStudentAccountService studentAccountService)
        {
            _studentAccountService = studentAccountService;
            
        }
        async Task<Guid> IRequestHandler<DeleteStudentAccountCommand, Guid>.Handle(DeleteStudentAccountCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return await _studentAccountService.DeleteStudentAccountAsync(request);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
