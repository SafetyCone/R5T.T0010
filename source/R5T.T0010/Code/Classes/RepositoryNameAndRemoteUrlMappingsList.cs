using System;
using System.Collections.Generic;

using R5T.Magyar;


namespace R5T.T0010
{
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
