using Optivem.Atomiv.Core.Domain;
using TextAnalyzer.Core.Common.Orders;
using TextAnalyzer.Core.Domain.Products;

namespace TextAnalyzer.Core.Domain.Orders
{
    public interface IReadonlyOrderItem : IReadonlyEntity<OrderItemIdentity>
    {
        ProductIdentity ProductId { get; }

        int Quantity { get; }

        decimal UnitPrice { get; }

        OrderItemStatus Status { get; }
    }
}
