/*
 * from
 * https://betterstack.com/community/guides/logging/how-to-start-logging-with-net/
 */

using System;
using Serilog;

namespace DotNet_Logging.SerilogDemo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			serilog();
		}
		static void serilog()
		{
			/*
			 * 1) Package Manager - install dependencies in the working project
			 * Install-Package Serilog
			 * Install-Package Serilog.Sinks.Console
			 * Install-Package Serilog.Sinks.Debug
			 */

			// 2) create a logger
			using var logger = new LoggerConfiguration()
									// add console as logging target
									.WriteTo.Console()
									// add debug output as logging target
									.WriteTo.Debug()
									// set minimum level to log
									.MinimumLevel.Debug()
									.CreateLogger();

			// 3) logging
			logger.Verbose("Verbose message");
			logger.Debug("Debug message");
			logger.Information("Info message");
			logger.Warning("Warning message");
			logger.Error("Error message");
			logger.Fatal("Fatal message");
		}
	}
}
