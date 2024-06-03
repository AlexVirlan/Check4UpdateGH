using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Check4UpdateGH.Entities.Enums;

namespace Check4UpdateGH.Entities
{
    public class CheckSettings
    {
        #region Properties
        public CheckType CheckType { get; set; }
        public CheckVersionFrom CheckVersionFrom { get; set; }
        #endregion

        #region Constructors
        public CheckSettings()
        {
            CheckType = CheckType.VersionThenTime;
            CheckVersionFrom = CheckVersionFrom.TagName;
        }
        #endregion
    }
}
