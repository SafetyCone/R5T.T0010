using System;

using R5T.T0142;


namespace R5T.T0010
{
    [DataTypeMarker]
    public class RepositoryNameAndLocalDirectoryPathMapping
    {
        public RepositoryName RepositoryName { get; set; }
        public LocalRepositoryDirectoryPath LocalRepositoryDirectoryPath { get; set; }


        public RepositoryNameAndLocalDirectoryPathMapping()
        {
        }

        public RepositoryNameAndLocalDirectoryPathMapping(
            RepositoryName repositoryName,
            LocalRepositoryDirectoryPath localRepositoryDirectoryPath)
        {
            this.RepositoryName = repositoryName;
            this.LocalRepositoryDirectoryPath = localRepositoryDirectoryPath;
        }
    }
}
