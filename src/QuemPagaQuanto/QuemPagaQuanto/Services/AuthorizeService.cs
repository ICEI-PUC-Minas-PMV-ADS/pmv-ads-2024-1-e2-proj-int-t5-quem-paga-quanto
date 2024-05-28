using System.Security.Claims;

namespace QuemPagaQuanto.Services;

public static class AuthorizeService
{
    public static int GetUserId(ClaimsPrincipal userClaimsPrincipal)
    {
        return int.Parse(userClaimsPrincipal.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value);
    }
}