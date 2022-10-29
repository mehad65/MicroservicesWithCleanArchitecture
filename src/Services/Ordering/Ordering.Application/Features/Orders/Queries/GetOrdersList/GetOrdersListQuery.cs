using MediatR;

namespace Ordering.Application.Features.Orders.Queries.GetOrderList
{
    public class GetOrdersListQuery : IRequest<List<OrdersDTO>>
    {
        public string UserName { get; set; }
        public GetOrdersListQuery(string username)
        {
            UserName = username;
        }
    }
}
