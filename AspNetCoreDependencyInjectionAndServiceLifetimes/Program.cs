using AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions;
using AspNetCoreDependencyInjectionAndServiceLifetimes.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISubServiceWithScopedLifetime, SubServiceWithScopedLifetime>();
builder.Services.AddSingleton<ISubServiceWithSingletonLifetime, SubServiceWithSingletonLifetime>();
builder.Services.AddTransient<ISubServiceWithTransientLifetime, SubServiceWithTransientLifetime>();
builder.Services.AddScoped<ITestService1, TestService1>();
builder.Services.AddScoped<ITestService2, TestService2>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
