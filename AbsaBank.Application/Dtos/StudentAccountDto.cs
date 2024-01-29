﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Application.Dtos
{
    public class StudentAccountDto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AdmissionNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalIDNumber { get; set; }
        public string KraPin { get; set; }
        public string Cif { get; set; }
        public Guid CustomerStatus { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
