using Microsoft.Extensions.Logging;

namespace PowerPlantChallenge.Configurations
{
    public static class LoggingConfiguration
    {
        public static void ConfigureLogging(this ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile("Logs /powerplantchallenge-api-{Date}.txt");
        }
    }
}
