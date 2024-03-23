using Celestio.Api.Services.SocialMediaService;

namespace Celestio.Api.Controllers;

public class SocialMediaController
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
}