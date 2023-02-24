using System;
using System.Collections.Generic;

using R5T.T0142;


namespace R5T.T0010
{
    [DataTypeMarker]
    public class NonFastForwardableLocalRepositoriesList : LocalRepositoryDirectoryPathsList
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
