using System.ComponentModel.DataAnnotations;

namespace CZ.Domain
{
    public class User : BaseEntity
    {
        [StringLength(20)]
        public string Name { get; set; }
     
        [StringLength(20)]
        public string DNI { get; set; }
        
        public string Password { get; set; }
    }
}
