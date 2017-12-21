using System;
using System.Collections.Generic;
using ICT13580034EndB.Models;
using SQLite;
namespace ICT13580034EndB.Helpers
{
    public class DbHelper
    {
		SQLiteConnection db;

		public DbHelper(string dbPath)
		{
			db = new SQLiteConnection(dbPath);
			db.CreateTable<Product>();
		}

		public int AddProduct(Product product)
		{
			db.Insert(product);
			return product.Id;
		}


    }
}
