var builder = WebApplication.CreateBuilder(args);
//what this line does is it creates Application builder.

builder.Services.AddControllers();
//this tells asp.net that this app will use controller

builder.Services.AddOpenApi();
//this enables OpenAPI support so that we can describe/test our API.

var app = builder.Build();
//so the configuration we created through builder = turns into a web application.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
