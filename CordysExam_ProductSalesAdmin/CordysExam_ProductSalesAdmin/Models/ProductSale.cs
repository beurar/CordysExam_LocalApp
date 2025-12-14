using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CordysExam_ProductSalesAdmin.Models;

public partial class ProductSale
{
    [Key]
    [Column("SaleID")]
    public int SaleId { get; set; }

    [Column("ProductID")]
    public int ProductId { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    public DateOnly SaleDate { get; set; }

    public int Quantity { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductSales")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("StoreId")]
    [InverseProperty("ProductSales")]
    public virtual Store Store { get; set; } = null!;
}
