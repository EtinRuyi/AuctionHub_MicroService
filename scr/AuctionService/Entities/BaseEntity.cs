using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

public class BaseEntity
{
    [Required]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public string Id { get; set; } = Guid.NewGuid().ToString();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
