using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

[assembly: log4net.Config.XmlConfigurator(Watch = true, ConfigFile = "log4net.config")]
namespace Common.Logic.Logger
{
    public class Log4NetAdapter : ILogger 
    {  
        private readonly log4net.ILog Log;
        private bool isDebugEnabled = true;
        private bool isErrorEnabled = true;

        public Log4NetAdapter()
        {
            Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        public void Debug(string message)
        {
            if (isDebugEnabled) Log.Debug(message);
        }

        public void Error(string message)
        {
            if (isErrorEnabled) Log.Error(message);
        }

        public void Exception(Exception exception, string message)
        {
            Log.Error(message, exception);
        }

        public void Exception(Exception exception)
        {
            Log.Error(exception);
        }
    }
}
