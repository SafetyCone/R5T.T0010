using System;


namespace R5T.T0010
{
    public static class Constants
    {
        public const string GitName = "git";

        /// <summary>
        /// Includes ':' and '@'.
        /// </summary>
        public static char[] RemoteRepositoryLocationTypeTokenSeparators { get; } = new[] { ':', '@' };
    }
}
