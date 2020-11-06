using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Bodegas
    /// </summary>
    public class WarehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseAddress { get; set; }

        // Relación con almacenamiento: 1 - N. 
        // Una bodega (Warehouse) tiene N almacenamientos
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
