using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public interface IOrder
    {
        string PrintOrder();
    }

    public class Order : IOrder
    {
        private readonly IItem _item;
        private readonly ICustomer _customer;

        public Order(IItem item, ICustomer customer)
        {
            _item = item;
            _customer = customer;
        }
        public string PrintOrder()
        {
            return $"{_customer.GetName()} har købt {_item.GetItemName()}";
        }
    }

    public interface IItem
    {
        string GetItemName();
    }

    public class Item : IItem
    {
        public string GetItemName()
        {
            return "Vandflaske";
        }
    }

    public interface ICustomer
    {
        string GetName();
    }

    public class Customer : ICustomer
    {
        public string GetName()
        {
            return "Martin Lund";
        }
    }


}
