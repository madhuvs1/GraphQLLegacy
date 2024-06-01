using GraphQL;
using GraphQL.Types;

public class ReservationMutation: ObjectGraphType {
    public ReservationMutation(IReservationRepository reservationRepository)
    {
        Field<ReservationType>("AddReservation").Arguments(new QueryArguments {new QueryArgument<ReservationInputType> { Name = "reservation"} })
        .Resolve(context => {return reservationRepository.AddReservation(context.GetArgument<Reservation>("reservation"));});
    }
}