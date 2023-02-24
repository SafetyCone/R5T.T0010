using System;
using System.Collections.Generic;

using R5T.Stagira;

using R5T.T0142;


namespace R5T.T0010
{
    [DataTypeMarker]
    public class LocalRepositoryDirectoryPathsList : TypedStringsList<LocalRepositoryDirectoryPath>
    {
        #region Static

        public static LocalRepositoryDirectoryPathsList New()
        {
            var localRepositoryDirectoryPathsList = new LocalRepositoryDirectoryPathsList();
            return localRepositoryDirectoryPathsList;
        }

        #endregion


        public List<LocalRepositoryDirectoryPath> LocalRepositoryDirectoryPaths => this.Values;


        public LocalRepositoryDirectoryPathsList()
        {
        }

        public LocalRepositoryDirectoryPathsList(IEnumerable<LocalRepositoryDirectoryPath> values)
            : base(values)
        {
        }
    }
}
