﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class BookShopEntities : DbContext
{
    public BookShopEntities()
        : base("name=BookShopEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Books> Books { get; set; }
    public virtual DbSet<Customers> Customers { get; set; }
    public virtual DbSet<Orderitems> Orderitems { get; set; }
    public virtual DbSet<Orders> Orders { get; set; }
    public virtual DbSet<accounts> accounts { get; set; }
}
