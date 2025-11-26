using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Restaurant.Core.Domain.Entities
{
	public class MenuItem
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		[StringLength(200)]
		public string Name { get; set; }
		[StringLength(1000)]
		public string? Description { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		[Range(0.0, double.MaxValue)]
		public decimal Price { get; set; }

		public bool IsAvailable { get; set; } = true;
		public Guid CategoryId { get; set; }
		public Category? Category { get; set; }
	}
}
