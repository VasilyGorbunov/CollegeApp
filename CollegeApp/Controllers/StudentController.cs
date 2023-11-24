using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All", Name = "GetAllStudents")]
        public IEnumerable<Student> GetStudentName()
        {
            return CollegeRepository.Students;
        }

        [HttpGet]
        [Route("{id}", Name = "GetAllStudentById")]
        public Student GetStudentById(int id)
        {
            return CollegeRepository.Students.FirstOrDefault(n => n.Id == id);
        }

        [HttpGet("{name}", Name = "GetAllStudentByName")]
        public Student GetStudentByName(string name)
        {
            return CollegeRepository.Students.FirstOrDefault(n => n.StudentName == name);
        }

        [HttpDelete("{id}", Name = "DeleteStudentById")]
        public bool DeleteStudent(int id)
        {
            var student = CollegeRepository.Students.FirstOrDefault(n => n.Id == id);
            CollegeRepository.Students.Remove(student);
            return true;
        }
    }
}
