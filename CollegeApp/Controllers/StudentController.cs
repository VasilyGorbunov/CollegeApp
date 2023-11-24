using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudentName()
        {
            return CollegeRepository.Students;
        }

        [HttpGet("{id:int}")]
        public Student GetStudentById(int id)
        {
            return CollegeRepository.Students.FirstOrDefault(n => n.Id == id);
        }
    }
}
