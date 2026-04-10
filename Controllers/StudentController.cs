using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Suyash_Tripathi_Assignment.Models;
using Suyash_Tripathi_Assignment.Services;

namespace Suyash_Tripathi_Assignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAll());

        [HttpPost]
        public async Task<IActionResult> Add(Student student)
        {
            await _service.Add(student);
            return Ok(student);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Student student)
        {
            await _service.Update(student);
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
