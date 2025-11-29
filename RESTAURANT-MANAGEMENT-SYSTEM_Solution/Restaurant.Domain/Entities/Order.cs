using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain.Entities
{
	public class Order
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		public Guid TableId { get; set; }
		public Table? Table { get; set; }

		[Required]
		public Guid UserId { get; set; }
		//public ApplicationUser? User { get; set; }

		public DateTime CreatedAt { get; set; }= DateTime.UtcNow;

		[Required]
		public OrderStatusEnum OrderStatus { get; set; }= OrderStatusEnum.New;


		[Required]
		public decimal TotalAmount { get; set; }

		public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
	}
}
