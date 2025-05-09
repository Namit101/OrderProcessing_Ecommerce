using OP.Models;

namespace OP.Service
{

    
    public class OrderDetails : IOrderDetails
    {

       private readonly OrderDbContext _context;

        public OrderDetails(OrderDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void SetOrderDetails(Orders orders)
        {
            if (orders.OrderId == 0)
            {
                _context.Order.Add(orders);
                
            }
            else
            {
                _context.Order.Update(orders);

            }
            _context.SaveChanges();

        }

        public List<Orders> GetOrderDetails()
        {
            var orderDetails = _context.Order.ToList();
            return orderDetails;
        }
    }
}
