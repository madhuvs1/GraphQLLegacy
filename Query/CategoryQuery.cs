using GraphQL;
using GraphQL.Types;

public class CategoryQuery : ObjectGraphType
{
    public CategoryQuery(ICategoryRepository categoryRepository)
    {
        Field<ListGraphType<CategoryType>>("Categories").Resolve(context =>
            {
                return categoryRepository.GetCategories();
            }
        );
        Field<CategoryType>("GetCategory").Arguments(new QueryArgument<IntGraphType> { Name = "categoryId" }).Resolve(context =>
       {
           return categoryRepository.GetCategory(context.GetArgument<int>("categoryId"));
       }
        );
    }
}