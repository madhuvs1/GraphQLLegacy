using GraphQL.Types;
using GraphQL;
using GraphiQl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IReservationRepository, ReservationRepository>();
builder.Services.AddTransient<MenuType>();
builder.Services.AddTransient<MenuQuery>();
builder.Services.AddTransient<MenuMutation>();
builder.Services.AddTransient<MenuInputType>();
builder.Services.AddTransient<ISchema, MenuSchema>();
builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());
builder.Services.AddDbContext<GraphQLDbContext>(option => option.UseSqlite(builder.Configuration.GetConnectionString("GraphQLDbContextConnection")));
var app = builder.Build();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();
