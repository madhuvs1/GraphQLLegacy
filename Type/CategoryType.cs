using GraphQL.Types;

public class CategoryType: ObjectGraphType<Category> {
    public CategoryType()
    {
        Field(c => c.Id);
        Field(c => c.Name);
        Field(c => c.ImageUrl);
        Field(c => c.Menus);
    }
}
