using AbsaBankMicroservice.Domian.Entities;
using AbsaBankMicroservice.Domian.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Infrastructure.Persistence
{
    public class StudentAccountRepository : IStudentAccountRepository
    {
        private readonly
        
        Task<bool>SaveStudentAsync(StudentAccount student)
        {
            throw new NotImplementedException();
        }
    }
}
