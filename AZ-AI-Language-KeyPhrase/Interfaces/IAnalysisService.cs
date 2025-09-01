using AZ_AI_Language_KeyPhrase.Models;

namespace AZ_AI_Language_KeyPhrase.Interfaces
{
    public interface IAnalysisService
    {
        Task<KeyPhraseResponse> ExtractKeyPhrases(string data);
    }
}
