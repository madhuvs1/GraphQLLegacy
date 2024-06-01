
using Microsoft.EntityFrameworkCore;

public class CategoryRepository : ICategoryRepository
{
    private GraphQLDbContext _graphQLDbContext;
    public CategoryRepository(GraphQLDbContext graphQLDbContext)
    {
        _graphQLDbContext = graphQLDbContext;
    }
    public Category AddCategory(Category category)
    {
       _graphQLDbContext.Categories.Add(category);
       _graphQLDbContext.SaveChanges();
       return category;
    }

    public void DeleteCategory(int categoryId)
    {
       var categoryToDelete = _graphQLDbContext.Categories.Find(categoryId);
       _graphQLDbContext.Categories.Remove(categoryToDelete);
    }

    public IList<Category> GetCategories()
    {
        return _graphQLDbContext.Categories.ToList();
    }

    public Category GetCategory(int categoryId)
    {
        return _graphQLDbContext.Categories.Find(categoryId);
    }

    public Category UpdateCategory(int categoryId, Category category)
    {
        var categoryToUpdate = _graphQLDbContext.Categories.Find(categoryId);
        categoryToUpdate.Name = category.Name;
        categoryToUpdate.ImageUrl = category.ImageUrl;
        _graphQLDbContext.SaveChanges();
        return category;
    }
}