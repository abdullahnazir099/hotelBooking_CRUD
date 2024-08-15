using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Booking.Models
{
	public class Book
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(100)]
		[Display(Name = "Name")]
		[DataType(DataType.Text)]
		public string? Name { get; set; }

		[Required]
		[Display(Name = "Number of guest")]
		[DataType(DataType.Text)]
		public int Guest { get; set; }

		[Required]
		[MaxLength(100)]
		[Display(Name = "Arival Date")]
		[DataType(DataType.Date)]

		public string? Arival_date { get; set; }
		[Required]
		[MaxLength(500)]
		[Display(Name = "Departure date")]
		[DataType(DataType.Date)]
		public string? Departure_date { get; set; }
		[Required]
		[MaxLength(100)]
		[Display(Name = "Bed type")]
		[DataType(DataType.Text)]
		public string? Bed_type { get; set; }
		[Required]
		[MaxLength(100)]
		[Display(Name = "Card info")]
		[DataType(DataType.CreditCard)]
		public string? Card { get; set; }

		[Required]
		[Display(Name = "Phone")]
		[DataType(DataType.PhoneNumber)]
		public int Phone { get; set; }
		[Required]
		[MaxLength(100)]
		[Display(Name = "Email")]
		[DataType(DataType.EmailAddress)]
		public string? Email { get; set; }
	}
}
