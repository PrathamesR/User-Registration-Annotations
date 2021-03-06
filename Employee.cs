﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationAnnotations
{
    class Employee
    {

        [RegularExpression("^[A-Za-z]+$",ErrorMessage ="Only Letters can be present in name")]
        public string firstName { get; set; }


        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Only Letters can be present in name")]
        public string lastName { get; set; }


        [DataType(DataType.PhoneNumber, ErrorMessage = "Check your Phone Number")]
        [Phone]
        public string phoneNumber { get; set; }

        
        [RegularExpression(@"^(^(?=.{8,}$))(?=.*[A-Z])(?=.*[0-9])(^[a-zA-Z0-9]*[!@#$^&*()\-+=]{1}[a-zA-Z0-9]*$)",ErrorMessage ="Invalid Password")]
        public string password { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string emailAddress { get; set; }
    }
}
