using System;

using R5T.Stagira;


namespace R5T.T0010
{
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
