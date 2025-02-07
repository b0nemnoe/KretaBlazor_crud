using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class PublicSpaceHttpService : BaseService<PublicSpace, PublicSpaceDto>, IPublicSpaceHttpService
    {
        public PublicSpaceHttpService(IHttpClientFactory? httpClientFactory, PublicSpaceAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
