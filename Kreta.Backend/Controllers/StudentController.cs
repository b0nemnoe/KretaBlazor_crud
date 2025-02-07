using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : BaseController<Student, StudentDto>
    {
        private readonly IStudentRepo? _studentRepo;
        public StudentController(StudentAssambler? assambler, IStudentRepo? repo) : base(assambler, repo)
        {
            _studentRepo = repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            List<Student>? students = new();
            if (_studentRepo != null && _assambler is not null)
            {
                try
                {
                    students = await _studentRepo.SelectAllIncluded().ToListAsync();
                    return Ok(students.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {
                    await Console.Out.WriteLineAsync(ex.Message);
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }


        [HttpGet("byeducationid/{educationId}")]
        public async Task<IActionResult> SelectStudentsByEducationId(Guid educationId)
        {
            List<Student>? students = new();
            if (_studentRepo != null && _assambler is not null)
            {
                try
                {
                    students = await _studentRepo.SelectStudentsByEducationId(educationId).ToListAsync();
                    return Ok(students.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {
                    await Console.Out.WriteLineAsync(ex.Message);
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet("withouteducationlevel")]
        public async Task<IActionResult> SelectStudentsWithoutEducationLevel()
        {
            List<Student>? students = new();
            if (_studentRepo != null && _assambler is not null)
            {
                try
                {
                    students = await _studentRepo.SelectStudentsWithoutEducationLevel().ToListAsync();
                    return Ok(students.Select(entity => _assambler.ToDto(entity)));
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
