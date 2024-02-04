using AbsaBankMicroservice.Domain.Entities;
using AbsaBankMicroservice.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Infrastructure.Persistence
{
    public class StudentAccountRepository : IStudentAccountRepository
    {
        private readonly AbsaBankDbContext _dbContext;
        public StudentAccountRepository(AbsaBankDbContext absaBankDbContext)
        {
            _dbContext = absaBankDbContext?? throw new ArgumentNullException(nameof(absaBankDbContext));
            
        }

       public async Task<bool>SaveStudentAccountAsync(StudentAccount student)
        {
            try
            {
                await _dbContext.StudentAccounts.AddAsync(student);
                await _dbContext.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
