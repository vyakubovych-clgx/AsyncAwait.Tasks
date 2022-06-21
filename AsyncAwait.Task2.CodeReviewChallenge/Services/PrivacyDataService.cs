using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AsyncAwait.Task2.CodeReviewChallenge.Services;

public class PrivacyDataService : IPrivacyDataService
{
    private readonly string _privacyDataMessageFilePath;

    public PrivacyDataService(IConfiguration configuration)
    {
        _privacyDataMessageFilePath = configuration["PrivacyDataMessageFilePath"];
    }

    public async Task<string> GetPrivacyDataAsync()
        => await File.ReadAllTextAsync(_privacyDataMessageFilePath);

    public string GetPrivacyData()
        => "This Policy describes how async/await processes your personal data," +
           "but it may not address all possible data processing scenarios.";
}
