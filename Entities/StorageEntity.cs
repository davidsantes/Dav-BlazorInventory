using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Almacenamiento
    /// </summary>
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        // Relación con Producto: 1 - 1
        // Propiedades que enlazan a producto, un almacenamiento es de un producto concreto
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        // Relación con bodegas (WarehouseEntity): 1 - 1
        // Propiedades que enlazan a bodega, un almacenamiento es de una bodega concreta
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        // Relación con movimientos: 1 - N. 
        // Un almacenamiento puede tener varias entradas y salidas
        public ICollection<InputOutputEntity> InputOutputs { get; set; }
    }
}
