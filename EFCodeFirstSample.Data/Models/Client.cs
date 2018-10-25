using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DATA.Models
{
    public class Client
    {
        public long ClientID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }

        public DateTime DateTimeStamp { get; } = DateTime.Now;

        public bool Cancelled { get; set; } = false;

       
    }
}