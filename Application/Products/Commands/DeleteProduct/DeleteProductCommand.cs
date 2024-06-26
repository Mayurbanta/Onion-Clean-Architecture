﻿using MediatR;

namespace Application.Products.Commands.DeleteProduct;
public class DeleteProductCommand : IRequest<Unit>
{
    public int Id { get; set; }
}
