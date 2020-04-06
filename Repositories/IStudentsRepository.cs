using System;
using System.Collections.Generic;
using CarlosCuellarApi.Models;

namespace CarlosCuellarApi.Repositories
{
    internal interface IStudentsRepository : IDisposable
    {
        IEnumerable<Models.Student> GetStudents();

        void InsertStudent(Models.Student student);

        Models.Student GetStudent(int id);

        void DeleteStudent(int id);

        void UpdateStudent(Models.Student student);

        void Save();
    }
}
