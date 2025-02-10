
namespace Valhalla.Domain.Entities.Application.Repository.Application;
public interface IApplicationRepository
{
    Task<Entities.Application.Application> GetApplicationByIdAsync(int applicationId);
    Task<List<Entities.Application.Application>> GetAllApplicationsAsync();
   public Task<int> CreateApplicationAsync(Entities.Application.Application application);
}
