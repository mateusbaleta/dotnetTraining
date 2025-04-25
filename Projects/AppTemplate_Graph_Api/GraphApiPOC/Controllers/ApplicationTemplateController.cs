using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GraphApiTemplate.Models;
using GraphApiTemplate.Services;

namespace GraphApiTemplate.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationTemplateController : ControllerBase
    {
        private readonly GraphService _graphService;

        public ApplicationTemplateController(GraphService graphService)
        {
            _graphService = graphService;
        }

        [HttpPost("create-template")] 
        public async Task<IActionResult> CreateTemplate([FromBody] ApplicationTemplateRequest request)
        {
            var result = await _graphService.CreateApplicationWithSamlAsync(request);
            return Ok(result);
        }
    }
}
