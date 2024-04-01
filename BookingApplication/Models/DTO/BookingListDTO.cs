namespace BookingApplication.Models.DTO
{
    public class BookingListDTO
    {
        public List<BookReservation> AllReservations { get; set; }
        public double TotalPrice { get; set; }
    }
}
