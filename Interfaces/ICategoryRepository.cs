public interface ICategoryRepository {
    IList<Category> GetCategories(); 

    Category GetCategory(int categoryId);

    Category AddCategory(Category category);

    Category UpdateCategory(int categoryId, Category category);

    void DeleteCategory(int categoryId);
}