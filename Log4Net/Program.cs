/*
 * from
 * https://betterstack.com/community/guides/logging/how-to-start-logging-with-net/
 */

using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace DotNet_Logging.Log4NetDemo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Log4Net();
		}
		static void Log4Net()
		{
			/*
			 * 1) Package Manager Console in the working Project
			 * PM> Install-Package log4net
			 */

			// 2.1) create a hierarchy for configuration (programming configuration)
			var hierarchy = (Hierarchy)LogManager.GetRepository();

			// 2.2) create console appender
			var consoleAppender = new ConsoleAppender();

			// 2.3) add appender
			hierarchy.Root.AddAppender(consoleAppender);

			// 2.4) apply the configuration
			BasicConfigurator.Configure(hierarchy);

			// 3) create a logger instance
			var logger = LogManager.GetLogger(typeof(Program));

			// 4) logging
			logger.Debug("Debug message");
			logger.Info("Info message");
			logger.Warn("Warning message");
			logger.Error("Error message");
			logger.Fatal("Fatal message");
		}
	}
}
