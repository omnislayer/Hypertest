using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypertest.Framework
{
    public class LogHandler
    {
        #region Fields

        private static Stack<Stopwatch> _stopwatches;
        private static Loggers _loggers;

        #endregion

        #region Properties

        public static Stack<Stopwatch> Stopwatches
        {
            get
            {
                if (_stopwatches == null)
                {
                    _stopwatches = new Stack<Stopwatch>();
                }

                return _stopwatches;
            }
        }

        public static Loggers Loggers
        {
            get
            {
                if(_loggers == null)
                {
                    _loggers = new Loggers();
                }

                return _loggers;
            }
            set => _loggers = value;
        }

        #endregion

        #region Methods

        public void AddLogger(Logger logger)
        {
            Loggers.Add(logger);
        }

        public void StartTest(string testName)
        {

        }

        public void EndTest()
        {

        }

        public void StartPackage(string packageName)
        {

        }

        public void EndPackage()
        {

        }

        public void StartIteration(int iteration)
        {

        }

        public void EndIteration()
        {

        }

        private string _getCurrentTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss");
        }

        private void _addStopWatch()
        {
            Stopwatches.Push(Stopwatch.StartNew());
        }

        private Stopwatch _getStopWatch()
        {
            return Stopwatches.Pop();
        }

        private TimeSpan _endStopWatch()
        {
            Stopwatch stopwatch = _getStopWatch();
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        #endregion
    }
}
