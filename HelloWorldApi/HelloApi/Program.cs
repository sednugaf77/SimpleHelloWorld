var builder = WebApplication.CreateBuilder(args);

// Adiciona documentação automática (Swagger)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Mostra o painel Swagger se estiver em desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Endpoint mínimo: responde "Olá! Eu sou uma API .NET!" em /hello
app.MapGet("/", () => "Olá! Eu sou uma API .NET!");

app.Run();
