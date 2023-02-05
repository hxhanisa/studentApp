using System;
namespace StudentApp.Data.Models;

public class Purchase
{
    public int Id { get; set; }
    public string ClientName { get; set; }
    public string ProductName { get; set; }
    public DateTime PurchaseDate { get; set; }
}