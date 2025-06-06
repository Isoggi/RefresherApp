using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RefresherApp.Domain.Entities
{
    public class Examples
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int KeyId { get; set; }
        public Guid Id { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
