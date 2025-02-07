using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SwitchTable;
using Kreta.Shared.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.HttpService.Services
{
    public class SchoolClassSubjectsHttpService : BaseService<SchoolClassSubjects, SchoolClassSubjectsDto>, ISchoolClassSubjectsHttpService
    {
        public SchoolClassSubjectsHttpService(IHttpClientFactory? httpClientFactory, SchoolClassSubjectsAssambler assambler) : base(httpClientFactory, assambler)
        {
        }

        public async Task<List<SchoolClassSubjects>> SelectAllIncludedAsync()
        {
            if (_httpClient is not null)
            {
                try
                {

                    List<SchoolClassSubjectsDto>? resultDto = await _httpClient.GetFromJsonAsync<List<SchoolClassSubjectsDto>>($"api/SchoolClassSubjects/included");
                    if (resultDto is not null)
                    {
                        List<SchoolClassSubjects> result = resultDto.Select(entity => _assambler.ToModel(entity)).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<SchoolClassSubjects>();
        }

        public async Task<Response> MoveToNotStudyingAsync(SchoolClassSubjects schoolClassSubjects)
        {
            Response defaultResponse = new();
            if (_httpClient is not null)
            {
                try
                {

                    HttpResponseMessage httpResponse = await _httpClient.PostAsJsonAsync($"api/SchoolClassSubjects/MoveToNotStudying", _assambler.ToDto(schoolClassSubjects));
                    if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                    {
                        string content = await httpResponse.Content.ReadAsStringAsync();
                        Response? response = JsonConvert.DeserializeObject<Response>(content);
                        if (response is null)
                        {
                            defaultResponse.ClearAndAddError("A tantárgy áthelyezése az osztály által nem tanult tanátrgyak közé nem sikerült!");
                        }
                        else return response;
                    }
                    else if (!httpResponse.IsSuccessStatusCode)
                    {
                        httpResponse.EnsureSuccessStatusCode();
                    }
                    else
                    {
                        return defaultResponse;
                    }
                }

                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            defaultResponse.ClearAndAddError("A tantárgy áthelyezése az osztály által nem tanult tanátrgyak közé nem lehetséges!");
            return defaultResponse;
        }


        public async Task<Response> MoveToStudyingAsync(SchoolClassSubjects schoolClassSubjects)
        {
            Response defaultResponse = new();
            if (_httpClient is not null)
            {
                try
                {

                    HttpResponseMessage httpResponse = await _httpClient.PostAsJsonAsync($"api/SchoolClassSubjects/MoveToStudying", _assambler.ToDto(schoolClassSubjects));
                    if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                    {
                        string content = await httpResponse.Content.ReadAsStringAsync();
                        Response? response = JsonConvert.DeserializeObject<Response>(content);
                        if (response is null)
                        {
                            defaultResponse.ClearAndAddError("A tantárgy áthelyezése az osztály által tanult tanátrgyak közé nem sikerült!");
                        }
                        else return response;
                    }
                    else if (!httpResponse.IsSuccessStatusCode)
                    {
                        httpResponse.EnsureSuccessStatusCode();
                    }
                    else
                    {
                        return defaultResponse;
                    }
                }

                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            defaultResponse.ClearAndAddError("A tantárgy áthelyezése az osztály által tanult tanátrgyak közé nem lehetséges!");
            return defaultResponse;
        }
    }
}
