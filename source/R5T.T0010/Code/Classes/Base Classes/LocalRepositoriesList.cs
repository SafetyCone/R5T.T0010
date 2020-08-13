using System;
using System.Collections.Generic;


namespace R5T.T0010
{
    public class LocalRepositoriesList
    {
        public List<LocalRepositoryDirectoryPath> LocalRepositoryDirectoryPaths { get; }


        public LocalRepositoriesList(List<LocalRepositoryDirectoryPath> repositoryDirectoryPaths)
        {
            this.LocalRepositoryDirectoryPaths = repositoryDirectoryPaths;
        }

        public LocalRepositoriesList()
            : this(new List<LocalRepositoryDirectoryPath>())
        {
        }
    }
}
