using Kreta.Backend.Repos;
using Kreta.Backend.Repos.SwitchTables;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SwitchTable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolClassStudentsController : BaseController<SchoolClassStudents, SchoolClassStudentsDto>
    {
        private readonly ISchoolClassStudentsRepo? _schoolClassStudentsRepo;
        public SchoolClassStudentsController(SchoolClassStudentsAssambler assambler, ISchoolClassStudentsRepo? repo) : base(assambler, repo)
        {
            _schoolClassStudentsRepo = repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            if (_schoolClassStudentsRepo != null)
            {
                try
                {
                    List<SchoolClassStudents> result = await _schoolClassStudentsRepo.SelectAllIncluded().ToListAsync();
                    return Ok(result.Select(achoolClassStudents => achoolClassStudents.ToDto()));
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
