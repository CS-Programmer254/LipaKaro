using AbsaBankMicroservice.Domain.Repositories;
using Alerts.Microservice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaMicroservice.Infrastructure.Persistence
{
    public class AlertsRepository:IAlertsRepository
    {
        private readonly AlertsDbContext _alertsDbContext;
        public AlertsRepository(AlertsDbContext alertsDbContext) {
        
            _alertsDbContext = alertsDbContext ?? throw new ArgumentNullException(nameof(alertsDbContext));
        }

        public async Task<bool> SaveAlertsAsync(Email email)
        {
            try
            {
                await _alertsDbContext.Emails.AddAsync(email);
                await _alertsDbContext.SaveChangesAsync();
                return true;
                

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
