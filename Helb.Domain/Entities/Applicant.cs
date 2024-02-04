using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelbMicroService.Domain.Entities
{
    public class Applicant


    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Institution { get; set; }
        public string Course { get; set; }

        public bool IsBothParentAlive { get; set; }


        public string Email { get; set; }
        public string IdNumber { get; set; }

        public string KraPin { get; set; }
        public string RegistrationNumber { get; set; }
        public string PhoneNumber { get; set; }

        public Applicant(string firstName, string lastName,string institution, string course, bool isBothParentAlive, string email, string idNumber,string kraPin,string registrationNumber, string phoneNumber)
        {
             
            FirstName = firstName;
            LastName = lastName;
            Institution = institution;
            Course = course;
            IsBothParentAlive = isBothParentAlive;
            Email = email;
            IdNumber = idNumber;
            KraPin = kraPin;
            RegistrationNumber = registrationNumber;
            PhoneNumber = phoneNumber;

           
          

        }
        //public Applicant() { }


        public static Applicant AddNewApplicant(string firstName, string lastName, string institution, string course, bool isBothParentAlive, string email, string idNumber, string kraPin, string registrationNumber, string phoneNumber, string phoneNumber1) 
        {

            return new Applicant(firstName, lastName, institution, course, isBothParentAlive, email, idNumber, kraPin, registrationNumber, phoneNumber);
        
        
        }

        

        
    }
}
