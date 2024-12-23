using HotelApi.Data;

namespace HotelApi.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        AppDbContext Context { get; }
    }
}
