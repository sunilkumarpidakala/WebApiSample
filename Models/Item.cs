using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CodeAssignment.Models
{
    [Table("Item")]
    public partial class Item
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool? IsActive { get; set; }

       
    }
}
