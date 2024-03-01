﻿using CollegeApp.Models;
using Microsoft.AspNetCore.Http;
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
        [Route("{id:int}", Name = "GetStudentById")]
        public Student GetStudentById(int id)
        {
            return CollegeRepository
                    .Students
                    .Where(n => n.Id == id)
                    .FirstOrDefault();
        }

        [HttpGet("{name:alpha}", Name = "GetStudentByName")]
        public Student GetStudentByName(string name)
        {
            return CollegeRepository
                .Students
                .Where(n => n.StudentName == name)
                .FirstOrDefault();
        }

        [HttpDelete("{id}", Name = "DeleteStudentById")]
        public bool DeleteStudent(int id)
        {
            var student = CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
            CollegeRepository.Students.Remove(student);
            return true;
        }
    }
}
