using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check4UpdateGH.Entities
{
    public class UpdateCheckResult
    {
        #region Properties
        public bool Success { get; set; }
        public bool NewVersionAvailable { get; set; }
        public string? Message { get; set; }
        public Version? CurrentVersion { get; set; }
        public Version? NewVersion { get; set; }
        public GitHubRelease? GitHubRelease { get; set; }
        #endregion

        #region Constructors
        public UpdateCheckResult() { }

        public UpdateCheckResult(string errorMessage)
        {
            Success = false;
            Message = errorMessage;
        }

        public UpdateCheckResult(bool newVersionAvailable)
        {
            Success = true;
            NewVersionAvailable = newVersionAvailable;
        }

        public UpdateCheckResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public UpdateCheckResult(Version? currentVersion, Version? newVersion, GitHubRelease gitHubRelease)
        {
            Success = newVersion is null ? false : true;
            NewVersionAvailable = newVersion is null ? false : true;
            CurrentVersion = currentVersion;
            NewVersion = newVersion;
            GitHubRelease = gitHubRelease;
        }
        #endregion
    }
}
