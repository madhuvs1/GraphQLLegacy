using GraphQL.Types;

public class RootMutation: ObjectGraphType{
    public RootMutation()
    {
     Field<MenuMutation>("menuMutation").Resolve(context => new {});
     Field<CategoryMutation>("categoryMutation").Resolve(context => new {});
     Field<ReservationMutation>("reservationMutation").Resolve(context => new {});
    }
}