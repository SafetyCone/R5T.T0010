using System;

using R5T.Stagira;


namespace R5T.T0010
{
    public class RepositoryDirectoryPath : TypedString
    {
        #region Static

        public static RepositoryDirectoryPath From(string repositoryDirectoryPathValue)
        {
            var repositoryDirectoryPath = new RepositoryDirectoryPath(repositoryDirectoryPathValue);
            return repositoryDirectoryPath;
        }

        #endregion


        public RepositoryDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
