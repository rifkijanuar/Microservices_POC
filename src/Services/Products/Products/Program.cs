using Products.Services.Application.Services;
using Products.Services.Core.Interface;
using Products.Services.Infrastracture.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IProduct, Product>();
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.MapControllerRoute(
//        name: "default",
//        pattern: "api/{controller}/{action}"
//    );

app.Run();
