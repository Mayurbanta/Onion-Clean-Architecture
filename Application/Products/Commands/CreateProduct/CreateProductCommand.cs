using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Products.Commands.CreateProduct;
public class CreateProductCommand : IRequest<int>
{
    public required string ProductName { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? SupplierId { get; set; }

    public int? CategoryId { get; set; }

    public bool Discontinued { get; set; }
}
