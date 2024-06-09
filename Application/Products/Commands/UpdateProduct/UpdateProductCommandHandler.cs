using Application.Common.Contracts;
using MediatR;

namespace Application.Products.Commands.UpdateProduct;
public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
{
    private readonly IMayurSampleDbContext _context;

    public UpdateProductCommandHandler(IMayurSampleDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Products.FindAsync(request.ProductId);
        if (entity == null)
        {
            throw new Exception("Product not found");
            //throw new NotFoundException(nameof(Product), request.ProductId);
        }
        entity.ProductId = request.ProductId;
        entity.ProductName = request.ProductName;
        entity.UnitPrice = request.UnitPrice;

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
