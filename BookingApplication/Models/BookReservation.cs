using System.ComponentModel.DataAnnotations;

namespace BookingApplication.Models
{
    public class BookReservation
    {
        [Key]
        public Guid Id { get; set; }
        public int NumberOfNights { get; set; }

        // Navigation property for Reservation
        public Reservation? Reservation { get; set; }
        // Foreign key for Reservation
        public Guid ReservationId { get; set; }

        public BookingList? BookingList { get; set; }
        public Guid BookingListId { get; set; }
    }
}