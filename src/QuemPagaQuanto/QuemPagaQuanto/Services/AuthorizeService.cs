using System.Security.Claims;
using QuemPagaQuanto.Models;

namespace QuemPagaQuanto.Services;

public static class AuthorizeService
{
    public static int GetUserId(ClaimsPrincipal userClaimsPrincipal)
    {
        return int.Parse(userClaimsPrincipal.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value);
    }

    public static string GetUserRole(ClaimsPrincipal userClaimsPrincipal)
    {
        return userClaimsPrincipal.Claims.First(claim => claim.Type == ClaimTypes.Role).Value;
    }

    public static bool IsAdmin(ClaimsPrincipal userClaimsPrincipal)
    {
        return userClaimsPrincipal.Claims.First(claim => claim.Type == ClaimTypes.Role).Value ==
               nameof(Perfil.Administrador);
    }
}