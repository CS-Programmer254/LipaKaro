﻿using AbsaBankMicroservice.Application.Commands;
using AbsaBankMicroservice.Domain.Entities;
using AbsaBankMicroservice.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Application.Services
{
    public class StudentAccountService:IStudentAccountService
    {
        private readonly IStudentAccountRepository _studentAccountRepository;
        public StudentAccountService(IStudentAccountRepository studentRepository) {

            _studentAccountRepository = studentRepository;
        
        }

       public async Task<Guid> CreateStudentAccountAsync(CreateStudentAccountCommand studentAccountCommand )
        {
            try
            {
      
                var newStudentAccount = StudentAccount.
                    AddNewStudentAccount(
                    studentAccountCommand.StudentAccountDetails.FirstName,
                    studentAccountCommand.StudentAccountDetails.MiddleName,
                    studentAccountCommand.StudentAccountDetails.LastName,
                    studentAccountCommand.StudentAccountDetails.AdmissionNumber,
                    studentAccountCommand.StudentAccountDetails.Email,
                    studentAccountCommand.StudentAccountDetails.PhoneNumber,
                    studentAccountCommand.StudentAccountDetails.NationalIDNumber,
                    studentAccountCommand.StudentAccountDetails.KraPin,
                    studentAccountCommand.StudentAccountDetails.Cif,
                    studentAccountCommand.StudentAccountDetails.CustomerStatus, 
                    studentAccountCommand.StudentAccountDetails.DateOfBirth
                    );
                await _studentAccountRepository.SaveStudentAccountAsync( newStudentAccount );
                return newStudentAccount.StudentId;

            }
            catch (Exception)
            {

                throw;
            }
            
        }

      
    }
}
