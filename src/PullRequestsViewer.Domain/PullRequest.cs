﻿using System;

namespace PullRequestsViewer.Domain
{
    /// <summary>
    /// Pull Request.
    /// </summary>
    public class PullRequest
    {
        /// <summary>
        /// Title.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The HTML URL.
        /// </summary>
        public Uri HtmlUrl { get; set; }
        /// <summary>
        /// Author name.
        /// </summary>
        public string AuthorName { get; set; }
        /// <summary>
        /// Number.
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// The created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// The last update date.
        /// </summary>
        public DateTime LastUpdateDate { get; set; }
    }
}