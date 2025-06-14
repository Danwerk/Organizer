using Base.Contracts.Domain;
using Microsoft.AspNetCore.Identity;

namespace Base.Domain.Identity;

public abstract class BaseUser<TUserRole> : BaseUser<Guid, TUserRole>, IDomainId
where TUserRole : class 
{
    
}

public abstract class BaseUser<TKey, TUserRole> : IdentityUser<TKey>, IDomainId<TKey>
    where TKey : IEquatable<TKey>
    where TUserRole : class
{
    public virtual ICollection<TUserRole>? UserRoles { get; set; }
}