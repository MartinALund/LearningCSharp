namespace DependencyInjectionDemo
{
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
}