namespace ShippoTests.Integration;

using Shippo;
using OrderStatusEnum = Shippo.Models.Components.OrderStatusEnum;
using Address = Shippo.Models.Components.Address;
using Transactions = Shippo.Models.Components.Transactions;

[Collection("Integration")]
public class OrdersTest
{
    SDKFixture sdkFixture;

    public OrdersTest(SDKFixture sdkFixture)
    {
        this.sdkFixture = sdkFixture;
    }

    [Fact]
    public async void TestListOrders()
    {
        ListOrdersRequest req = new ListOrdersRequest()
        {
            ShopApp = OrderShopAppEnum.Shippo,
        };

        var orders = await sdkFixture.SDK.Orders.ListAsync(req);

        orders.Should().NotBeNull()
            .And.BeOfType<OrderPaginatedList>();
        orders.Results.Should().NotBeNull()
            .And.BeOfType<List<Order>>();
        if (orders.Results is not null && orders.Results.Count > 0)
        {
            orders.Results.Should().AllSatisfy(order =>
            {
                order.OrderStatus.Should().NotBeNull();
                order.Should().NotBeNull();
                order.ObjectId.Should().BeOfType<string>();
                order.ToAddress.Should().BeOfType<Address>();
                order.FromAddress.Should().BeOfType<Address>();
                order.Transactions.Should().BeOfType<List<Transactions>>();
            });
        }
    }
}