//using System.Linq;
//using System.Security.Claims;
//using System.Security.Principal;
//using Opw.HttpExceptions;

//namespace Pantry.Features.WebFeature.Security
//{
//    public static class ClaimsIdentityHelper
//    {
//        public static long? GetKlpId(this IIdentity identity) =>
//            ((ClaimsIdentity)identity).GetKlpId();

//        public static long GetKlpIdOrThrow(this IIdentity identity)
//            => identity?.GetKlpId()
//            ?? throw new ForbiddenException(nameof(identity));

//        public static long? GetKlpId(this ClaimsIdentity identity)
//        {
//            var value = identity.Claims.SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
//            return long.TryParse(value, out var klpId) ? klpId : default;
//        }
//    }
//}
