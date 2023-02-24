using System;

using R5T.Stagira;

using R5T.T0150;


namespace R5T.T0010
{
    [StrongTypeMarker]
    public class RepositoryName : TypedString
    {
        #region Static

        public static RepositoryName From(string repositoryNameValue)
        {
            var repositoryName = new RepositoryName(repositoryNameValue);
            return repositoryName;
        }

        #endregion


        public RepositoryName(string value)
            : base(value)
        {
        }
    }
}
