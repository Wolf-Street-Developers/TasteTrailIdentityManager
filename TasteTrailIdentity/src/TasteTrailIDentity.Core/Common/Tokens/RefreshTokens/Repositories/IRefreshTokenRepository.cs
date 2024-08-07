using TasteTrail.Data.src.Core.Common.Repositories.Base;
using TasteTrailData.Core.Common.Tokens.RefreshTokens.Entities;

namespace TasteTrailIdentity.Core.Common.Tokens.RefreshTokens.Repositories;

public interface IRefreshTokenRepository : IDeleteByIdAsync<Guid>, ICreateAsync<RefreshToken, Guid>, IGetByIdAsync<RefreshToken, Guid>
{
    public Task<int> DeleteRangeRefreshTokensAsync(string userId);
}

