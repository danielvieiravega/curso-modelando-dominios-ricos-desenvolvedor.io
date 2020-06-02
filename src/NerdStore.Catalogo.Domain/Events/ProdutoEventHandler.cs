using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoEventHandler : INotificationHandler<ProdutoAbaixoEstoqueEvent>
    {
    }
}
