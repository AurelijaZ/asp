using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Invitation.Models
{
    public class Class1
    {
        
        [Required (ErrorMessage = "Please enter your name")]
        public string Name { get; set;  }
        [Required(ErrorMessage = "Please enter your email adress")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email adress")]
        public string Email { get; set;  }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set;  }
        [Required(ErrorMessage = "Please say whether you will attend")]
        public bool? WillAttend { get; set;  } 
       
    }
}