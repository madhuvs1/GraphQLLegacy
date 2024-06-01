using GraphQL.Types;

public class CategoryInputType: InputObjectGraphType<Category>  {
    public CategoryInputType()
    {
        Field<IntGraphType>("id");
        Field<StringGraphType>("name"); 
        Field<StringGraphType>("imageUrl");
    }
}
