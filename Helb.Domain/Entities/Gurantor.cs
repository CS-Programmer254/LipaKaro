using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelbMicroService.Domain.Entities
{
   public class Gurantor
    {



        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public string PhoneNumber{ get; set; }

        public string Email { get; set; }
        public string KraPin { get; set; }



        public Gurantor(string firstName, string lastName, string idNumber, string phoneNumber, string email, string kraPin)
        { 


            FirstName = firstName;
            LastName = lastName;
            IdNumber = idNumber;
            PhoneNumber = phoneNumber;
            Email = email;
            KraPin = kraPin;

        
        
        
        
        
        }


        public static Gurantor AddNewGurantor(string firstName, string lastName, string idNumber, string phoneNumber, string email, string kraPin) 
        {


            return new Gurantor(firstName, lastName, idNumber, phoneNumber, email, kraPin);
        }
    }
}
