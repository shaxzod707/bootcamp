using System;
using System.Threading.Tasks;
using efconsole.Data;
using efconsole.Entity;
using Microsoft.EntityFrameworkCore;

namespace efconsole.Services
{
    public class DbStorageTeacherService : IStorageTeacherService
    {
        private readonly ConsoleDbContext _context;

        public DbStorageTeacherService(ConsoleDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ExistsAsync(Guid id)
                => await _context.Teachers.AnyAsync(u => u.Id == id);

        public async Task<bool> ExistsAsync(string firstname)
                => await _context.Teachers.AnyAsync(u => u.Firstname == firstname);
        public async Task<Teacher> GetUserAsync(Guid id)
                => await _context.Teachers.FirstOrDefaultAsync(u => u.Id == id);


        public async Task<Teacher> GetUserAsync(string firstname)
                => await _context.Teachers.FirstOrDefaultAsync(u => u.Firstname == firstname);
        public async Task<(bool IsSuccess, Exception exception)> InsertUserAsync(Teacher user)
        {
            try
            {
                if (!await ExistsAsync(user.Id))
                {
                    await _context.Teachers.AddAsync(user);
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

        public async Task<(bool IsSuccess, Exception exception, Teacher user)> RemoveAsync(Teacher user)
        {
            try
            {
                _context.Teachers.Remove(user);
                await _context.SaveChangesAsync();
                return (true, null, user);
            }
            catch (Exception e)
            {
                return (false, e, null);
            }
        }

        public async Task<(bool IsSuccess, Exception exception)> UpdateUserAsync(Teacher user)
        {
            try
            {
                var savedUser = await GetUserAsync(user.Id);
                _context.Remove(savedUser);
                await _context.SaveChangesAsync();
                await _context.Teachers.AddAsync(user);
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
