using System.Linq;
using BSEnterprises.Domain.Companies;
using BSEnterprises.Domain.Engineers;

namespace BSEnterprises.Persistence
{
    public interface IReadModelDatabase
    {
        IQueryable<Company> Companies { get; }
        IQueryable<Engineer> Engineers { get; }
    }
}