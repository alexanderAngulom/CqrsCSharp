using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Valhalla.Domain.Entities.Application.Repository.Application;

namespace Valhalla.Infrastructure.EntityFramework.Implements.Repository.Application
{
    public class ApplicationRepository : IApplicationRepository
    {
        private static readonly List<Domain.Entities.Application.Application> _applications = [];

        public Task<int> CreateApplicationAsync(Domain.Entities.Application.Application application)
        {
            var newApp = new Domain.Entities.Application.Application
            {
                Id = _applications.Count + 1,
                Name = application.Name,
                Description = application.Description,
                Secret = application.Secret
            };

            _applications.Add(newApp);
            return Task.FromResult(newApp.Id);
        }

        public Task<List<Domain.Entities.Application.Application>> GetAllApplicationsAsync()
        {

            return Task.FromResult(_applications);
        }

        public Task<Domain.Entities.Application.Application?> GetApplicationByIdAsync(int applicationId)
        {
            var application = _applications.FirstOrDefault(x => x.Id == applicationId);
            return Task.FromResult(application);
        }
    }
}
