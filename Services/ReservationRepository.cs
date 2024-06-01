
public class ReservationRepository : IReservationRepository
{
    private GraphQLDbContext _graphQLDbContext;
    public ReservationRepository(GraphQLDbContext graphQLDbContext)
    {
        _graphQLDbContext = graphQLDbContext;
    }
    public Reservation AddReservation(Reservation reservation)
    {
        _graphQLDbContext.Reservations.Add(reservation);
        _graphQLDbContext.SaveChanges();
        return reservation;
    }

    public List<Reservation> GetReservations()
    {
        return _graphQLDbContext.Reservations.ToList();
    }
}