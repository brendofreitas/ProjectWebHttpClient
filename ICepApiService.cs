using Refit;
using System.Threading.Tasks;

namespace ProjectWebHttpClient
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddresAsync(string cep);
    }
}
