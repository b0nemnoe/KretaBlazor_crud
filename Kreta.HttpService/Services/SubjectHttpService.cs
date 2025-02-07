using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace Kreta.HttpService.Services
{
    public class SubjectHttpService : BaseService<Subject, SubjectDto>, ISubjectHttpService
    {
        private readonly SchoolClassAssambler? _schoolClassAssambler;
        public SubjectHttpService(IHttpClientFactory? httpClientFactory, SubjectAssambler assambler, SchoolClassAssambler? schoolClassAssambler) : base(httpClientFactory, assambler)
        {
            _schoolClassAssambler = schoolClassAssambler;
        }

        public async Task<List<Subject>> GetAllSubjectsWithSchoolClassesAsync()
        {
            if (_httpClient is not null)
            {
                try
                {

                    List<SubjectDto>? resultDto = await _httpClient.GetFromJsonAsync<List<SubjectDto>>($"api/Subject/withschoolclass");
                    if (resultDto is not null)
                    {
                        List<Subject> result = resultDto.Select(entity => _assambler.ToModel(entity)).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<Subject>();
        }

        public async Task<List<SchoolClass>> GetSchoolClassWhoNotStudyingSubject(Guid subjectID)
        {
            if (_httpClient is not null && _schoolClassAssambler is not null)
            {
                try
                {

                    List<SchoolClassDto>? resultDto = await _httpClient.GetFromJsonAsync<List<SchoolClassDto>>($"api/Subject/notstudyingintheschoolclass/{subjectID}");
                    if (resultDto is not null)
                    {
                        List<SchoolClass> result = resultDto.Select(entity => _schoolClassAssambler.ToModel(entity)).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<SchoolClass>();
        }
    }
}
