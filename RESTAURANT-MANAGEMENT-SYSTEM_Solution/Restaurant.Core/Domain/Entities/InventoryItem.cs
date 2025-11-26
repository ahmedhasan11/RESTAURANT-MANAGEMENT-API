using Restaurant.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Domain.Entities
{
	/*ده بيعبر عن كل حاجة موجودة في المطبخ:
طماطم – بطاطس – زيت – رز – دجاج – مشروبات – إلخ.*/
	public class InventoryItem
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		[StringLength(200)]
		public string Name { get; set; }

		[StringLength(200)]
		public string? Description { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,3)")]
		[Range(0.0, double.MaxValue)]
		public decimal Quantity { get; set; }

		[Required]
		public UnitEnum Unit { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,3)")]
		[Range(0.0, double.MaxValue)]
		public decimal MinimumQuantity { get; set; }

		public DateTime LastUpdated { get; set; }= DateTime.UtcNow;


	}
}
