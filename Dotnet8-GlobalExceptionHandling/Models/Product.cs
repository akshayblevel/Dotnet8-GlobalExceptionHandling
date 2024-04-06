namespace Dotnet8_GlobalExceptionHandling.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public List<string> Category { get; set; } = new();
        public decimal price { get; set; }
    }
}
