using Optivem.Atomiv.Core.Domain;
using TextAnalyzer.Core.Domain.Customers;
using TextAnalyzer.Core.Domain.Products;
using System.Collections.Generic;

namespace TextAnalyzer.Core.Domain.Orders
{
    public interface IOrderFactory : IFactory
    {
        Order CreateNewOrder(CustomerIdentity customerId, IEnumerable<OrderItem> orderItems);

        OrderItem CreateNewOrderItem(ProductIdentity productId, decimal unitPrice, int quantity);
    }
}
