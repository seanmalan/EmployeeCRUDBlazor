using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUDBlazor.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string LastName { get; set; }

        public string Fullname => $"{FirstName} {MiddleName} {LastName}";

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Designation { get; set; }
    }
}
