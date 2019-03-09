using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypertest.Framework
{
    public class LogTags
    {
        #region Fields

        List<LogTag> _logs;

        #endregion

        #region Properties

        public List<LogTag> Logs
        {
            get
            {
                if(_logs == null)
                {
                    _logs = new List<LogTag>();
                }

                return _logs;
            }
            set => _logs = value;
        }

        
        #endregion
    }
}
