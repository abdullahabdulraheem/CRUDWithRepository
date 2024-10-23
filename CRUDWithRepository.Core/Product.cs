using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDWithRepository.Core;

public class Product
{
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string ProductName { get; set; } = default!;
    [Required]
    public decimal Price { get; set; }
    [Required]
    public int Qty { get; set; }
}
