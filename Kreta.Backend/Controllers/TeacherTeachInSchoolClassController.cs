using Kreta.Backend.Repos;
using Kreta.Backend.Repos.SwitchTables;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Models.SwitchTable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherTeachInSchoolClassController : BaseController<TeachersTeachInSchoolClass, TeachersTeachInSchoolClassDto>
    {
        private readonly ITeacherTeachInSchoolClass? _teacherTeachInSchoolClassRepo;

        public TeacherTeachInSchoolClassController(TeachersTeachInSchoolClassAssambler? assambler, ITeacherTeachInSchoolClass? repo) : base(assambler, repo)
        {
            _teacherTeachInSchoolClassRepo= repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            if (_teacherTeachInSchoolClassRepo != null)
            {
                try
                {
                    List<TeachersTeachInSchoolClass> result = await _teacherTeachInSchoolClassRepo.SelectAllIncluded().ToListAsync();
                    return Ok(result.Select(schoolClassSubjects => schoolClassSubjects.ToDto()));
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
