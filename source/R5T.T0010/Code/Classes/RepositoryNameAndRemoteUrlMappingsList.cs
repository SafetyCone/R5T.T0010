using System;
using System.Collections.Generic;

using R5T.Magyar;

using R5T.T0142;


namespace R5T.T0010
{
    [DataTypeMarker]
    public class RepositoryNameAndRemoteUrlMappingsList : TypedList<RepositoryNameAndRemoteUrlMapping>
    {
        public RepositoryNameAndRemoteUrlMappingsList()
        {
        }

        public RepositoryNameAndRemoteUrlMappingsList(IEnumerable<RepositoryNameAndRemoteUrlMapping> values)
            : base(values)
        {
        }
    }
}
