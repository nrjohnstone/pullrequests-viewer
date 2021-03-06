﻿using Octokit;
using PullRequestsViewer.Domain;
using PullRequestsViewer.Domain.Interfaces;
using PullRequestsViewer.GitHub.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PullRequestsViewer.GitHub
{
    /// <summary>
    /// GitHub organisation's repository.
    /// </summary>
    public class OrganisationRepository : IOrganisationRepository
    {
        private readonly IGitHubClient _gitHubClient;

        /// <summary>
        /// Default ctor.
        /// </summary>
        /// <param name="gitHubClient">The GitHub client.</param>
        public OrganisationRepository(IGitHubClient gitHubClient)
        {
            _gitHubClient = gitHubClient;
        }

        /// <inheritdoc />
        public async Task<IReadOnlyList<Organisation>> GetOrganisationsAsync()
        {
            var organisations = await _gitHubClient.Organization.GetAllForCurrent();

            return organisations.ConvertToDomain();
        }
    }
}