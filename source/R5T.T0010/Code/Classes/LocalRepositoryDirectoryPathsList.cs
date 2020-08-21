using System;
using System.Collections.Generic;


namespace R5T.T0010
{
    public class LocalRepositoryDirectoryPathsList
    {
        public List<LocalRepositoryDirectoryPath> LocalRepositoryDirectoryPaths { get; } = new List<LocalRepositoryDirectoryPath>();


        public LocalRepositoryDirectoryPathsList()
        {
        }

        public LocalRepositoryDirectoryPathsList(IEnumerable<LocalRepositoryDirectoryPath> localRepositoryDirectoryPaths)
        {
            this.LocalRepositoryDirectoryPaths.AddRange(localRepositoryDirectoryPaths);
        }
    }
}
