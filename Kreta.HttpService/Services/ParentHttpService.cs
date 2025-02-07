using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Assamblers;


namespace Kreta.HttpService.Services
{
    public class ParentHttpService : BaseService<Parent, ParentDto>, IParentHttpService
    {
        public ParentHttpService(IHttpClientFactory? httpClientFactory,ParentAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
