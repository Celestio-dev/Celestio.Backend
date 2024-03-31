using Celestio.Api.Services.SocialMediaService;
using Celestio.Core.Enums;
using Celestio.Core.Helpers;
using Celestio.Core.Models.SocialMedia;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Celestio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SocialMediaController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly ISocialMediaService _socialMediaService;
    
    public SocialMediaController(ILogger<SocialMediaController> logger, IConfiguration configuration, ISocialMediaService socialMediaService)
    {
        _logger = logger;
        _configuration = configuration;
        _socialMediaService = socialMediaService;
    }


    /// <summary>
    /// Logged in user must have role AgencyAdmin or SuperAdmin
    /// </summary>
    /// <param name="createSocialList"></param>
    /// <param name="companyId"></param>
    /// <returns></returns>
    [HttpPost("company/{companyId}")]
    [AuthorizeRole(RolesEnum.AgencyAdmin, RolesEnum.SuperAdmin)]
    public async Task<ActionResult<List<SocialMediaDto>>> AddCompanySocialMedia(
        List<CreateSocialMediaDto> createSocialList, int companyId)
    {
        AuthenticatedUser? authUser = UserHelper.GetAuthUserFromClaims(User);
        if (authUser is null) return Unauthorized();

        var socialMediae = await _socialMediaService.AddCompanySocialMedia(createSocialList, companyId, authUser);
        if (socialMediae == null)
        {
            return BadRequest("Could not add SocialMedia. User might not be owner of company");
        }
        return Ok(socialMediae);
    }
}