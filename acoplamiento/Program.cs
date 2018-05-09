using System;
using System.Collections.Generic;

namespace acoplamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new OrderService(new OrdersRepository());
            var pedidos = service.GetOrders();

            foreach (var pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }
        }
    }

    public class OrderService
    {
        OrdersRepository _ordersRepository;
        public OrderService(OrdersRepository repository)
        {
            _ordersRepository= repository;
        }

        public List<string> GetOrders()
        {
            var orders =  _ordersRepository.GetOrdersFromDB();
            return orders;
        }
    }

    public interface IOrdersRepository
    {
        List<string> GetOrdersFromDB();
    }
    public class OrdersRepository
    {
        public List<string> GetOrder()
        {
            var orders= new List<string>()
            {
                "pedido 1",
                "pedido 2",
                "pedido 3"
            };

        return orders;
        }
    }
}
