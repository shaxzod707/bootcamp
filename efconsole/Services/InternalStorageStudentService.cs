using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efconsole.Entity;
using Microsoft.Extensions.Logging;

namespace efconsole.Services
{
    public class InternalStorageStudentService : IStorageStudentService
    {
        private readonly List<Student> _student;
        private IStorageStudentService _storage;
        private readonly ILogger<InternalStorageStudentService> _logger;
        public InternalStorageStudentService(ILogger<InternalStorageStudentService> logger)
        {
            _student = new List<Student>();
            _logger = logger;
        }

        public Task<bool> ExistsAsync(Guid id)
                => Task.FromResult<bool>(_student.Any(u => u.Id == id));

        public Task<bool> ExistsAsync(string firstname)
                => Task.FromResult<bool>(_student.Any(u => u.Firstname == firstname));

        public Task<Student> GetUserAsync(Guid id)
                => Task.FromResult<Student>(_student.FirstOrDefault(u => u.Id == id));

        public Task<Student> GetUserAsync(string firstname)
                => Task.FromResult<Student>(_student.FirstOrDefault(u => u.Firstname == firstname));

        public async Task<(bool IsSuccess, Exception exception)> InsertUserAsync(Student user)
        {
            if (await ExistsAsync(user.Id))
            {
                return (false, new Exception("Student already exists!"));
            }
            _student.Add(user);
            return (true, null);
        }

        public async Task<(bool IsSuccess, Exception exception, Student user)> RemoveAsync(Student user)
        {
            if (await ExistsAsync(user.Id))
            {
                var savedTeacher = await GetUserAsync(user.Id);
                _student.Remove(savedTeacher);
                return (true, null, savedTeacher);
            }
            return (false, new Exception("Student does not exist!"), null);
        }

        public async Task<(bool IsSuccess, Exception exception)> UpdateUserAsync(Student user)
        {
            if (await ExistsAsync(user.Id))
            {
                var savedTeacher = await GetUserAsync(user.Id);
                _student.Remove(savedTeacher);
                _student.Add(user);

                return (true, null);
            }

            return (false, new Exception("User does not exist!"));
        } 
    }       
}