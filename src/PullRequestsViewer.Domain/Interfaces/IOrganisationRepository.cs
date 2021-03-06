﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace PullRequestsViewer.Domain.Interfaces
{
    /// <summary>
    /// Organisation repository interface.
    /// </summary>
    public interface IOrganisationRepository
    {
        /// <summary>
        /// Returns the user organisations.
        /// </summary>
        /// <returns>The organisations which the user have access.</returns>
        Task<IReadOnlyList<Organisation>> GetOrganisationsAsync();
    }
}