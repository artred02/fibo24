var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/Fibonacci", 
    async () => await Leonardo.Fibonacci.RunAsync(new []{"2", "3"}));

app.Run();
