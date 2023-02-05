using System;
using StudentApp.Data;

namespace StudentApp.Services;

public class PurchaseService : IPurchaseService
{
	readonly AppDbConext _db;
    public PurchaseService(AppDbConext dbContext)
	{
		_db = dbContext;
	}
}

