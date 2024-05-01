using Forum.Web.UI.Clients.Authentication;
using Forum.Web.UI.Clients.Users;
using Forum.Web.UI.Settings;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

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

    // Implement other methods
}
