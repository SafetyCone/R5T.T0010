﻿using System;
using System.Collections.Generic;


namespace R5T.T0010
{
    public class LocalRepositoriesWithRemoteUpdatesList : LocalRepositoriesList
    {
        public LocalRepositoriesWithRemoteUpdatesList()
        {
        }

        public LocalRepositoriesWithRemoteUpdatesList(List<LocalRepositoryDirectoryPath> repositoryDirectoryPaths)
            : base(repositoryDirectoryPaths)
        {
        }
    }
}
