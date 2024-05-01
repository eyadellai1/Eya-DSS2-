using Forum.Application.Repositories;
using Forum.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
public interface IEyaUserService
{
    Task<EyaUser> GetUserByIdAsync(int userId);
    Task<List<EyaUser>> GetAllUsersAsync();
    Task CreateUserAsync(EyaUser user);
    Task UpdateUserAsync(EyaUser user);
    Task DeleteUserAsync(int userId);
}

public class EyaUserService : IEyaUserService
{
    private readonly IEyaUserRepository _userRepository;

    public EyaUserService(IEyaUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<EyaUser> GetUserByIdAsync(int userId)
    {
        return await _userRepository.GetUserByIdAsync(userId);
    }

}
