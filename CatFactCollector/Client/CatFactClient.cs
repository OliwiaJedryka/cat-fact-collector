using System.Net.Http.Json;

public class CatFactClient
{
    private readonly HttpClient _httpClient;

    public CatFactClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CatFactResponse> GetCatFact()
    {
        var response = await _httpClient.GetAsync("https://catfact.ninja/fact");
        
        var catFact = await response.Content.ReadFromJsonAsync<CatFactResponse>();

        return catFact;
    }
}
