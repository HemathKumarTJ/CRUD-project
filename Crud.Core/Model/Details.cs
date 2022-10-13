using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Core.Model
{
    public  class Details
    {
        public int id { get; set; }
        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        
        public string Course { get; set; }
        
        public string Gender { get; set; }
     
        public string Phone { get; set; }
       
        public string Address { get; set; }
      
        public string Email { get; set; }
       
        public string Password { get; set; }
       
        public string ReTypePassword { get; set; }

        
    }
}
