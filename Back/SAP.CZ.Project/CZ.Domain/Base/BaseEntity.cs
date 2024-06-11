using System.ComponentModel.DataAnnotations;

namespace CZ.Domain
{
    public class BaseEntity
    {
        [Required]
        public int Id { get; set; }
    }
}
