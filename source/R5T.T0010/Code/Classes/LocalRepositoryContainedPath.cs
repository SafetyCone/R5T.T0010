using System;

using R5T.Stagira;


namespace R5T.T0010
{
    /// <summary>
    /// A path (file or directory path) to file or directory contained within a local repository.
    /// </summary>
    public class LocalRepositoryContainedPath : TypedString
    {
        #region Static

        public static LocalRepositoryContainedPath From(string localRepositoryContainedPathValue)
        {
            var localRepositoryContainedPath = new LocalRepositoryContainedPath(localRepositoryContainedPathValue);
            return localRepositoryContainedPath;
        }

        #endregion


        public LocalRepositoryContainedPath(string value)
            : base(value)
        {
        }
    }
}
