using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Application.Services
{
    public interface IStudentAccountService
    {

       Task<Gud> CreateStudentAccountAsync();
    }

}
