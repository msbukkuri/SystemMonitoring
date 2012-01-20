using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystemMonitoring.Models;

namespace SystemMonitoring.Repositories
{
    public interface IRepository
    {
        IEnumerable<Client> GetAll();
    }

    public class ClientRepository : IRepository
    {
        private readonly IList<Client> _clientList = new List<Client>();

        public ClientRepository()
        {
            _clientList.Add(new Client()
            {
                Alerts = new List<Alert>() 
                {
                    new Alert() 
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "This is Alert1",
                        Priority = 1
                    },
                    new Alert()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "This is Alert2",
                        Priority = 2
                    }, 
                    new Alert()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "This is Alert3",
                        Priority = 3
                    }
                },
                Id = Guid.NewGuid().ToString(),
                Name = "7-11"
            });
            _clientList.Add(new Client()
            {
                Alerts = new List<Alert>() 
                {
                    new Alert() 
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "This is Alert1",
                        Priority = 1
                    },
                    new Alert()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "This is Alert2",
                        Priority = 2
                    }, 
                    new Alert()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "This is Alert3",
                        Priority = 3
                    }
                },
                Id = Guid.NewGuid().ToString(),
                Name = "Barnes & Noble"
            });

            _clientList.Add(new Client()
            {
                Alerts = new List<Alert>() 
                {
                    new Alert() 
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "This is Alert1",
                        Priority = 1
                    },
                    new Alert()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "This is Alert2",
                        Priority = 2
                    }, 
                    new Alert()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "This is Alert3",
                        Priority = 3
                    }
                },
                Id = Guid.NewGuid().ToString(),
                Name = "Steinmart"
            });
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientList;
        }

    }
}