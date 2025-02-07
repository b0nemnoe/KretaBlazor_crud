using Kreta.Backend.Repos.SwitchTables;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SwitchTable;
using Kreta.Shared.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolClassSubjectsController : BaseController<SchoolClassSubjects, SchoolClassSubjectsDto>
    {
        private readonly ISchoolClassSubjectsRepo schoolClassSubjectRepo;
        public SchoolClassSubjectsController( SchoolClassSubjectsAssambler assambler, ISchoolClassSubjectsRepo repo) : base(assambler, repo)
        {
            schoolClassSubjectRepo = repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            if (schoolClassSubjectRepo != null)
            {
                try
                {
                    List<SchoolClassSubjects> result = await schoolClassSubjectRepo.SelectAllIncluded().ToListAsync();
                    return Ok(result.Select(schoolClassSubjects => schoolClassSubjects.ToDto()));
                }
                catch (Exception ex)
                {
                    await Console.Out.WriteLineAsync(ex.Message);
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPost("MoveToNotStudying")]
        public async Task<ActionResult> MoveToNotStudyingAsync(SchoolClassSubjectsDto schoolClassSubjectsDto)
        {
            Response response = new();
            if (schoolClassSubjectRepo is not null)
            {
                response = await schoolClassSubjectRepo.MoveToNotStudyingSchoolClassSubjectAsync(schoolClassSubjectsDto.ToModel());
                if (response.HasError)
                {
                    Console.WriteLine(response.Error);
                    response.ClearAndAddError("A tantárgy áthelyezése az osztály által nem tanult tanátrgyak közé nem sikerült!");
                    return BadRequest(response);
                }
            }
            return Ok(response);
        }

        [HttpPost("MoveToStudying")]
        public async Task<ActionResult> MoveToStudyingAsync(SchoolClassSubjectsDto schoolClassSubjectsDto)
        {
            Response response = new();
            if (schoolClassSubjectRepo is not null)
            {
                response = await schoolClassSubjectRepo.MoveToStudyingSchoolClassSubjectAsync(schoolClassSubjectsDto.ToModel());
                if (response.HasError)
                {
                    Console.WriteLine(response.Error);
                    response.ClearAndAddError("A tantárgy áthelyezése az osztály által tanult tanátrgyak közé nem sikerült!");
                    return BadRequest(response);
                }
            }
            return Ok(response);
        }
    }
}
