using Base.Contracts.Domain;

namespace Base.Domain.Identity;
using Microsoft.AspNetCore.Identity;

public abstract class BaseRole<TUserRole> : BaseRole<Guid, TUserRole>, IDomainId
where TUserRole : class 
{
    public BaseRole() : base()
    {
        
    }

    public BaseRole(string role) : base(role)
    {
        
    }
}

public abstract class BaseRole<TKey, TUserRole> : IdentityRole<TKey>, IDomainId<TKey>
    where TKey :  IEquatable<TKey>
    where TUserRole : class
{
    public virtual ICollection<TUserRole>? UserRoles { get; set; }

    public BaseRole() : base()
    {
        
    }

    public BaseRole(string role) : base(role)
    {
        
    }
    
}