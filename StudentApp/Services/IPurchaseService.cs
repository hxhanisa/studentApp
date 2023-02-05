using System;
using StudentApp.Data.ViewModels;
using StudentApp.Data.Models;

namespace StudentApp.Services;

public interface IPurchaseService
{
    List<Purchase> GetAllPurchases();
    Purchase GetPurchaseById(int id);
    Purchase AddPurchase(PurchaseVM purchaseVM);
    void DeletePurchaseById(int id);
    Purchase UpdatePurchase(PurchaseVM purchaseVM, int id);
}
