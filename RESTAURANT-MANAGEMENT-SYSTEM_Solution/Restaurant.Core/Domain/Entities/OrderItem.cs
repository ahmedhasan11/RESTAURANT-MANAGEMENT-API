using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Domain.Entities
{
	public class OrderItem
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		[StringLength(200)]
		public string Name { get; set; }

		[Required]
		[Range(1, int.MaxValue)]
		public int Quantity { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		[Range(0.0, double.MaxValue)]
		public decimal UnitPrice { get; set; }
		[Required]
		[Column(TypeName = "decimal(18,2)")]
		[Range(0.0, double.MaxValue)]
		public decimal TotalPrice { get; set; }

		[Required]
		public Guid MenuItemId { get; set; }
		public MenuItem? MenuItem { get; set; }

		[Required]
		public Guid OrderId { get; set; }
		public Order? Order { get; set; }
	}
}
