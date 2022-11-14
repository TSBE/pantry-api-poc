//using System.Data;
//using System.Linq;
//using System.Security.Claims;
//using System.Security.Principal;
//using Opw.HttpExceptions;

//namespace Pantry.Features.WebFeature.Security
//{
//    public static class ClaimsPrincipalHelper
//    {
//        public static string? GetClientId(this IPrincipal principal)
//            => principal.GetClaim(CustomClaimTypes.CLIENTIDENTIFIER);

//        public static string? GetTokenIdentifier(this IPrincipal principal)
//            => principal.GetClaim(CustomClaimTypes.TOKENIDENTIFIER);

//        public static string? GetIssuedAt(this IPrincipal principal)
//            => principal.GetClaim(CustomClaimTypes.ISSUEDAT);

//        public static string? GetExpireAt(this IPrincipal principal)
//            => principal.GetClaim(CustomClaimTypes.EXPIREAT);

//        public static string? GetIssuer(this IPrincipal principal)
//            => principal.GetClaim(CustomClaimTypes.ISSUER);

//        public static string[]? GetScopes(this IPrincipal principal)
//            => principal.GetClaim(CustomClaimTypes.SCOPES)?.Split(new[] { ' ', ',' });

//        public static long? GetKlpId(this IPrincipal principal)
//            => principal.Identity?.GetKlpId();

//        public static long GetKlpIdOrThrow(this IPrincipal principal)
//            => principal.Identity?.GetKlpIdOrThrow()
//            ?? throw new ForbiddenException(nameof(principal.Identity));

//        public static string? GetClaim(this IPrincipal principal, string claimType) =>
//             (principal.Identity as ClaimsIdentity)?.Claims
//             .Where(e => e.Type == claimType)
//             .Select(e => e.Value).FirstOrDefault() ?? default;

//        public static bool HasScope(this IPrincipal principal, string scope)
//        {
//            var scopes = principal.GetScopes();
//            return scopes?.Length > 0 && scopes.Any(scope.Contains);
//        }
//    }
//}
