using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Categorías
    /// </summary>
    public class CategoryEntity
    {
        [Key]
        [StringLength(50)]
        public string CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        // Relación con productos: 1 - N. 
        // Una categoría tiene N productos
        public ICollection<ProductEntity> Products { get; set; }
    }
}
