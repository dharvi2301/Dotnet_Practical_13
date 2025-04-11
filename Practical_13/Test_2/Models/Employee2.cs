using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test_2.Models
{
	public class Employee2
	{
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Middle name cannot exceed 50 characters")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [StringLength(10, ErrorMessage = "Mobile number must be 10 digits", MinimumLength = 10)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Mobile number must contain only digits")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [StringLength(100, ErrorMessage = "Address cannot exceed 100 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive number")]
        public decimal Salary { get; set; }

        [Display(Name = "Designation")]
        public int? DesignationId { get; set; }

        [ForeignKey("DesignationId")]
        public virtual Designation Designation { get; set; }
    }

}