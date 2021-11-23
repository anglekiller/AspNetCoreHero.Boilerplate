using AspNetCoreHero.Boilerplate.Domain.Entities.Catalog;
using AspNetCoreHero.Boilerplate.Domain.Entities.Learn;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreHero.Boilerplate.Application.Interfaces.CacheRepositories
{
    public interface IClassCacheRepository
    {
        Task<List<Class>> GetCachedListAsync();

        Task<Brand> GetByIdAsync(int classId);
    }
}