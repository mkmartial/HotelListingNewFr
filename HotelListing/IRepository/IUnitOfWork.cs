using HotelListing.Data;
using System;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepsotory<Country> Countries { get; }
        IGenericRepsotory<Hotel> Hotels { get; }
        Task Save();
    }
}
