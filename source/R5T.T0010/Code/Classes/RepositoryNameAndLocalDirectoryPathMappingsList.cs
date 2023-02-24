using System;
using System.Collections.Generic;

using R5T.Magyar;

using R5T.T0142;


namespace R5T.T0010
{
    [DataTypeMarker]
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
