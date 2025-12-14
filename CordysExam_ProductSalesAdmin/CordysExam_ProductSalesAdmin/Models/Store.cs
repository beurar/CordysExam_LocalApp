using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CordysExam_ProductSalesAdmin.Models;

public partial class Store
{
    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(200)]
    public string? Address { get; set; }

    [StringLength(20)]
    public string? Tel { get; set; }

    [InverseProperty("Store")]
    public virtual ICollection<ProductSale> ProductSales { get; set; } = new List<ProductSale>();
}
