
using Application.Interfaces;

namespace Application.Services
{
    public abstract class BaseService
    {
        public IUnitOfWork UnitOfWork { get; private set; }
        public BaseService(IUnitOfWork uow)
        {
            UnitOfWork = uow;
        }
    }
}
