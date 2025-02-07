using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class GradeHttpService : BaseService<Grade, GradeDto>, IGradeHttpService
    {
        public GradeHttpService(IHttpClientFactory? httpClientFactory, GradeAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
