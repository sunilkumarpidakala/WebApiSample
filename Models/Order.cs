using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CodeAssignment.Models
{
    [Table("Orders")]
    public partial class Order
    {
        [Key]
        public int Id { get; set; }

        public int? UserId { get; set; }
        public int? ItemId { get; set; }
        
        public bool? IsActive { get; set; }
        public DateTime? IsCreatedOn { get; set; }
        public DateTime? IsModifiedOn { get; set; }

        public virtual Item Product { get; set; }
        public virtual Customer User { get; set; }
    }
}
