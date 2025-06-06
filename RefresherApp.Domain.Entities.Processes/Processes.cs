using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RefresherApp.Domain.Entities.Processes;

public class Processes
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int KeyId { get; set; }
    public Guid Id { get; set; }
    [Required]
    public string ProcessName { get; set; }
    [Required]
    public bool IsDone { get; set; } 
    public dynamic? Data { get; set; }
    public DateTimeOffset? StartedAt { get; set; }
    public DateTimeOffset? FinishedAt { get; set; }
}