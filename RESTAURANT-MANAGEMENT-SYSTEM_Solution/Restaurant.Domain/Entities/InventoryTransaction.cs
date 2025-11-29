using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain.Entities
{
	public class InventoryTransaction
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		public Guid InventoryItemId { get; set; }
		public InventoryItem? InventoryItem { get; set; }
		[Required]
		public InventoryTransactionTypeEnum TransactionType { get; set; }
		[Required]
		[Column(TypeName = "decimal(18,3)")]
		public decimal QuantityChange { get; set; } //        // Positive = Purchase, Negative = Consumption
													
		[Column(TypeName = "decimal(18,3)")]
		public decimal BalanceAfter { get; set; } // Quantity of the item AFTER this transaction
		public string? Reason { get; set; } //like transaction type

		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


	}
}
