using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.FileProviders;
using simple_crud.Db;
using simple_crud.Interfaces;
using simple_crud.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddHttpContextAccessor();

var sqlConnection = !builder.Environment.IsDevelopment() ?
                    builder.Configuration["ConnectionStrings:DefaultConnection"]:
                    builder.Configuration["ConnectionStrings:LocalDbConnection"];
var storageConnection = builder.Configuration["ConnectionStrings:StorageConnection"];

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(sqlConnection);
});

builder.Services.AddAzureClients(azureBuilder => {
    azureBuilder.AddBlobServiceClient(storageConnection);
});

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddSingleton<IImageStorageRepository, LocalImageStorageRepository>();

if(!builder.Environment.IsDevelopment())
{
    builder.Services.AddSingleton<IImageStorageRepository, AzureImageStorageRepository>();
}


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "uploads")),
    RequestPath = "/uploads"
});

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();



app.Run();

