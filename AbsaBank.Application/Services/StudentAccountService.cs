using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Application.Services
{
    public class StudentAccountService:IStudentAccountService
    {
        public StudentAccountService() { }

        Task<Guid> IStudentAccountService.CreateStudentAccountAsync()
        {
            throw new NotImplementedException();
        }
    }
}
