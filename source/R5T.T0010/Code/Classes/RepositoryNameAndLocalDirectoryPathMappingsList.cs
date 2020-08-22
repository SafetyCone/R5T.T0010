using System;
using System.Collections.Generic;

using R5T.Magyar;


namespace R5T.T0010
{
    public class RepositoryNameAndLocalDirectoryPathMappingsList : TypedList<RepositoryNameAndLocalDirectoryPathMapping>
    {
        public RepositoryNameAndLocalDirectoryPathMappingsList()
        {
        }

        public RepositoryNameAndLocalDirectoryPathMappingsList(IEnumerable<RepositoryNameAndLocalDirectoryPathMapping> values)
            : base(values)
        {
        }
    }
}
