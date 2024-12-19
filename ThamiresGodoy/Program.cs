var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner.
builder.Services.AddControllers(); // Adiciona suporte para controladores MVC
builder.Services.AddAuthorization(); // Adiciona suporte à autorização
builder.Services.AddEndpointsApiExplorer(); // Necessário para endpoints minimal API
builder.Services.AddSwaggerGen(); // Gera documentação Swagger

var app = builder.Build();

// Configura o pipeline de requisições HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

app.UseAuthorization(); // Middleware de autorização
app.MapControllers(); // Mapeia controladores para endpoints
app.Run();

