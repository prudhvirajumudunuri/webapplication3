using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace timertrigger1
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogError($"pru: {DateTime.Now}");
        }
    }
}
