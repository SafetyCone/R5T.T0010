using System;

using R5T.Stagira;


namespace R5T.T0010
{
    public class RevisionIdentity : TypedString
    {
        #region Static

        public static RevisionIdentity From(string revisionIdentityValue)
        {
            var revisionIdentity = new RevisionIdentity(revisionIdentityValue);
            return revisionIdentity;
        }

        #endregion


        public RevisionIdentity(string value)
            : base(value)
        {
        }
    }
}
