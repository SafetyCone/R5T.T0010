using System;


namespace R5T.T0010
{
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
