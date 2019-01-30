﻿using Microsoft.AspNetCore.Routing;
using RoastedMarketplace.Data.Entity.Pages;

namespace RoastedMarketplace.Infrastructure.Routing
{
    public interface IDynamicRouteProvider
    {
        DynamicRoute GetDynamicRoute(SeoMeta seoMeta, string requestPath);

        VirtualPathData GetVirtualPathData(IRouter router, VirtualPathContext context);
    }
}