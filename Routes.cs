﻿using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Routes;

namespace SkyWin {
    public class Routes : IRouteProvider {
        public void GetRoutes(ICollection<RouteDescriptor> routes) {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes() {
            return new[] {
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route(
                        "SkyWin",
                        new RouteValueDictionary {
                            {"area", "SkyWin"},
                            {"controller", "Home"},
                            {"action", "Index"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", "SkyWin"}
                        },
                        new MvcRouteHandler())
                }
            };
        }
    }
}