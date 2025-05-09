using OP.Models;

namespace OP.Service
{
    public interface IOrderDetails
    {

        void SetOrderDetails(Orders order);
        public List<Orders> GetOrderDetails();
    }
}
