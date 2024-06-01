using System.Reflection.Metadata.Ecma335;
using GraphQL.Types;
using GraphQLParser.AST;

public class ReservationQuery: ObjectGraphType<Reservation> {
    public ReservationQuery(IReservationRepository reservationRepository)
    {
        Field<ListGraphType<ReservationType>>("GetReservations").Resolve(r =>
          {
            return reservationRepository.GetReservations();
          }
         );

         Field<ReservationType>("GetReservation").Arguments(new GraphQLArgument() )
    }

   
}