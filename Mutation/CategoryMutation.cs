using GraphQL;
using GraphQL.Types;

public class CategoryMutation: ObjectGraphType {
    public CategoryMutation(ICategoryRepository categoryRepository)
    {
        Field<CategoryType>("CreateCategory").Arguments(new QueryArguments(new QueryArgument<CategoryInputType> { Name = "category"} )).Resolve(context => 
          {
            return categoryRepository.AddCategory(context.GetArgument<Category>("category"));
          });

        Field<CategoryType>("UpdateCategory").Arguments(new QueryArguments(
            new QueryArgument<IntGraphType>{Name = "categoryId" }, new QueryArgument<CategoryInputType>{ Name = "category"}))
            .Resolve(context => {
                return categoryRepository.UpdateCategory(context.GetArgument<int>("id"), context.GetArgument<Category>("category"));
            });
        Field<CategoryType>("DeleteCategory").Arguments(new QueryArguments(new QueryArgument<IntGraphType> {Name = "categoryId"})).Resolve(
            context => {
                 categoryRepository.DeleteCategory(context.GetArgument<int>("categoryId"));
                 return $"Category {context.GetArgument<int>("categoryId")} deleted";
            }
        );
    }
}