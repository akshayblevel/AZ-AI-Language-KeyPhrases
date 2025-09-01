using AZ_AI_Language_KeyPhrase.Interfaces;
using AZ_AI_Language_KeyPhrase.Models;
using Azure.AI.TextAnalytics;

namespace AZ_AI_Language_KeyPhrase.Services
{
    public class AnalysisService(TextAnalyticsClient textAnalytics) : IAnalysisService
    {
        public async Task<KeyPhraseResponse> ExtractKeyPhrases(string data)
        {
            var response = await textAnalytics.ExtractKeyPhrasesAsync(data);

            var result = new KeyPhraseResponse
            {
                KeyPhrases = response.Value.ToList()
            };

            return result;
        }
    }
}
