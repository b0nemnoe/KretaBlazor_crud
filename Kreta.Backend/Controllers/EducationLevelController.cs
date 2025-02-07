using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EducationLevelController : BaseController<EducationLevel, EducationLevelDto>
    {
        private readonly IEducationLevelRepo? _educationLevelRepo;
        public EducationLevelController(EducationLevelAssambler? assambler, IEducationLevelRepo? repo) : base(assambler, repo)
        {
            _educationLevelRepo = repo;
        }


        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            List<EducationLevel>? educationLevels = new();
            if (_educationLevelRepo != null && _assambler is not null)
            {
                try
                {
                    educationLevels = await _educationLevelRepo.SelectAllIncluded().ToListAsync();
                    return Ok(educationLevels.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {
                    await Console.Out.WriteLineAsync(ex.Message);
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
    }
}
