using System;
using System.Collections.Generic;


namespace R5T.T0010
{
    public class NonFastForwardableLocalRepositoriesList : LocalRepositoriesList
    {
        public NonFastForwardableLocalRepositoriesList()
        {
        }

        public NonFastForwardableLocalRepositoriesList(List<LocalRepositoryDirectoryPath> repositoryDirectoryPaths)
            : base(repositoryDirectoryPaths)
        {
        }
    }
}
