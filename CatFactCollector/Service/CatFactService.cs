public class CatFactService
{
    private readonly CatFactClient _catFactClient;
    public CatFactService(CatFactClient catFactClient)
    {
        _catFactClient = catFactClient;
    }

    public async Task<CatFactResponse> GetAndSaveCatFact()
    {
        var catFact = await _catFactClient.GetCatFact();

        await File.AppendAllTextAsync("facts.txt", catFact.Fact + "\n");

        return catFact;
    }
}