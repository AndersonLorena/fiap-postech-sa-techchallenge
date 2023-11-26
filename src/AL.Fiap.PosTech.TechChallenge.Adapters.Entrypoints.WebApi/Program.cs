using AL.Fiap.PosTech.TechChallenge.Application.Configurations;
using AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.Configurations;
using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add custom services to the container.
builder.Services.AddCustomAutoMapperConfiguration();
builder.Services.AddCustomFluentValidationConfiguration();
builder.Services.AddCustomMediatRConfiguration();
builder.Services.AddCustomSqlServerPersistenceConfiguration(builder.Configuration);

// Add services to the container.
builder.Services.AddScoped<LogAsyncActionFilter>();
builder.Services.AddControllers(options =>
{
    options.Filters.Add<LogAsyncActionFilter>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();