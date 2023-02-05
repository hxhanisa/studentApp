using System;
using Microsoft.EntityFrameworkCore;
using StudentApp.Data;
using StudentApp.Data.Models;
using StudentApp.Data.ViewModels;

namespace StudentApp.Services;

public class PurchaseService : IPurchaseService
{
	readonly AppDbConext _dbContext;
    public PurchaseService(AppDbConext dbContext)
	{
        _dbContext = dbContext;
	}

    public Purchase AddPurchase(PurchaseVM purchaseVM)
    {
        var book = new Purchase()
        {
            ClientName = purchaseVM.ClientName,
            ProductName = purchaseVM.ProductName,
            PurchaseDate = purchaseVM.PurchaseDate,
        };

        _dbContext.Purchases.Add(book);
        _dbContext.SaveChanges();
        return book;
    }

    public void DeletePurchaseById(int id)
    {
        var purchase = _dbContext.Purchases.FirstOrDefault(n => n.Id == id);
        _dbContext.Purchases.Remove(purchase!);
        _dbContext.SaveChanges();
    }

    public List<Purchase> GetAllPurchases()
    {
        var allBooks = _dbContext.Purchases.ToList();
        return allBooks;
    }

    public Purchase GetPurchaseById(int id)
    {
        var book = _dbContext.Purchases.Where(n => n.Id == id).FirstOrDefault();
        return book!;
    }

    public Purchase UpdatePurchase(PurchaseVM purchaseVM, int id)
    {
        var purchase = _dbContext.Purchases.Where(n => n.Id == id).FirstOrDefault();

        purchase!.ClientName = purchaseVM.ClientName;
        purchase!.ProductName = purchaseVM.ProductName;
        purchase!.PurchaseDate = purchaseVM.PurchaseDate;

        _dbContext.Purchases.Update(purchase!);
        _dbContext.SaveChanges();

        return purchase;
    }
}
