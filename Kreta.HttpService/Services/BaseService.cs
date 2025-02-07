using Kreta.Shared.Assamblers;
using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;

namespace Kreta.HttpService.Services
{
    public class BaseService<TEntity, TEntityDto> : IBaseHttpService<TEntity>
        where TEntity : class, IDbEntity<TEntity>, new()
        where TEntityDto : class, new()
    {
        protected readonly HttpClient _httpClient;
        protected Assambler<TEntity, TEntityDto> _assambler;

        public BaseService()
        {
            _httpClient = new HttpClient();
            _assambler = new DefaultAssambler<TEntity, TEntityDto>();
        }
        public BaseService(IHttpClientFactory? httpClientFactory, Assambler<TEntity, TEntityDto>? assambler)
        {
            if (httpClientFactory is not null)
                _httpClient = httpClientFactory.CreateClient("KretaApi");
            else
                _httpClient= new HttpClient();

            _assambler = assambler ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            try
            {
                string uri = GetApiName();
                List<TEntityDto>? resultDto = await _httpClient.GetFromJsonAsync<List<TEntityDto>>($"api/{GetApiName()}");
                if (resultDto is not null)
                {
                    List<TEntity> result = resultDto.Select(entity => _assambler.ToModel(entity)).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return new List<TEntity>();
        }

        public async Task<Response> UpdateAsync(TEntity entity)
        {
            Response defaultResponse = new();
            try
            {
                HttpResponseMessage httpResponse = await _httpClient.PutAsJsonAsync($"api/{GetApiName()}", _assambler.ToDto(entity));
                if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                {
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    Response? response = JsonConvert.DeserializeObject<Response>(content);
                    if (response is null)
                    {
                        defaultResponse.ClearAndAddError("A módosítás http kérés hibát okozott!");
                    }
                    else return response;
                }
                else if (!httpResponse.IsSuccessStatusCode)
                {
                    httpResponse.EnsureSuccessStatusCode();
                }
                else
                {
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    Response? response = JsonConvert.DeserializeObject<Response>(content);
                    if (response is null)
                    {
                        defaultResponse.ClearAndAddError("A módosítás http kérés hibát okozott!");
                    }
                    else return response;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            defaultResponse.ClearAndAddError("Az adatok frissítés nem lehetséges!");
            return defaultResponse;
        }


        public async Task<Response> DeleteAsync(Guid id)
        {
            Response defaultResponse = new();
            try
            {
                HttpResponseMessage httpResponse = await _httpClient.DeleteAsync($"api/{GetApiName()}/{id}");
                if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                {
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    Response? response = JsonConvert.DeserializeObject<Response>(content);
                    if (response is null)
                    {
                        defaultResponse.ClearAndAddError("A törlés http kérés hibát okozott!");
                    }
                    else return response;
                }
                else if (!httpResponse.IsSuccessStatusCode)
                {
                    httpResponse.EnsureSuccessStatusCode();
                }
                else
                {
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    Response? response = JsonConvert.DeserializeObject<Response>(content);
                    if (response is null)
                    {
                        defaultResponse.ClearAndAddError("A módosítás http kérés hibát okozott!");
                    }
                    else return response;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            defaultResponse.ClearAndAddError("Az adatok törlése nem lehetséges!");
            return defaultResponse;
        }

        public async Task<Response> InsertAsync(TEntity entity)
        {
            Response defaultResponse = new();
            try
            {
                HttpResponseMessage httpResponse = await _httpClient.PostAsJsonAsync($"api/{GetApiName()}", _assambler.ToDto(entity));
                if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                {
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    Response? response = JsonConvert.DeserializeObject<Response>(content);
                    if (response is null)
                    {
                        defaultResponse.ClearAndAddError("A mentés http kérés hibát okozott!");
                    }
                    else return response;
                }
                else if (!httpResponse.IsSuccessStatusCode)
                {
                    httpResponse.EnsureSuccessStatusCode();
                }
                else
                {
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    Response? response = JsonConvert.DeserializeObject<Response>(content);
                    if (response is null)
                    {
                        defaultResponse.ClearAndAddError("A módosítás http kérés hibát okozott!");
                    }
                    else return response;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            defaultResponse.ClearAndAddError("Az adatok mentése nem lehetséges!");
            return defaultResponse;
        }

        private static string GetApiName()
        {
            return new TEntity().GetType().Name;
        }


    }
}
