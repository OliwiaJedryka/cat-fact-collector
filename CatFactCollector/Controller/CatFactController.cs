using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CatFactController : ControllerBase
{
    private readonly CatFactService _catFactService;

    public CatFactController(CatFactService catFactService)
    {
        _catFactService = catFactService;
    }

    [HttpGet]
    public async Task<CatFactResponse> GetCatFact()
    {
        return await _catFactService.GetAndSaveCatFact();
    }
}