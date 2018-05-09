using System;
using System.Collections.Generic;

namespace acoplamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrdersRepository repository = new OrdersFromAPIRepository();

            var service = new OrdersService(repository);

            var pedidos = service.GetOrders();
            foreach (var pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }
        }
    }

    public class OrdersService
    {
        IOrdersRepository _ordersRepository;
        public OrdersService(IOrdersRepository repository)
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

    public class OrdersVromAPIRepository : IOrdersRepository
    {
        
    }
}
