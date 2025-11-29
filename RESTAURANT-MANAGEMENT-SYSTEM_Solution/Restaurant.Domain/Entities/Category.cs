using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain.Entities
{
	public class Category
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		[StringLength(200)]
		public string Name { get; set; }

		public List<MenuItem> MenuItems { get; set; }= new List<MenuItem>();
		/*MenuItems لازم يكون لها default initialization

		ليه؟
		لو فضلت null، ممكن يحصل:

		NullReferenceException لما تعمل إضافة

		مشاكل عند load navigation

		EF Core ساعات ي expect collection موجودة*/
	}
}
