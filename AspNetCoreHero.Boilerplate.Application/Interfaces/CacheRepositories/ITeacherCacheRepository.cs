using AspNetCoreHero.Boilerplate.Domain.Entities.Catalog;
using AspNetCoreHero.Boilerplate.Domain.Entities.Learn;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreHero.Boilerplate.Application.Interfaces.CacheRepositories
{
    public interface ITeacherCacheRepository
    {
        Task<List<Teacher>> GetCachedListAsync();

        Task<Brand> GetByIdAsync(int teacherId);
    }
}