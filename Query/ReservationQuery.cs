using System.Reflection.Metadata.Ecma335;
using GraphQL;
using GraphQL.Types;

public class ReservationQuery: ObjectGraphType<Reservation> {
    public ReservationQuery(IReservationRepository reservationRepository)
    {
        Field<ListGraphType<ReservationType>>("Reservations").Resolve(r =>
          {
            return reservationRepository.GetReservations();
          }
         );

         Field<ReservationType>("Reservation").Arguments(new QueryArguments(new QueryArgument<IntGraphType>{Name = "id"})).Resolve(context => {
            return reservationRepository.GetReservation(context.GetArgument<int>("id"));
         }); 
    }
}