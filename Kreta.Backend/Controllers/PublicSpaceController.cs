using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicSpaceController : BaseController<PublicSpace, PublicSpaceDto>
    {
        public PublicSpaceController(PublicSpaceAssambler? assambler, IPublicSpaceRepo? repo) : base(assambler, repo)
        {
        }
    }
}
