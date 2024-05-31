using GraphQL;
using GraphQL.Types;

public class MenuMutation: ObjectGraphType {
public MenuMutation(IMenuRepository menuRepository)
{
     Field<MenuType>("CreateMenu").Arguments(new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" })).
        Resolve(context =>
        {
            return menuRepository.AddMenu(context.GetArgument<Menu>("menu"));
        });

        Field<MenuType>("UpdateMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId"}, new QueryArgument<MenuInputType> { Name = "menu" })).
        Resolve(context =>
        {
            return menuRepository.UpdateMenu(context.GetArgument<int>("menuId"), context.GetArgument<Menu>("menu"));
        });

        Field<StringGraphType>("DeleteMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId"})).
        Resolve(context =>
        {
             menuRepository.DeleteMenu(context.GetArgument<int>("menuId"));
             return $"MenuId {context.GetArgument<int>("menuId")} is deleted"; 
        });
}
}