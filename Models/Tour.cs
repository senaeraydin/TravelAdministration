using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourismTravelAdministration.Models
{
    public class Tour
    {
        public int ID { get; set; }

        public String TourName { get; set; }

        public String Description { get; set; }

        public String TourDate { get; set; }

        public float TourPrice { get; set; }

        public String TImage { get; set; }

        public bool TAvailable { get; set; }

        public String TourCategory { get; set; }

        public String TotalDay { get; set; }
    }
}