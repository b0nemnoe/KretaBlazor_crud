using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class TypeOfEducationHttpService : BaseService<TypeOfEducation, TypeOfEducationDto>, ITypeOfEducationHttpService
    {
        public TypeOfEducationHttpService()
        {
        }

        public TypeOfEducationHttpService(IHttpClientFactory? httpClientFactory, TypeOfEducationAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
