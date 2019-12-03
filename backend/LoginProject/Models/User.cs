using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.UI;

namespace LoginProject.Models
{
    public  class User 
    {
        [Key]
        public int userId { get; set; }

        public string userName { get; set; }

        public string userPassword { get; set; }

        public string userEmail { get; set; }

        [NotMapped]
        public string userNewPassword { get; set; }

        

    }
}