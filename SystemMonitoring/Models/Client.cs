using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemMonitoring.Models
{
    public class Client
    {
        private readonly string _id;
        private readonly string _name;
        private readonly List<Alert> _alerts;

        public string Id { get; set; }
        public string Name { get; set; }
        public List<Alert> Alerts { get; set; }
    }
}