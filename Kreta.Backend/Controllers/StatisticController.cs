using Kreta.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatisticController : ControllerBase
    {
        private IStatisticRepo _statisticRepo;

        public StatisticController(IStatisticRepo statisticRepo)
        {      
            _statisticRepo = statisticRepo;
        }

        [HttpGet("NumberOfParent")]
        public IActionResult GetNumberOfParent()
        {
            return Ok(_statisticRepo.GetNumberOfParents());
        }

        [HttpGet("GenderNumberOfParent")]
        public IActionResult GetGenderNumberOfParent()
        {
            return Ok(_statisticRepo.GetGenderNumberOfParent());
        }

        [HttpGet("NumberOfStudentByClasses")]
        public IActionResult GetNumberOfStudentByClasses()
        {
            return Ok(_statisticRepo.GetNumberOfStudentByClasses());
        }
    }
}
