using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarlosCuellarApi.Models;
using CarlosCuellarApi.Repositories;

namespace CarlosCuellarApi.Controllers
{
#pragma warning disable CS1591
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        protected readonly SampleContext _context;

        public StudentsController()
        {
            _context = new SampleContext();
        }
#pragma warning disable CS1591

        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public Student GetStudent(int id)
        {
            return _context.Students.Where(s => s.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public void AddStudent([FromBody] Student payload)
        {
            _context.Students.Add(payload);
        }

        [HttpPut]
        public void UpdateStudent([FromBody] Student payload)
        {
            _context.Students.Update(payload);
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteStudent(int id)
        {
            _context.Students.Remove(
                _context.Students.Where(s => s.Id == id).FirstOrDefault()
            );
        }
    }
}