using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efconsole.Entity;
using Microsoft.Extensions.Logging;

namespace efconsole.Services
{
    public class InternalStorageTeacherService : IStorageTeacherService
    {
        private readonly List<Teacher> _teacher;
        private IStorageTeacherService _storage;
        private readonly ILogger<InternalStorageTeacherService> _logger;

        public InternalStorageTeacherService(ILogger<InternalStorageTeacherService> logger)
        {
            _teacher = new List<Teacher>();
            _logger = logger;
        }

        public Task<bool> ExistsAsync(Guid id)
                => Task.FromResult<bool>(_teacher.Any(u => u.Id == id));

        public Task<bool> ExistsAsync(string firstname)
                => Task.FromResult<bool>(_teacher.Any(u => u.Firstname == firstname));
        public Task<Teacher> GetUserAsync(Guid id)
                => Task.FromResult<Teacher>(_teacher.FirstOrDefault(u => u.Id == id));
        public Task<Teacher> GetUserAsync(string firstname)
                => Task.FromResult<Teacher>(_teacher.FirstOrDefault(u => u.Firstname == firstname));


        public async Task<(bool IsSuccess, Exception exception)> InsertUserAsync(Teacher user)
        {
            if (await ExistsAsync(user.Id))
            {
                return (false, new Exception("Teacher already exists!"));
            }
            _teacher.Add(user);
            return (true, null);
        }

        public async Task<(bool IsSuccess, Exception exception, Teacher user)> RemoveAsync(Teacher user)
        {
            if (await ExistsAsync(user.Id))
            {
                var savedTeacher = await GetUserAsync(user.Id);
                _teacher.Remove(savedTeacher);
                return (true, null, savedTeacher);
            }
            return (false, new Exception("Teacher does not exist!"), null);
        }

        public async Task<(bool IsSuccess, Exception exception)> UpdateUserAsync(Teacher user)
        {

            if (await ExistsAsync(user.Id))
            {
                var savedTeacher = await GetUserAsync(user.Id);
                _teacher.Remove(savedTeacher);
                _teacher.Add(user);

                return (true, null);
            }

            return (false, new Exception("User does not exist!"));
        }
    }
}