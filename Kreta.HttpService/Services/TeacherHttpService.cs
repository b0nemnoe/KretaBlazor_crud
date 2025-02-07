using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Assamblers;

namespace Kreta.HttpService.Services
{
    public class TeacherHttpService : BaseService<Teacher, TeacherDto>, ITeacherHttpService
    {
        public TeacherHttpService(IHttpClientFactory? httpClientFactory, TeacherAssambler assambler) : base (httpClientFactory, assambler) { }
    }
}
