/*
 * from
 * https://betterstack.com/community/guides/logging/how-to-start-logging-with-net/
 */

using Microsoft.Extensions.Logging;

namespace DotNet_Logging.MsLogDemo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			mslog();
		}
		static void mslog()
		{
			/*
			 * 1) Package Manager Console in the working Project
			 * ------------------------
			 * Install-Package Microsoft.Extensions.Logging
			 * Install-Package Microsoft.Extensions.Logging.Console
			 * Install-Package Microsoft.Extensions.Logging.Debug
			 * ------------------------
			 */

			// 2) create a logger factory
			var loggerFactory = LoggerFactory.Create(
							builder => builder
							// add console as logging target
							.AddConsole()
							// add debug output as logging target
							.AddDebug()
							// set minimum level to log
							.SetMinimumLevel(LogLevel.Debug)
			);

			// 3) create a logger
			var logger = loggerFactory.CreateLogger<Program>();

			// 4) logging
			logger.LogTrace("Trace message");
			logger.LogDebug("Debug message");
			logger.LogInformation("Info message");
			logger.LogWarning("Warning message");
			logger.LogError("Error message");
			logger.LogCritical("Critical message");
		}
	}
}
