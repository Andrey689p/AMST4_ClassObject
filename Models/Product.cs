using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST4_ClassObject.Models
{
	public class Product : EntityBase
	{
		public Product(string description, double price)
		{
			Description = description;
			Price = price;
		}
		public string Description { get; private set; } = string.Empty;
		public double Price { get; private set; }

	}
}