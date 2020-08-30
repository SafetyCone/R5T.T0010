using System;


namespace R5T.T0010
{
    public class RepositoryNameAndRemoteUrlMapping
    {
        public RepositoryName RepositoryName { get; set; }
        public RemoteRepositoryUrl RemoteRepositoryUrl { get; set; }


        public RepositoryNameAndRemoteUrlMapping()
        {
        }

        public RepositoryNameAndRemoteUrlMapping(
            RepositoryName repositoryName,
            RemoteRepositoryUrl remoteRepositoryUrl)
        {
            this.RepositoryName = repositoryName;
            this.RemoteRepositoryUrl = remoteRepositoryUrl;
        }
    }
}
