using System;

using R5T.Stagira;

using R5T.T0150;


namespace R5T.T0010
{
    [StrongTypeMarker]
    public class RemoteRepositoryUrl : TypedString
    {
        #region Static

        public static RemoteRepositoryUrl From(string remoteRepositoryUrlValue)
        {
            var remoteRepositoryUrl = new RemoteRepositoryUrl(remoteRepositoryUrlValue);
            return remoteRepositoryUrl;
        }

        #endregion


        public RemoteRepositoryUrl(string value)
            : base(value)
        {
        }
    }
}
