using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelbMicroService.Application.Dtos
{
    public record ApplicantDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Institution { get; set; }
        public string Course { get; set; }

        public bool IsBothParentAlive { get; set; }
        public string Email { get; set; }
        public string IdNumber { get; set; }

        public string KraPin { get; set; }
        public string RegistrationNumber { get; set; }
        public required string PhoneNumber { get; set; }



    }
}
