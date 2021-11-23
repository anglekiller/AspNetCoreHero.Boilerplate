using AspNetCoreHero.Boilerplate.Domain.Entities.Catalog;
using AspNetCoreHero.Boilerplate.Domain.Entities.Learn;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreHero.Boilerplate.Application.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        IQueryable<Student> Students { get; }

        Task<List<Student>> GetListAsync();

        Task<Student> GetByIdAsync(int StudentId);

        Task<int> InsertAsync(Student Student);

        Task UpdateAsync(Student Student);

        Task DeleteAsync(Student Student);
    }
}