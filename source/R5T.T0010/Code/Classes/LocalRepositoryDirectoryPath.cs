using System;

using R5T.Stagira;

using R5T.T0150;


namespace R5T.T0010
{
    [StrongTypeMarker]
    public class LocalRepositoryDirectoryPath : TypedString
    {
        #region Static

        public static LocalRepositoryDirectoryPath From(string repositoryDirectoryPathValue)
        {
            var repositoryDirectoryPath = new LocalRepositoryDirectoryPath(repositoryDirectoryPathValue);
            return repositoryDirectoryPath;
        }

        #endregion


        public LocalRepositoryDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
