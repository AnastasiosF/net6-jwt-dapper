using Microsoft.AspNetCore.Mvc;
using net6_jwt_dapper.Services;

namespace net6_jwt_dapper.Controllers;

[Route("api/companies")]
[ApiController]
public class CompaniesController : ControllerBase
{
    private readonly ILogger<CompaniesController> _logger;
    private readonly ICompanyService _companyService;

    public CompaniesController(ICompanyService companyService, ILogger<CompaniesController> logger)
    {
        _companyService = companyService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetCompanies()
    {
        try
        {
            //var companies = await _companyService.GetCompanies();
            return Ok("Test");
        }
        catch (Exception ex)
        {
            //log error
            _logger.LogInformation(ex.Message);
            return StatusCode(500, ex.Message);
        }
    }
}