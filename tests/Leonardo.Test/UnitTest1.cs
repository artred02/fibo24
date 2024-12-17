using Microsoft.EntityFrameworkCore;

namespace Leonardo.Test;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var builder = new DbContextOptionsBuilder<FibonacciDataContext>(); 
        var dataBaseName = Guid.NewGuid().ToString(); 
        builder.UseInMemoryDatabase(dataBaseName);  
        var options = builder.Options; 
        var fibonacciDataContext = new FibonacciDataContext(options); 
        await fibonacciDataContext.Database.EnsureCreatedAsync(); 
    }
}