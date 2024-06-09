using Application.Common.Contracts;
using Domain.Entities;
using MediatR;

namespace Application.Products.Commands.CreateProduct;
public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly IMayurSampleDbContext _context;
    public CreateProductCommandHandler(IMayurSampleDbContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = new Product
        {
            ProductName = request.ProductName,
            UnitPrice = request.UnitPrice,
        };

        _context.Products.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.ProductId;
    }
}
