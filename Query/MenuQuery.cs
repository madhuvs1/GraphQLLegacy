using GraphQL;
using GraphQL.Types;

public class MenuQuery : ObjectGraphType
{
    public MenuQuery(IMenuRepository menuRepository)
    {
        Console.WriteLine("MenuQuery constructor called");
        Field<ListGraphType<MenuType>>("Menus").Resolve(context => { return menuRepository.GetAllMenu();} );
        Field<MenuType>("Menu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" })).
        Resolve(context =>
        {
            return menuRepository.GetMenuById(context.GetArgument<int>("menuId"));
        }
         );
    }
}