using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypertest.Framework
{
    public class LogTag
    {
        #region Fields

        private KeyValuePair<string, string> _attribute;

        #endregion

        #region Properties

        public KeyValuePair<string, string> Attribute { get => _attribute; set => _attribute = value; }

        #endregion
    }
}
