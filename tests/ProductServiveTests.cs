namespace tests
{
    using api.Services;
    using Xunit;

    public class ProductServiveTests
    {
        [Fact]
        public void is_product_in_stock(){
            ProductService service = new ProductService();
            var actual = service.IsProductInStock(1);
            var expected = true;

            Assert.Equal(expected, actual);
        }
    }
}