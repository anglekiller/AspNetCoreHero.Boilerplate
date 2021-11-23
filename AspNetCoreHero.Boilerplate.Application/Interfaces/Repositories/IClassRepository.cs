using AspNetCoreHero.Boilerplate.Domain.Entities.Catalog;
using AspNetCoreHero.Boilerplate.Domain.Entities.Learn;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreHero.Boilerplate.Application.Interfaces.Repositories
{
    public interface IClassRepository
    {
        IQueryable<Class> Classs { get; }

        Task<List<Class>> GetListAsync();

        Task<Class> GetByIdAsync(int ClassId);

        Task<int> InsertAsync(Class Class);

        Task UpdateAsync(Class Class);

        Task DeleteAsync(Class Class);
    }
}