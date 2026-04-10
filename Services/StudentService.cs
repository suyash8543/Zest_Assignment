using System.Collections.Generic;
using System.Threading.Tasks;
using Suyash_Tripathi_Assignment.Models;
using Suyash_Tripathi_Assignment.Repositories;

namespace Suyash_Tripathi_Assignment.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public Task<IEnumerable<Student>> GetAll() => _repo.GetAll();
        public Task<Student> GetById(int id) => _repo.GetById(id);
        public Task Add(Student student) => _repo.Add(student);
        public Task Update(Student student) => _repo.Update(student);
        public Task Delete(int id) => _repo.Delete(id);
    }
}
