﻿using System.Net;

namespace Piwik.Tracker
{
    /// <summary>
    /// Represents the result of a tracking action.
    /// </summary>
    public class TrackingResponse
    {

        /// <summary>
        /// Gets the HTTP status code recived from the piwik server.
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; internal set; }
    }
}