﻿using System;

namespace LtiLibrary.Core.Outcomes
{
    /// <summary>
    /// Represents the Outcomes Management interface introduced in LTI 1.1.
    /// </summary>
    [Obsolete("Use LtiLibrary.Core.Outcomes.v1.IOutcomesManagementRequest")]
    public interface IOutcomesManagementRequest
    {
        string LisOutcomeServiceUrl { get; set; }
        string LisResultSourcedId { get; set; }
        string ImsxPoxEnvelope { get; set; }
    }
}
