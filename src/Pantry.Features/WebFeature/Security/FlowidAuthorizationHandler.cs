//using System;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Routing;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Logging;
//using Pantry.Core.Persistence;

//namespace Pantry.Features.WebFeature.Security;

//public class FlowidAuthorizationHandler : AuthorizationHandler<FlowidRequirement>
//{
//    private readonly ILogger<FlowidAuthorizationHandler> _logger;

//    private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

//    public FlowidAuthorizationHandler(
//        ILogger<FlowidAuthorizationHandler> logger,
//        IDbContextFactory<AppDbContext> dbContextFactory)
//    {
//        _logger = logger;
//        _dbContextFactory = dbContextFactory;
//    }

//    protected override async Task HandleRequirementAsync(
//        AuthorizationHandlerContext context, FlowidRequirement requirement)
//    {
//        if (context.Resource is HttpContext httpContext)
//        {
//            RouteData? routedata = httpContext.GetRouteData();
//            var klpId = httpContext.User.GetKlpId();

//            if (
//                routedata?.Values.TryGetValue("flowid", out var flowidObject) == true
//                && Guid.TryParse((string?)flowidObject, out var flowid) == true
//                && klpId is not null
//                && klpId > 0)
//            {
//                using AppDbContext appDbContext = _dbContextFactory.CreateDbContext();
//                var isOwner = await appDbContext.Reports.AnyAsync(r => r.FlowId == flowid && r.KlpId == klpId);

//                if (isOwner == true)
//                {
//                    context.Succeed(requirement);
//                }
//            }
//        }
//    }
//}
