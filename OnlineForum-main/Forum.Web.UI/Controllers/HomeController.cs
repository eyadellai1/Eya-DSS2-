using Forum.Web.UI.Clients.Authentication;
using Forum.Web.UI.Clients.Users;
using Forum.Web.UI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Security.Claims;

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
