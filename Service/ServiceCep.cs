using Refit;
using System;
using System.Threading.Tasks;

namespace ProjectWebHttpClient.Service
{
    public class ServiceCep
    {
        public async Task<CepResponse> RecuperandoCep(string cep)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                var address = await cepClient.GetAddresAsync(cep);
                return  address;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de CEP" + e.Message);
            }
            return null;
        }
    }
}
