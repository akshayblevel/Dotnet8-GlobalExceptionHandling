using BuildingBlocks.Exceptions;

namespace Dotnet8_GlobalExceptionHandling.Exceptions
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(Guid Id) : base("Product", Id)
        {
        }
    }
}
