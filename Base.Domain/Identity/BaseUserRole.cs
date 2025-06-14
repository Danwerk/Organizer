using Microsoft.AspNetCore.Identity;

namespace Base.Domain.Identity;

public abstract class BaseUserRole<TUser, TRole> : BaseUserRole<Guid, TUser, TRole>
where TUser : class 
where TRole : class
{
    
}

public abstract class BaseUserRole<TKey, TUser, TRole> : IdentityUserRole<TKey>
    where TKey : IEquatable<TKey>
    where TUser : class
    where TRole : class
{
    public virtual TUser? User { get; set; }
    public virtual TRole? Role { get; set; }
}