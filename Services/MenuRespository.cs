public class MenuRepository : IMenuRepository
{
    private GraphQLDbContext dbContext;
    public MenuRepository(GraphQLDbContext graphQLDbContext)
    {
        dbContext = graphQLDbContext;
    }
  private static List<Menu> MenuList = new List<Menu>()
        {
            new Menu() { Id = 1, Name = "Classic Burger", Description="A juicy chicken burger with lettuce and cheese" , Price = 8.99},
            new Menu() { Id = 2, Name = "Margherita Pizza", Description = "Tomato, mozzarella, and basil pizza", Price = 10.50 },
            new Menu() { Id = 3, Name = "Grilled Chicken Salad", Description = "Fresh garden salad with grilled chicken", Price = 7.95 },
            new Menu() { Id = 4, Name = "Pasta Alfredo", Description = "Creamy Alfredo sauce with fettuccine pasta", Price = 12.75 },
            new Menu() { Id = 5, Name = "Chocolate Brownie Sundae", Description = "Warm chocolate brownie with ice cream and fudge", Price = 6.99 },

        };

    public Menu AddMenu(Menu menu)
    {
        dbContext.Menus.Add(menu);
        dbContext.SaveChanges();
        return menu;
    }

    public void DeleteMenu(int id)
    {
        var menuResult = dbContext.Menus.Find(id);
        dbContext.Menus.Remove(menuResult);
        dbContext.SaveChanges();
    }

    public List<Menu> GetAllMenu()
    {
        return  dbContext.Menus.ToList();
    }

    public Menu GetMenuById(int id)
    {
        return dbContext.Menus.Find(id);
    }

    public Menu UpdateMenu(int id, Menu menu)
    {
        var menuResult = dbContext.Menus.Find(id);
        menuResult.Name = menu.Name;
        menuResult.Description = menu.Description;
        menuResult.Price = menu.Price;
       dbContext.SaveChanges();
       return menu;
    }
}




// public class MenuRepository : IMenuRepository
// {
//     private GraphQLDbContext dbContext;
//     public MenuRepository(GraphQLDbContext graphQLDbContext)
//     {
//         dbContext = graphQLDbContext;
//     }
//   private static List<Menu> MenuList = new List<Menu>()
//         {
//             new Menu() { Id = 1, Name = "Classic Burger", Description="A juicy chicken burger with lettuce and cheese" , Price = 8.99},
//             new Menu() { Id = 2, Name = "Margherita Pizza", Description = "Tomato, mozzarella, and basil pizza", Price = 10.50 },
//             new Menu() { Id = 3, Name = "Grilled Chicken Salad", Description = "Fresh garden salad with grilled chicken", Price = 7.95 },
//             new Menu() { Id = 4, Name = "Pasta Alfredo", Description = "Creamy Alfredo sauce with fettuccine pasta", Price = 12.75 },
//             new Menu() { Id = 5, Name = "Chocolate Brownie Sundae", Description = "Warm chocolate brownie with ice cream and fudge", Price = 6.99 },

//         };

//     public Menu AddMenu(Menu menu)
//     {
//         MenuList.Add(menu);
//         return menu;
//     }

//     public void DeleteMenu(int id)
//     {
//         MenuList.RemoveAt(id);
//     }

//     public List<Menu> GetAllMenu()
//     {
//         return  MenuList;
//     }

//     public Menu GetMenuById(int id)
//     {
//         return MenuList.Find(m => m.Id == id);
//     }

//     public Menu UpdateMenu(int id, Menu menu)
//     {
//         MenuList[id] = menu;
//         return menu;
//     }
// }
