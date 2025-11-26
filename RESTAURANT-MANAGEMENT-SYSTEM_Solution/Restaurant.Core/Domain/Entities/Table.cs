using Restaurant.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Domain.Entities
{
	public class Table
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		[StringLength(200)]
		public string Number { get; set; }= string.Empty;
		[Range(1,30)]
		public int Seats { get; set; }
		[Required]
		public TableStatusEnum TableStatus { get; set; } = TableStatusEnum.Free;

		//public bool IsAvailable { get; set; } = true;

		//public List<Reservation> Reservations { get; set; } = new List<Reservation>();

		public List<Order> Orders { get; set; } = new List<Order>();

	}
}
