using System;
using System.Threading.Tasks;
using efconsole.Entity;

namespace efconsole.Services
{
    public interface IStorageTeacherService
    {
        Task<(bool IsSuccess, Exception exception)> InsertUserAsync(Teacher user);
        Task<(bool IsSuccess, Exception exception)> UpdateUserAsync(Teacher user);
        Task<bool> ExistsAsync(Guid id);
        Task<bool> ExistsAsync(string firstname);
        Task<(bool IsSuccess, Exception exception, Teacher user)> RemoveAsync(Teacher user);
        Task<Teacher> GetUserAsync(Guid id);
        Task<Teacher> GetUserAsync(string firstname);
    }
    public interface IStorageStudentService
    {
        Task<(bool IsSuccess, Exception exception)> InsertUserAsync(Student user);
        Task<(bool IsSuccess, Exception exception)> UpdateUserAsync(Student user);
        Task<bool> ExistsAsync(Guid id);
        Task<bool> ExistsAsync(string firstname);
        Task<(bool IsSuccess, Exception exception, Student user)> RemoveAsync(Student user);
        Task<Student> GetUserAsync(Guid id);
        Task<Student> GetUserAsync(string firstname);
    }
}