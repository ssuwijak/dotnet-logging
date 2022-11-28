/*
 * from
 * https://betterstack.com/community/guides/logging/how-to-start-logging-with-net/
 */

using System;
using NLog;


namespace DotNet_Logging.NLogDummy
{
	public class Program
	{
		static void Main(string[] args)
		{
			/*
			 * 1) Package Manager - install dependencies in the working project
			 * Install-Package NLog.Extensions.Logging
			 * Install-Package Microsoft.Extensions.DependencyInjection
			 */

			// configuration settings --> https://github.com/NLog/NLog/wiki/Tutorial#configure-nlog-targets-for-output
			// 2.1) create a configuration instance
			var config = new NLog.Config.LoggingConfiguration();

			// 2.2) create a console logging target
			var logConsole = new NLog.Targets.ConsoleTarget();

			// 2.3) create a debug output logging target
			var logDebug = new NLog.Targets.DebugTarget();//.OutputDebugStringTarget();

			// 2.4) send logs with levels from Info to Fatal to the console
			config.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal, logConsole);

			// 2.5) send logs with levels from Debug to Fatal to the console
			config.AddRule(NLog.LogLevel.Debug, NLog.LogLevel.Fatal, logDebug);

			// 2.6) apply the configuration
			NLog.LogManager.Configuration = config;

			// 3) create a logger
			var logger = LogManager.GetCurrentClassLogger();

			// 4) logging
			logger.Trace("Trace message");
			logger.Debug("Debug message");
			logger.Info("Info message");
			logger.Warn("Warning message");
			logger.Error("Error message");
			logger.Fatal("Fatal message");
		}
	}
}
