using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TourismTravelAdministration.Models
{
    public class Payment
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string CardOwnerName { get; set; }

        [Required(ErrorMessage = "Please enter your card number")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Please enter exp date")]
        public string ExpDate { get; set; }

        [Required(ErrorMessage = "Please enter security code")]
        public string SecurityCode { get; set; }
    }
}