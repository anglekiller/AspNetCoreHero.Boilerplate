using AspNetCoreHero.Boilerplate.Domain.Entities.Catalog;
using AspNetCoreHero.Boilerplate.Domain.Entities.Learn;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreHero.Boilerplate.Application.Interfaces.Repositories
{
    public interface ITeacherRepository
    {
        IQueryable<Teacher> Teachers { get; }

        Task<List<Teacher>> GetListAsync();

        Task<Teacher> GetByIdAsync(int TeacherId);

        Task<int> InsertAsync(Teacher Teacher);

        Task UpdateAsync(Teacher Teacher);

        Task DeleteAsync(Teacher Teacher);
    }
}