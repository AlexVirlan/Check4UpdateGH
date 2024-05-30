using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check4UpdateGH.Entities
{
    public class Enums
    {
        public enum CheckType
        {
            VersionThenTime = 0,
            OnlyVersion = 1,
            OnlyTime = 2
        }

        public enum CheckVersionFrom
        {
            ReleaseName = 0,
            TagName = 1,
            FirstAssetName = 2
        }
    }
}
