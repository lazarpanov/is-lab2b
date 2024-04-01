using System.ComponentModel.DataAnnotations;

namespace BookingApplication.Models
{
    public class BookingList
    {
        [Key]
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }

        public virtual ICollection<BookReservation>? BookReservations { get; set; }
    }
}
