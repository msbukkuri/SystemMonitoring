using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystemMonitoring.Repositories;
using SystemMonitoring.Models;

namespace SystemMonitoring.Features
{
    public class GetHandler
    {
        private readonly IRepository _repository;

        public GetHandler(IRepository repository)
        {
            _repository = repository;
        }

        public DashboardViewModel Execute(DashboardRequestModel requestModel)
        {
            return new DashboardViewModel()
            {
                Clients = _repository.GetAll()
            };
        }
    }

    public class DashboardViewModel
    {
        public IEnumerable<Client> Clients { get; set; }
        
        public DashboardViewModel()
        {
            Clients = new List<Client>();
        }
    }

    public class DashboardRequestModel {}
}