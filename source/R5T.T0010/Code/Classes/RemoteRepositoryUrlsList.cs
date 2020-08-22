using System;
using System.Collections.Generic;

using R5T.Stagira;


namespace R5T.T0010
{
    public class RemoteRepositoryUrlsList : TypedStringsList<RemoteRepositoryUrl>
    {
        #region Static

        public static RemoteRepositoryUrlsList New()
        {
            var remoteRepositoryUrlsList = new RemoteRepositoryUrlsList();
            return remoteRepositoryUrlsList;
        }

        #endregion


        public List<RemoteRepositoryUrl> RemoteRepositoryUrls => this.Values;


        public RemoteRepositoryUrlsList()
        {
        }

        public RemoteRepositoryUrlsList(IEnumerable<RemoteRepositoryUrl> values)
            : base(values)
        {
        }
    }
}
