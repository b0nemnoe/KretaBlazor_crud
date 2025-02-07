using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.HttpService.Services
{
    public class StudentHttpService : BaseService<Student, StudentDto>, IStudentHttpService
    {
        public StudentHttpService()
        {
            
        }
        public StudentHttpService(IHttpClientFactory? httpClientFactory, StudentAssambler studentAssambler) : base(httpClientFactory, studentAssambler)
        {
        }
    }
}
