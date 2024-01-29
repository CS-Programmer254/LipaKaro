using AbsaBankMicroservice.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Application.Services
{
    public class StudentAccountService:IStudentAccountService
    {
        private readonly IStudentAccountService _studentAccountService;
        public StudentAccountService(IStudentAccountService studentAccountService) {
            _studentAccountService = studentAccountService??
                throw new ArgumentNullException(nameof(studentAccountService));
        }

       public async Task<Guid> CreateStudentAccountAsync(CreateStudentAccountCommand createStudentAccountCommand )
        {
            throw new NotImplementedException();
        }

      
    }
}
