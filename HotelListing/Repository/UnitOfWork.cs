using HotelListing.Data;
using HotelListing.IRepository;
using System;
using System.Threading.Tasks;

namespace HotelListing.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepsotory<Country> _contries;
        private IGenericRepsotory<Hotel> _hotels;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;           
        }

        public IGenericRepsotory<Country> Countries => _contries ??= new GenericRepository<Country>(_context);

        public IGenericRepsotory<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
