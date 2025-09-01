using AZ_AI_Language_KeyPhrase.Interfaces;
using AZ_AI_Language_KeyPhrase.Models;
using Microsoft.AspNetCore.Mvc;

namespace AZ_AI_Language_KeyPhrase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController(IAnalysisService analysisService) : ControllerBase
    {
        [HttpPost("ExtractKeyPhrases")]
        public async Task<IActionResult> ExtractKeyPhrases([FromBody] KeyPhraseRequest keyPhraseRequest)
        {
            var result = await analysisService.ExtractKeyPhrases(keyPhraseRequest.Text);
            return Ok(result);
        }
    }
}
