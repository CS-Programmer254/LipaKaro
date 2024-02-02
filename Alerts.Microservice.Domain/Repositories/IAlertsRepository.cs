using Alerts.Microservice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Domain.Repositories
{
    public interface IAlertsRepository
    {
        Task<bool> SaveAlertsAsync(Email email);
    }
}
