namespace TasteTrailIdentityManager.Api.Common.Extensions.ServiceCollectionExtensions;

using TasteTrailIdentityManager.Core.Authentication.Services;
using TasteTrailIdentityManager.Core.Common.Tokens.RefreshTokens.Repositories;
using TasteTrailIdentityManager.Core.Common.Tokens.RefreshTokens.Services;
using TasteTrailIdentityManager.Core.Roles.Services;
using TasteTrailIdentityManager.Core.Users.Services;
using TasteTrailIdentityManager.Infrastructure.Authentication.Services;
using TasteTrailIdentityManager.Infrastructure.Common.RefreshTokens.Repositories.Ef_Core;
using TasteTrailIdentityManager.Infrastructure.Common.RefreshTokens.Services;
using TasteTrailIdentityManager.Infrastructure.Roles.Services;
using TasteTrailIdentityManager.Infrastructure.Users.Services;

public static class RegisterDpInjectionMethod
{
    public static void RegisterDpInjection(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IUserService, UserService>();
        serviceCollection.AddTransient<IRoleService, RoleService>();
        serviceCollection.AddTransient<IIdentityAuthService, IdentityAuthService>();

        serviceCollection.AddTransient<IRefreshTokenRepository, RefreshTokenEfCoreRepository>();
        serviceCollection.AddTransient<IRefreshTokenService, RefreshTokenService>();
    } 
}
