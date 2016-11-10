﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class accounts
{
    public int ID { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public string hashedpassword { get; set; }
}

public partial class Books
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Books()
    {
        this.Orderitems = new HashSet<Orderitems>();
    }

    public int id { get; set; }
    public string name { get; set; }
    public Nullable<int> year { get; set; }
    public string author { get; set; }
    public string country { get; set; }
    public Nullable<decimal> price { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Orderitems> Orderitems { get; set; }
}

public partial class Customers
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Customers()
    {
        this.Orders = new HashSet<Orders>();
    }

    public int id { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Orders> Orders { get; set; }
}

public partial class Orderitems
{
    public int id { get; set; }
    public int orderid { get; set; }
    public int bookid { get; set; }
    public int count { get; set; }

    public virtual Books Books { get; set; }
    public virtual Orders Orders { get; set; }
}

public partial class Orders
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Orders()
    {
        this.Orderitems = new HashSet<Orderitems>();
    }

    public int oid { get; set; }
    public System.DateTime odate { get; set; }
    public int customerid { get; set; }

    public virtual Customers Customers { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Orderitems> Orderitems { get; set; }
}