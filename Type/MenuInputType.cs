using GraphQL.Types;

public class MenuInputType: InputObjectGraphType {
public MenuInputType()
{
    Field<IntGraphType>("id");
    Field<StringGraphType>("name");
    Field<StringGraphType>("description");
    Field<FloatGraphType>("price");

}
}