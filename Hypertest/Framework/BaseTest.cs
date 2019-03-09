using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hypertest.Framework
{
    /// <summary>
    /// Contains the methods to start and end a test.
    /// </summary>
    public class BaseTest
    {
        #region Fields

        LogHandler _logHandler;

        #endregion

        #region Properties

        public LogHandler LogHandler
        {
            get
            {
                if(_logHandler == null)
                {
                    _logHandler = new LogHandler();
                }
                return _logHandler;
            }
        }

        #endregion

        #region Methods

        public void StartTest([CallerMemberName]string testName = "", int iteration = 1)
        {
            //LogHandler.AddLogger();
        }

        public void EndTest()
        {

        }

        #endregion

    }
}
