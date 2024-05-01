using Forum.Web.UI.Clients.Users;
using Forum.Web.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class EyaUserController : ControllerBase
{
    private readonly IEyaUserService _userService;

    public EyaUserController(IEyaUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{userId}")]
    public async Task<ActionResult<EyaUser>> GetUserById(int userId)
    {
        var user = await _userService.GetUserByIdAsync(userId);
        if (user == null)
        {
            return NotFound();
        }
        return user;
    }

}
