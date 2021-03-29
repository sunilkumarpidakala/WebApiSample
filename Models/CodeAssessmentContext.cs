using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CodeAssignment.Models
{
    public partial class CodeAssessmentContext : DbContext
    {
        

        public CodeAssessmentContext(DbContextOptions<CodeAssessmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Item> Items { get; set; }

        

      
    }
}
