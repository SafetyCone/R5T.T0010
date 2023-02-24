using System;

using R5T.Stagira;

using R5T.T0150;


namespace R5T.T0010
{
    [StrongTypeMarker]
    public class SourceControlRepositoriesOrganizationName : TypedString
    {
        #region Static

        public static SourceControlRepositoriesOrganizationName From(string sourceControlRepositoriesOrganizationNameValue)
        {
            var remoteRepositoryUrl = new SourceControlRepositoriesOrganizationName(sourceControlRepositoriesOrganizationNameValue);
            return remoteRepositoryUrl;
        }

        #endregion


        public SourceControlRepositoriesOrganizationName(string value)
            : base(value)
        {
        }
    }
}
