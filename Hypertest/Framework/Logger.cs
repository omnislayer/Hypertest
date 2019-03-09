using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypertest.Framework
{
    public abstract class Logger
    {
        #region Fields
        
        private static LogTags _logTags;

        #endregion

        #region Properties
        
        public static LogTags LogTags
        {
            get
            {
                if (_logTags == null)
                {
                    _logTags = new LogTags();
                }

                return _logTags;
            }
            set => _logTags = value;
        }

        #endregion

        #region Methods

        public abstract void Log(TraceEventType traceEventType, string message, params object[] args);

        #endregion
    }
}
