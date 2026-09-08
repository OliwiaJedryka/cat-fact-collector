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
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CatFactResponse>()
           ?? throw new InvalidOperationException("Response body was empty.");
    }
}
