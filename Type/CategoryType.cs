using GraphQL.Types;

public class CategoryType: ObjectGraphType<Category> {
    public CategoryType(IMenuRepository menuRepository)
    {
        Field(c => c.Id);
        Field(c => c.Name);
        Field(c => c.ImageUrl);
        Field<ListGraphType<MenuType>>("Menus").Resolve(context => {return menuRepository.GetAllMenu();});
      
    }
}
