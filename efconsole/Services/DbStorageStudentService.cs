using System;
using System.Threading.Tasks;
using efconsole.Data;
using efconsole.Entity;
using Microsoft.EntityFrameworkCore;

namespace efconsole.Services
{
    public class DbStorageStudentService : IStorageStudentService
    {
        private readonly ConsoleDbContext _context;

        public DbStorageStudentService(ConsoleDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ExistsAsync(Guid id)
                => await _context.Students.AnyAsync(u => u.Id == id);

        public async Task<bool> ExistsAsync(string firstname)
                => await _context.Students.AnyAsync(u => u.Firstname == firstname);
        public async Task<Student> GetUserAsync(Guid id)
                => await _context.Students.FirstOrDefaultAsync(u => u.Id == id);

        public async Task<Student> GetUserAsync(string firstname)
                => await _context.Students.FirstOrDefaultAsync(u => u.Firstname == firstname);

        public async Task<(bool IsSuccess, Exception exception)> InsertUserAsync(Student user)
        {
            try
            {
                if (!await ExistsAsync(user.Id))
                {
                    await _context.Students.AddAsync(user);
                    await _context.SaveChangesAsync();
                    return (true, null);
                }
                return (false, null);
            }
            catch (Exception e)
            {
                return (false, e);
            }
        }

        public async Task<(bool IsSuccess, Exception exception, Student user)> RemoveAsync(Student user)
        {
            try
            {
                _context.Students.Remove(user);
                await _context.SaveChangesAsync();
                return (true, null, user);
            }
            catch (Exception e)
            {
                return (false, e, null);
            }
        }

        public async Task<(bool IsSuccess, Exception exception)> UpdateUserAsync(Student user)
        {
            try
            {
                var savedUser = await GetUserAsync(user.Id);
                _context.Remove(savedUser);
                await _context.SaveChangesAsync();
                await _context.Students.AddAsync(user);
                await _context.SaveChangesAsync();

                return (true, null);
            }
            catch (Exception e)
            {
                return (false, e);
            }
        }
    }
}