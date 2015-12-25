using System;
using System.ComponentModel.DataAnnotations;

namespace HomeServices.Models
{
    public class EmployeeMetadata
    {
        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Individual Identification Number")]
        public string IdentificationNumber { get; set; }

        public string County { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public Nullable<int> Number { get; set; }

        [Required]
        [StringLength(1, ErrorMessage = "The gender must be either M of F")]
        [RegularExpression(@"M|m|f|F", ErrorMessage = "The gender must be either M of F")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public System.DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Date of Hire")]
        [DataType(DataType.Date)]
        public System.DateTime DateOfHire { get; set; }

        [Required]
        [Range(0, Double.MaxValue, ErrorMessage = "Invalid Salary")]
        public decimal Salary { get; set; }
    }

    public class DepartmentMetadata
    {
        [Required]
        [Display(Name = "Department Name")]
        public string Name { get; set; }
    }
}