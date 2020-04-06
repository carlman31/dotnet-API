using System;
using System.Collections.Generic;
using System.Linq;
using CarlosCuellarApi.Models;

namespace CarlosCuellarApi.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly SampleContext _context;

        public StudentsRepository(SampleContext context)
        {
            _context = context;
        }

        public IEnumerable<Models.Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public void InsertStudent(Student student)
        {
            _context.Students.Add(student);
        }

        public Student GetStudent(int id)
        {
            return _context.Students.Where(x => x.Id == id).FirstOrDefault();
        }

        public void DeleteStudent(int id)
        {
            _context.Remove(_context.Students.Where(x => x.Id == id).FirstOrDefault());
        }

        public void UpdateStudent(Student student)
        {
            Student rs = _context.Students.Where(x => x.Id == student.Id).FirstOrDefault();

            if (rs != null)
            {
                rs.Age = student.Age;
                rs.Career = student.Career;
                rs.Firstname = student.Firstname;
                rs.Lastname = student.Lastname;
                rs.Username = student.Username;

                _context.Students.Update(rs);

                _context.SaveChanges();
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
