using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemMonitoring.Models
{
    public class Alert
    {
        private readonly string _id;
        private readonly int _priority;
        private readonly string _message;

        public String Id { get; set; }
        public int Priority { get; set; }
        public String Message { get; set; }

    }
}