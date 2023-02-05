using System;
using Microsoft.EntityFrameworkCore;
using StudentApp.Data.Models;

namespace StudentApp.Data;

public class AppDbConext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=Main.db");

    public DbSet<Purchase> Purchases { get; set; }
}