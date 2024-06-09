using Application.Common.Contracts;
using MediatR;

namespace Application.Products.Commands.DeleteProduct;
public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Unit>
{
    private readonly IMayurSampleDbContext _context;

    public DeleteProductCommandHandler(IMayurSampleDbContext context)
    {
        _context = context;
    }
    public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Products.FindAsync(request.Id);

        if (entity == null)
        {
            throw new Exception("Product not found");
            //throw new NotFoundException(nameof(Product), request.Id);
        }

        _context.Products.Remove(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
