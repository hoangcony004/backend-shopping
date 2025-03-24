using shopping_api.Model.order;
using shopping_api.Repository;

namespace shopping_api.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllAsync();
        }

        public async Task<Order?> GetOrderByIdAsync(int id)
        {
            return await _orderRepository.GetByIdAsync(id);
        }

        public async Task CreateOrderAsync(Order order)
        {
            await _orderRepository.AddAsync(order);
            await _orderRepository.SaveChangesAsync();
        }

        public async Task UpdateOrderAsync(Order order)
        {
            await _orderRepository.UpdateAsync(order);
            await _orderRepository.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int id)
        {
            await _orderRepository.DeleteAsync(id);
            await _orderRepository.SaveChangesAsync();
        }
    }
}
