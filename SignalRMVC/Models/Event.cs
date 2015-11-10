using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRMVC.Models
{
    public class Event
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime? Time { get; set; }
    }
}