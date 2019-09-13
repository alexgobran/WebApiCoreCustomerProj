using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreCustomerProj.Models {
    public class Customer {

        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string  Name { get; set; }
        public double Sales { get; set; }
        public bool Active { get; set; }


        //ctor and tab 2x to get delfault constructor, always need a default constructor even if its empty
        public Customer() {

        }
    }
}
