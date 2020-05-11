using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmoPieShop.Models
{
	public class Pie
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public string ImageThumbnailUrl { get; set; }
		public bool IsPieOfTheWeek { get; set; }
		public bool IsInStock { get; set; }
	}
}
