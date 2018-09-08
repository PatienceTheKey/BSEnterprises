using System.Linq;
using BSEnterprises.Domain.Companies;
using BSEnterprises.Domain.Engineers;
using Microsoft.EntityFrameworkCore;

namespace BSEnterprises.Persistence
{
    public class ReadModelDatabase : IReadModelDatabase
    {
        private readonly ApplicationDbContext _context;
        public ReadModelDatabase(ApplicationDbContext context)
        {
            _context = context;

        }
        public IQueryable<Company> Companies => _context.Companies.AsNoTracking();

        public IQueryable<Engineer> Engineers => _context.Engineers.AsNoTracking();

        
    }
}