using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationAnnotations
{

    class Program
    {

        public static void Execute()
        {
            Employee employee = new Employee();

            employee.firstName = "Prathamesh";
            employee.lastName = "Rajput";
            employee.phoneNumber = "112345678";
            employee.emailAddress = "abc@gmail.com";
            employee.password = "Abc12345*";

            ValidationContext validationContext = new ValidationContext(employee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(employee, validationContext, results, true);

            if (!valid)
            {
                foreach (ValidationResult res in results)
                {
                    Console.WriteLine("Method name : " + res.MemberNames.First());
                    Console.WriteLine("Error name : " + res.ErrorMessage);
                }
            }
            else
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.phoneNumber + " " + employee.emailAddress);
        }

        public static void Main(String[] args)
        {
            Execute();
            Console.Read();
        }
    }
}


