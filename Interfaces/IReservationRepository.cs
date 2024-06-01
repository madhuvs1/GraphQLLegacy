public interface IReservationRepository {
     Reservation AddReservation(Reservation reservation);
     List<Reservation> GetReservations();
    Reservation GetReservation(int reservationId);
}
