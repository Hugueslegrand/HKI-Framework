using Automation_Framework.Helpers;
using LLibrary;
using System;


namespace Automation_Framework.Utilities
{
	/// <summary>
	/// Log class for logging events
	/// </summary>
	public class Log
    {
		/// <summary>
		/// Initialize L Logger logs
		/// </summary>
		public static L logger = LogRun();


		/// <summary>
		/// Method to save or not save log files
		/// </summary>
		/// <returns>Returns a new L Logger</returns>
		public static L LogRun()
        {
            if (Configuration.Logger is not null)
            {
				if (Configuration.Logger.EnableLog)
				{
					return new L(directory: $@"{Configuration.Logger.LogsPath}");
				}
				else
				{
					return new L();
				}
			}
			return new L();
            
        }

		/// <summary>
		/// Prints log for the beginning of the test case
		/// </summary>
		/// <param name="message">A string with a message</param>
		public static void StartTestCase(String message)
		{
			
			logger.Info("****************************************************************************************");

			logger.Info("****************************************************************************************");

			logger.Info("$$$$$$$$$$$$$$$$$$$          " + message + "          $$$$$$$$$$$$$$$$$$$");

			logger.Info("****************************************************************************************");

			logger.Info("****************************************************************************************");

		}

		/// <summary>
		/// Prints log for the ending of the test case
		/// </summary>
		/// <param name="message">A string with a message</param>

		public static void EndTestCase(String message)
		{
			if(message is not null)
			logger.Info(message);

			logger.Info("XXXXXXXXXXXXXXXXXXXXXXX             " + "-E---N---D-" + "             XXXXXXXXXXXXXXXXXXXXXX");

			logger.Info("X");

			logger.Info("X");

			logger.Info("X");

			logger.Info("X");

		}


		/// <summary>
		/// Logs the given information with INFO label.
		/// </summary>
		/// <param name="message">A string with a message</param>
		public static void Info(String message)
		{

			logger.Info(message);

		}
		/// <summary>
		/// Logs the given information with WARN label.
		/// </summary>
		/// <param name="message">A string with a message</param>
		public static void Warn(String message)
		{

			logger.Warn(message);

		}
		/// <summary>
		/// Logs the given information with ERROR label.
		/// </summary>
		/// <param name="message">A string with a message</param>
		public static void Error(String message)
		{

			logger.Error(message);

		}
		/// <summary>
		/// Logs the given information with FATAL label.
		/// </summary>
		/// <param name="message">A string with a message</param>
		public static void Fatal(String message)
		{

			logger.Fatal(message);

		}
		/// <summary>
		/// Logs the given information with DEBUG label.
		/// </summary>
		/// <param name="message">A string with a message</param>
		public static void Debug(String message)
		{

			logger.Debug(message);

		}

	}
}

