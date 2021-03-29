using CodeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAssignment.ViewModels
{
    public class OrderViewModel
    {
        public string Email { get; set; }
        public  List<ItemList> Item { get; set; }
    }
}
