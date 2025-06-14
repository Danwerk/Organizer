using System.ComponentModel.DataAnnotations;

namespace Base.Contracts.Domain;

public interface IDomainMeta
{
    [MaxLength(64)]
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }

    [MaxLength(64)]
    public string? ChangedBy { get; set; }
    public DateTime? ChangedAt { get; set; }

    // hidden information about the record in db
    // public string? SysNotes { get; set; }

}