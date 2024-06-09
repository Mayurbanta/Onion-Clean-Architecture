using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Commands.UpdateProduct;
public class UpdateProductCommand : IRequest<Unit>
{
    public int ProductId { get; set; }

    public required string ProductName { get; set; }

    public decimal? UnitPrice { get; set; }
}
