using Forum.Application.Repositories;
using Forum.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IEyaUserRepository
{
    Task<EyaUser> GetUserByIdAsync(int userId);
    Task<List<EyaUser>> GetAllUsersAsync();
    Task CreateUserAsync(EyaUser user);
    Task UpdateUserAsync(EyaUser user);
    Task DeleteUserAsync(int userId);
}

public class EyaUserRepository : IEyaUserRepository
{
    private readonly DbContext _context;

    public EyaUserRepository(DbContext context)
    {
        _context = context;
    }

    public async Task<EyaUser> GetUserByIdAsync(int userId)
    {
        return await _context.EyaUsers.FindAsync(userId);
    }

}
