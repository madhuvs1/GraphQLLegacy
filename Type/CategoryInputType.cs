using GraphQL.Types;

public class CategoryInputType: InputObjectGraphType<Category>  {
    public CategoryInputType()
    {
        Field<IntGraphType>("id");
        Field<StringGraphType>("nmae");
        Field<StringGraphType>("imageUrl");
        Field<ListGraphType<MenuInputType>>("menus");
    }
}
