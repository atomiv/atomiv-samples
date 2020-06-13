using Optivem.Atomiv.Core.Domain;

namespace TextAnalyzer.Core.Domain.Products
{
    public interface IProductFactory : IFactory
    {
        Product CreateNewProduct(string productCode, string productName, decimal listPrice);
    }
}
