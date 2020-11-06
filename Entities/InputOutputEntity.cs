using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Movimientos: entradas o salidas
    /// </summary>
    public class InputOutputEntity
    {
        [Key]
        [StringLength(50)]
        public string InOutId { get; set; }

        [Required]
        public DateTime InOutDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool IsInput { get; set; }

        // Relación con Almacenamiento: 1 - 1
        // Propiedades que enlazan a almacenamiento, una entrada o salida pertenece a un almacenamiento específico
        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; }
    }
}
