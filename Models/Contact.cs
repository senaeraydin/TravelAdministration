using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TourismTravelAdministration.Models
{
    public class Contact
    {
        public virtual int ContactID { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public virtual string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Please enter your email address")]
        public virtual string Email { get; set; }


        [Required(ErrorMessage = "Please enter your message")]
        public virtual string Message { get; set; }
    }
}