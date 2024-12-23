using HotelApi.Data;
using HotelApi.Repositories.Interfaces;

namespace HotelApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public AppDbContext Context { get; }

        public UnitOfWork(AppDbContext context)
        {
            Context = context;
        }
    }
}
