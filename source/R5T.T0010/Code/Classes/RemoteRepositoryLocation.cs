using System;

using R5T.Stagira;

using R5T.T0150;


namespace R5T.T0010.Code.Classes
{
    /// <summary>
    /// The string used to locate a remote repository. Examples:
    /// * https://github.com/SafetyCone/R5T.E0005.Private.git (HTTPS GitHub access)
    /// * git@github.com:SafetyCone/R5T.E0005.Private.git (SSH GitHub access)
    /// </summary>
    [StrongTypeMarker]
    public class RemoteRepositoryLocation : TypedString
    {
        #region Static

        public static RemoteRepositoryLocation From(string remoteRepositoryLocationValue)
        {
            var remoteRepositoryLocation = new RemoteRepositoryLocation(remoteRepositoryLocationValue);
            return remoteRepositoryLocation;
        }

        #endregion


        public RemoteRepositoryLocation(string value)
            : base(value)
        {
        }
    }
}
