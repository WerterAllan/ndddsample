﻿namespace NDDDSample.Domain.Service
{
    using System.Collections.Generic;
    using Model.Cargos;

    /// <summary>
    ///  Routing service.
    /// </summary>
    public interface IRoutingService
    {
        /// <summary>
        /// Fetch Routes For Specification
        /// </summary>
        /// <param name="routeSpecification">route specification</param>
        /// <returns>A list of itineraries that satisfy the specification. May be an empty list if no route is found.</returns>
        List<Itinerary> FetchRoutesForSpecification(RouteSpecification routeSpecification);
    }
}