using System;

using R5T.Stagira;

using R5T.T0150;


namespace R5T.T0010
{
    [StrongTypeMarker]
    public class SourceControlRootDirectoryPath : TypedString
    {
        #region Static

        public static SourceControlRootDirectoryPath From(string sourceControlRootDirectoryPathValue)
        {
            var sourceControlRootDirectoryPath = new SourceControlRootDirectoryPath(sourceControlRootDirectoryPathValue);
            return sourceControlRootDirectoryPath;
        }

        #endregion


        public SourceControlRootDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
