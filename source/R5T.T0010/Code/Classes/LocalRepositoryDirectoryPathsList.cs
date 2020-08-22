using System;
using System.Collections.Generic;

using R5T.Stagira;


namespace R5T.T0010
{
    public class LocalRepositoryDirectoryPathsList : TypedStringsList<LocalRepositoryDirectoryPath>
    {
        public List<LocalRepositoryDirectoryPath> LocalRepositoryDirectoryPaths => this.Values;


        public LocalRepositoryDirectoryPathsList()
        {
        }

        public LocalRepositoryDirectoryPathsList(IEnumerable<LocalRepositoryDirectoryPath> values)
            : base(values)
        {
        }
    }
}
