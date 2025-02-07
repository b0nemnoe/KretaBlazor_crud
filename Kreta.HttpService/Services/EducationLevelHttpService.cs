using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class EducationLevelHttpService : BaseService<EducationLevel, EducationLevelDto>, IEducationLavelService
    {
        public EducationLevelHttpService(IHttpClientFactory? httpClientFactory, EducationLevelAssambler assambler, StudentAssambler studentAssambler) : base(httpClientFactory, assambler)
        {
        }


    }
}
