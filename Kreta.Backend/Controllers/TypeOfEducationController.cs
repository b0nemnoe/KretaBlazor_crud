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
    public class TypeOfEducationController : BaseController<TypeOfEducation, TypeOfEducationDto>
    {
        private readonly ITypeOfEducationRepo? _typeOfEducationRepo;
        public TypeOfEducationController(TypeOfEducationAssambler? assambler, ITypeOfEducationRepo? repo) : base(assambler, repo)
        {
            _typeOfEducationRepo = repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            List<TypeOfEducation>? typeOfEducations = new();
            if (_typeOfEducationRepo != null && _assambler != null)
            {
                try
                {
                    typeOfEducations = await _typeOfEducationRepo.SelectAllIncluded().ToListAsync();
                    return Ok(typeOfEducations.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception e)
                {

                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
    }
}
