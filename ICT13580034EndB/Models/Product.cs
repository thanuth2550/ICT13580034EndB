using System;
using SQLite;

namespace ICT13580034EndB.Models
{
    public class Product
    {
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public String Type { get; set; }
		public String Yehor { get; set; }

		[MaxLength(100)]
		public String Genalation { get; set; }
		public int Year { get; set; }
		public int Mile { get; set; }
		public String Color { get; set; }
		public String Deler { get; set; }
		public string Detail { get; set; }
		public decimal Price { get; set; }
		public string Provice { get; set; }
		public string Phone { get; set; }
    }
}
