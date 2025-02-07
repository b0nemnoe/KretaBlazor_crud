using Kreta.Backend.Repos;
using Kreta.Backend.Services;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolClassController : BaseController<SchoolClass, SchoolClassDto>
    {
        private readonly ISchoolClassRepo? _schoolClassRepo;
        private readonly ISchoolClassSubjectService? _schoolClassSubjectService;
        public SchoolClassController(ISchoolClassSubjectService? schoolClassSubjectService, SchoolClassAssambler? assambler, ISchoolClassRepo? repo) : base(assambler, repo)
        {
            _schoolClassRepo = repo;
            _schoolClassSubjectService = schoolClassSubjectService;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            List<SchoolClass>? schoolClasses = new();
            if (_schoolClassRepo != null && _assambler is not null)
            {
                try
                {
                    schoolClasses = await _schoolClassRepo.SelectAllIncluded().ToListAsync();
                    return Ok(schoolClasses.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {

                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet("getbytypeofeducationid/{typeOfEducationID}")]
        public async Task<IActionResult> GetByTypeOfEducationId(Guid typeOfEducationID)
        {
            List<SchoolClass>? schoolClasses = new();
            if (_schoolClassRepo != null && _assambler is not null)
            {
                try
                {
                    schoolClasses = await _schoolClassRepo.GetSchoolClassBy(typeOfEducationID).ToListAsync();
                    return Ok(schoolClasses.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {

                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet("withouttypeofeducation")]
        public async Task<IActionResult> SelectWithoutTypeOfEducation()
        {
            List<SchoolClass>? schoolClasses = new();
            if (_schoolClassRepo != null && _assambler is not null)
            {
                try
                {
                    schoolClasses = await _schoolClassRepo.SelectWithoutTypeOfEducation().ToListAsync();
                    return Ok(schoolClasses.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {

                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet("withsubjects")]
        public async Task<IActionResult> SelectSchoolClassWithSubjects()
        {
            List<SchoolClass> schoolClasses = new();
            if (_schoolClassRepo is not null)
            {
                try
                {
                    List<SchoolClass> result = await _schoolClassRepo.SelectSchoolClassesWithSubjects().ToListAsync();
                    return Ok(result.Select(schoolClass => schoolClass.ToDto()));
                }
                catch (Exception ex)
                {
                    await Console.Out.WriteLineAsync(ex.Message);
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet("notstudiedintheschoolclass/{subjectId}")]
        public async Task<IActionResult> SelectSubjectNotStudiedInTheSchoolClass(Guid subjectId)
        {
            List<SchoolClass> schoolClasses = new();
            if (_schoolClassSubjectService is not null)
            {
                try
                {
                    List<Subject> result = await _schoolClassSubjectService
                        .SelectSubjectNoStudiedInTheSchoolClass(subjectId)
                        .ToListAsync();
                    return Ok(result.Select(subject => subject.ToDto()));
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
