
using Application.Interfaces;

namespace Application.Services
{
    public abstract class BaseService
    {
        public IRepositories Repos { get; private set; }
        public BaseService(IRepositories repos)
        {
            Repos = repos;
        }
    }
}
