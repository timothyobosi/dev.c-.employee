using MyAPIs.Data;
using Microsoft.EntityFrameworkCore;

var builder =  WebApplication.CreateBuilder(args);

//add servicess to the container
builder.Services.AddControllers();
builder.Services.AddDbContext<EmployeeContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

