using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Logic.Logger
{
    public interface ILogger
    {
        void Debug(string message);
        void Error(string message);
        void Exception(Exception exception, string message);
        void Exception(Exception exception);
    }
}
