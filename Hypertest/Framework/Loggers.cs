using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hypertest.Framework
{
    /// <summary>
    /// Handles all types of logging.
    /// </summary>
    public class Loggers
    {
        #region Fields

        private static ThreadLocal<List<Logger>> _loggers;
        #endregion

        #region Properties

        private static ThreadLocal<List<Logger>> LoggersList
        {
            get
            {
                if (_loggers == null)
                {
                    _loggers = new ThreadLocal<List<Logger>>();
                }
                return _loggers;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add the specified logger if the logger has not been registered.
        /// </summary>
        /// <param name="logger"></param>
        public void Add(Logger logger)
        {
            if (!HasLogger(logger))
            {
                LoggersList.Value.Add(logger);
            }
        }

        public bool HasLogger(Logger logger)
        {
            return LoggersList.Value.Exists(log=>log.GetType().Equals(logger.GetType()));
        }

        public void Log(TraceEventType traceEventType,string message,params object[] args)
        {
            foreach(Logger logger in LoggersList.Value)
            {
                logger.Log(traceEventType, message, args);
            }
        }

        #endregion

    }
}
