using AbsaBankMicroservice.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Domain.Repositories
{
    public interface IStudentAccountRepository
    {
        Task <bool> SaveStudentAsync(StudentAccount student);
    }
}
