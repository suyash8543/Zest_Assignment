using System.Collections.Generic;
using System.Threading.Tasks;
using Suyash_Tripathi_Assignment.Models;

namespace Suyash_Tripathi_Assignment.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(int id);
        Task Add(Student student);
        Task Update(Student student);
        Task Delete(int id);
    }
}
