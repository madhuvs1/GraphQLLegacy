using GraphQL.Types;

public class ReservationInputType: InputObjectGraphType<Reservation>
{
    public ReservationInputType()
    {
        Field<IntGraphType>("id");
        Field<StringGraphType>("customerName");
        Field<StringGraphType>("email");
        Field<StringGraphType>("phoneNumber");
        Field<IntGraphType>("partySize");
        Field<StringGraphType>("specialRequest");
        Field<DateTimeGraphType>("reservationDate");
    }
}