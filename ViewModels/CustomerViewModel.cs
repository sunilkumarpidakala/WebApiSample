using System;
using System.ComponentModel.DataAnnotations;

namespace CodeAssignment.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^[a-zA-Z0-9_\.-]+@([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter a valid EmailId.")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number is required.")]
        public long? PhoneNumber { get; set; }
        public DateTime? IsCreatedOn { get; set; }
        public DateTime? IsModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
