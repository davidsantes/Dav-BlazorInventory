using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Productos
    /// </summary>
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }

        // Relación con Categoría: 1 - 1
        // Propiedades que enlazan a categoría, un producto pertenece a una categoría específica
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        // Relación con Almacenamiento: 1 - N. 
        // Un producto puede tener varios almacenamientos
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
