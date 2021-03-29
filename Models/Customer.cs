using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CodeAssignment.Models
{
    [Table("Customer")]
    public partial class Customer
    {
     
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public string Email { get; set; }
        public long? PhoneNumber { get; set; }
        public DateTime? IsCreatedOn { get; set; }
        public DateTime? IsModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
