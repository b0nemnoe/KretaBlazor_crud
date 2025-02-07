using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class SubjectTypeHttpService : BaseService<SubjectType, SubjectTypeDto>, ISubjectTypeHttpService
    {
        public SubjectTypeHttpService(IHttpClientFactory? httpClientFactory, SubjectTypeAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
